using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EventOneTask
{
    class ClsInstall
    {
        public static void installEXE(string filepath)
        {
            Process process = new Process();
            process.StartInfo.FileName = filepath;
            process.StartInfo.Arguments = "/VERYSILENT";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
            process.WaitForExit();
        }
        public static void installMSI(string filepath)
        {
            Process process = new Process();
            process.StartInfo.FileName = "msiexec.exe";
            process.StartInfo.Arguments = string.Format(" /qb /i \"{0}\" ALLUSERS=1", filepath);
            process.Start();
            process.WaitForExit();
        }

        public static bool isDriverInstalled(string p_name)
        {
            string keyName;

            // search in: CurrentUser
            keyName = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            if (ExistsInSubKey(Registry.CurrentUser, keyName, "DisplayName", p_name) == true)
            {
                return true;
            }

            // search in: LocalMachine_32
            keyName = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            if (ExistsInSubKey(Registry.LocalMachine, keyName, "DisplayName", p_name) == true)
            {
                return true;
            }

            // search in: LocalMachine_64
            keyName = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            if (ExistsInSubKey(Registry.LocalMachine, keyName, "DisplayName", p_name) == true)
            {
                return true;
            }

            return false;
        }

        public static bool isDriverInstalled(string pName, out string status)
        {
            if (isDriverInstalled(pName) == true)
            {
                status = "Installed";
                return true;
            }

            status = "Not Installed";
            return false;
        }

        private static bool ExistsInSubKey(RegistryKey p_root, string p_subKeyName, string p_attributeName, string p_name)
        {
            RegistryKey subkey;
            string displayName;

            using (RegistryKey key = p_root.OpenSubKey(p_subKeyName))
            {
                if (key != null)
                {
                    foreach (string kn in key.GetSubKeyNames())
                    {
                        using (subkey = key.OpenSubKey(kn))
                        {
                            displayName = subkey.GetValue(p_attributeName) as string;
                            if (p_name.Equals(displayName, StringComparison.OrdinalIgnoreCase) == true)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public void loadDataintoListView()
        {

        }
    }
}
