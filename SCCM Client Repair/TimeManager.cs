using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCCM_Client_Repair
{
    class TimeManager

    {
        public static void Delay(int time) {

            System.Timers.Timer timer = new System.Timers.Timer(time);
            timer.AutoReset = false;
            timer.Enabled = true;
            timer.Start(); 
            
        
        }
    }
}
