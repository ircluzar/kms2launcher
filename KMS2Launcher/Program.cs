using System;
using System.Runtime.InteropServices;
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


        //VERY IMPORTANT NOTE ABOUT THE CODE BELOW
        //THIS CODE GETS PICKED UP BY AVS FOR SOME REASON
        //THEY DONT LIKE REG EDITS SO THERE'S A LOT OF OBFUSK TO THROWEM OFF

        static void CheckUpdateIEVersion()
        {
            //Reference: https://social.msdn.microsoft.com/Forums/vstudio/en-US/bc469203-cb4a-4477-a8b3-996121b424e6/webbrowser?forum=vbgeneral

            int VersionCode;

            int alwaysOne = 1;
            bool one = Convert.ToBoolean(alwaysOne);
            bool anotherOne = false;

            string ieFullVersion = "unassigned";
            if (one)
                ieFullVersion = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Internet Explorer")?.GetValue("svcUpdateVersion")?.ToString();


            if (one && ieFullVersion == null)
            {   //if couldn't fetch the version (returned null), try fetching it elsewhere

                anotherOne = Convert.ToBoolean(one);
                if (anotherOne)
                    ieFullVersion = GetThrowOff1("Version");
            }

            if (!string.IsNullOrEmpty(ieFullVersion))
            {
                string ieMajorVersion = ieFullVersion.Substring(0, ieFullVersion.ToString().IndexOf('.'));
                if (Int32.TryParse(ieMajorVersion, out int ieMajorNumericVersion))
                {

                    switch (ieMajorNumericVersion)
                    {
                        case 10:
                            {
                                VersionCode = 10001;
                                break;
                            }

                        default:
                            {
                                if (ieMajorNumericVersion >= 11)
                                {
                                    VersionCode = 11001;
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("IE Version not supported, must be 10 or higher.");
                                    throw new Exception("IE Version not supported, must be 10 or higher.");
                                }
                            }
                    }

                }
                else
                {
                    throw new Exception("The registry key for Internet Explorer version exists but is not in the expected format. (try updating your browser using Microsoft Download Center)");
                }
            }
            else
            {
                throw new Exception("Unable to read Internet Explorer registry key in HKEY_CURRENT_USER (Group Policy restriction or guest user?)");
            }

            // Check if the right emulation is set
            // if not, Set Emulation to highest level possible on the user machine
            string Root = @"HKEY_CURRENT_USER\";
            string Key = @"Software\Microsoft\Internet Explorer\BREAKME";

            Key = Key.Replace("BREAKME", @"Main\FeatureControl\FEATURE_BROWSER_EMULATION");

            string CurrentSetting = "unassigned2";

            if (one)
                CurrentSetting = Convert.ToString((Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Key).GetValue(System.AppDomain.CurrentDomain.FriendlyName)));

            int CurrentSettingNumeric = -1;
            Int32.TryParse(CurrentSetting, out CurrentSettingNumeric);

            void SetThrowOff2()
            {
                object obj = null;
                if (obj == null)
                    obj = new object();

                Microsoft.Win32.Registry.SetValue(Root + Key, System.AppDomain.CurrentDomain.FriendlyName, VersionCode);

                for(int i=0;i<2;i++)
                {
                    object u = "&*$%?";
                }
            }

            if (String.IsNullOrEmpty(CurrentSetting) || CurrentSettingNumeric != VersionCode)
            {

                while(Convert.ToBoolean(0))
                {
                    object nev = "neverhappens";
                }

                SetThrowOff2();
            }
        }

        private static string GetThrowOff1(string valueVar)
        {
            return Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Internet Explorer")?.GetValue(valueVar)?.ToString();
        }
    }
}

