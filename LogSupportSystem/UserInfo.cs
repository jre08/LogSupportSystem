using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogSupportSystem
{
    class UserInfo
    {
        static public string Name
        {
            get 
            {
                return Environment.UserName;
            }
        }

        static public string MachineName
        {
            get
            {
                return Environment.MachineName;
            }
        }

        public static string GetTeamviewerID()
        {
            try
            {
                string regPath = Environment.Is64BitOperatingSystem ? @"SOFTWARE\Wow6432Node\TeamViewer" : @"SOFTWARE\TeamViewer";
                RegistryKey key = Registry.LocalMachine.OpenSubKey(regPath);
                if (key == null)
                    return string.Empty;
                object clientId = key.GetValue("ClientID");
                if (clientId != null)
                    return Regex.Replace(clientId.ToString(), ".{3}(?!$)", "$0-");

                foreach (string subKeyName in key.GetSubKeyNames().Reverse()) //older versions
                {
                    clientId = key.OpenSubKey(subKeyName).GetValue("ClientID");
                    if (clientId != null)
                        return Regex.Replace(clientId.ToString(), ".{3}(?!$)", "$0-");
                }
                return string.Empty;
            }
            catch (Exception e)
            {
                return string.Empty;
            }
        }
    }
}
