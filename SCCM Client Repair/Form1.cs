using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Configuration; 

namespace SCCM_Client_Repair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BackgroundWorker worker = new BackgroundWorker();


        private void button_Repair_Click(object sender, EventArgs e)
        {

            //Hide button to prevent accidental repeat
            button_Repair.Hide();


            //Check for msiexec, ccmsetup, or setup.exe's
            string[] processList = { "setup", "msiexec", "ccmsetup" };
            string runningProcess = ProcessManager.CheckProcess(processList); 
            if (runningProcess != "")
            {
                FailOut("Another installation is in progress. SCCM Client Repair cannot continue. Please exit all other applications or reboot the workstation." + 
                        Environment.NewLine + Environment.NewLine + "Details" + Environment.NewLine + "Process = " + runningProcess);
            }
            else {

                //Show main label
                labelMain.Visible = true;

                //Initialize the BG worker thread. 
                worker.DoWork += new DoWorkEventHandler(worker_DoWork);
                worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
                worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
                worker.WorkerReportsProgress = true;
                worker.RunWorkerAsync();         
            
            }

          

        }


        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
          
            
            //Delete CCM setup logs and start CCMClean and CCMSetup for uninstall and install respectively. 
            if (File.Exists("C:\\Windows\\ccmsetup\\logs\\ccmsetup.log"))
            {
                File.Delete("C:\\Windows\\ccmsetup\\logs\\ccmsetup.log");
            }            
            worker.ReportProgress(16, "Uninstalling SCCM");            
            ProcessManager.StartProcess(System.Configuration.ConfigurationManager.AppSettings["CCMClean"], "/q"); 
            worker.ReportProgress(32, "Installing SCCM");            
            ProcessManager.StartProcess(System.Configuration.ConfigurationManager.AppSettings["CCMSetup"], "/mp:uphmanndc012 SMSSITECODE=UPM"); 

                           
                        
            //Detect successful install from CCMSetup.log
            worker.ReportProgress(48, "Detecting SCCM Install."); 
            do
            {
                CCMSetup.DetectCCMSetup();
                Thread.Sleep(500); 
            } while (CCMSetup.DetectCCMSetup() == false);  

            //Stop CCMExec Service
            worker.ReportProgress(64, "Stopping CCMExec");
            ServiceManager.Stop("ccmexec");                 
            

            //Create registry key that delays user policy re-request by 500,000 milliseconds (using hex value)
            worker.ReportProgress(80, "Added UserPolicyReRequestDelay");
            RegistryManager.CreateDWORDValue_HKLM("Software\\Microsoft\\CCM", "UserPolicyReRequestDelay", 5242880);            
            

            //Start CCMExec Service
            worker.ReportProgress(96, "Starting CCMExec"); 
            ServiceManager.Start("ccmexec");   
        
        }
     

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            stripProgressBar.Value = e.ProgressPercentage;
            stripLabel.Text = (string)e.UserState;
            
            
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            
            //resize strip label to reach right side of window
            string time = DateTime.Now.ToString("h:mm tt");
            stripLabel.Size = new System.Drawing.Size(350, 17);  
            stripLabel.Text = "Completed at: " + time;

            labelMain.Text = "Please allow 5 minutes for policy download to complete.";
            stripProgressBar.Dispose(); 
        }

        public static void FailOut(string message) {
            MessageBox.Show(message, "Penn Medicine IS - SCCM Client Repair", MessageBoxButtons.OK , MessageBoxIcon.Error);
            Application.Exit(); 
        }


       
        




      
    }
}
