using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceProcess;
using System.Threading; 

namespace SCCM_Client_Repair
{
    class ServiceManager
    {

     
        public static void Start(string serviceName) {
            ServiceController sc = new ServiceController(serviceName);       
            
            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                
                sc.Start();                
                sc.WaitForStatus(ServiceControllerStatus.Running);
       
            }

        }


        public static void Stop(string serviceName) {
            ServiceController sc = new ServiceController(serviceName);
            if (sc.Status == ServiceControllerStatus.Running) {
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped);
                
                
            }
   
        }



    }
}
