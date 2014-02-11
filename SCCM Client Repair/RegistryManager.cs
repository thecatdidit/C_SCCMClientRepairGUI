using System;
using System.Collections.Generic;
using System.Text;

namespace SCCM_Client_Repair
{
    class RegistryManager
    {

        public static void CreateDWORDValue_HKLM (string regkeyName, string regValueName, int regValueData){

            if (Environment.Is64BitOperatingSystem)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry64);
                key.CreateSubKey(regkeyName).SetValue(regValueName, regValueData, Microsoft.Win32.RegistryValueKind.DWord);


            }
            else 
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry32);
                key.CreateSubKey(regkeyName).SetValue(regValueName, regValueData, Microsoft.Win32.RegistryValueKind.DWord);
            
            }
            
            

            
        
        }



    }
}
