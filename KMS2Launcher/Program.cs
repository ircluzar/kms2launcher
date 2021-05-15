using System;
using System.Windows.Forms;

namespace KMS2Launcher
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //string[] args = Environment.GetCommandLineArgs();
            //if (args.Length == 0)
            //{
            //    Arguments.GameId = "106498";
            //}
            //if (args.Length > 1)
            //{
            //    Arguments.GameId = args[1];
            //}
            //if (args.Length > 2)
            //{
            //    Arguments.StartLocale = args[2];
            //} 
            //if (args.Length > 3)
            //{
            //    Arguments.LoginUrl = args[3];
            //}
            
            CheckUpdateIEVersion();

            Arguments.GameId = "106498";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());
            //Application.Run(new BrowserForm());
        }

        static void CheckUpdateIEVersion()
        {
            //Reference: https://social.msdn.microsoft.com/Forums/vstudio/en-US/bc469203-cb4a-4477-a8b3-996121b424e6/webbrowser?forum=vbgeneral

            int VersionCode;
            string Version = "";
            var ieVersion = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Internet Explorer").GetValue("svcUpdateVersion");

            if (ieVersion is null)
            {
                ieVersion = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Internet Explorer").GetValue("Version");
            }

            if (ieVersion is object)
            {
                Version = ieVersion.ToString().Substring(0, ieVersion.ToString().IndexOf('.'));
                switch (Version ?? "")
                {
                    case "10":
                        {
                            VersionCode = 10001;
                            break;
                        }

                    default:
                        {
                            if (Convert.ToInt32(Version) >= 11)
                            {
                                VersionCode = 11001;
                            }
                            else
                            {
                                MessageBox.Show("IE Version not supported, must be 10 or higher.");
                                throw new Exception("IE Version not supported, must be 10 or higher.");
                            }

                            break;
                        }
                }
            }
            else
            {
                throw new Exception("Registry error");
            }

            // Check if the right emulation is set
            // if not, Set Emulation to highest level possible on the user machine
            string Root = @"HKEY_CURRENT_USER\";
            string Key = @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";

            string CurrentSetting = Convert.ToString((Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Key).GetValue(System.AppDomain.CurrentDomain.FriendlyName)));

            if (CurrentSetting is null || CurrentSetting == "" || Convert.ToInt32(CurrentSetting) != VersionCode)
            {
                Microsoft.Win32.Registry.SetValue(Root + Key, System.AppDomain.CurrentDomain.FriendlyName, VersionCode);
            }
        }
    }
}
