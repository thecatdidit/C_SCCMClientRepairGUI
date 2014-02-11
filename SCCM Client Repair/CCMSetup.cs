using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading; 
using System.Timers; 

namespace SCCM_Client_Repair
{
    class CCMSetup
    {

 

        public static bool DetectCCMSetup()
        {

            string logFilePath = "C:\\Windows\\ccmsetup\\logs\\ccmsetup.log";
            var scriptHour = DateTime.Now.Hour;
            string scriptDate = DateTime.Now.Date.ToString("MM-dd-yyyy");
            string scriptYesterday = DateTime.Now.AddDays(-1).ToString("MM-dd-yyyy");


            //Check for logs existence. If true, look for log line. Return false if log doesn't exist so calling method can try again. 
            if (File.Exists(logFilePath))
            {
                var fs = File.Open(logFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader reader = new StreamReader(fs, Encoding.Default);
                List<string> logList = new List<string>();
                while (reader.EndOfStream == false)
                {
                    var line = reader.ReadLine();
                    logList.Add(line);
                }
                bool IsCCMSuccessful = false;
                foreach (string i in logList)
                {
                    //set up RegEx
                    string pattern = ".......CcmSetup is exiting with return code 0";
                    if (System.Text.RegularExpressions.Regex.IsMatch(i, pattern, RegexOptions.IgnoreCase) & i.Contains(scriptDate))
                    {
                        IsCCMSuccessful = true;
                    }

                    else
                    {
                        IsCCMSuccessful = false;
                    }

                }

                return IsCCMSuccessful; 
                
            }

            else {
                return false; 
            }


           


        }



    }
}
