using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SCCM_Client_Repair
{
    class Log
    {

        public static void Write(string msg)
        {

            string date = DateTime.Now.Date.ToString("MM-dd-yyyy");
            string time = DateTime.Now.TimeOfDay.ToString();

            string tempPath = Path.GetTempPath(); 


            using (StreamWriter sw = new StreamWriter(tempPath + "SCCMClientRepair.log", true))
            {


                sw.WriteLine(date + "  " + time + "  " + msg);

            }




        }
    }
}