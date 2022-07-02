using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace KMS2Launcher
{
    public static class Arguments
    {
        public static string GameId { get; internal set; } = "106498";
        public static string StartLocale { get; internal set; } = "KR";
        public static string LoginUrl { get; internal set; } = "https://clogin.nexon.com/common/clogin.aspx";

        public static string LoginRedirectUrl => $"{LoginUrl}?redirect=http://game.nexon.com/{GameId}";
    }

    static class LauncherSettings
    {
        public static string AppDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "KMSLauncher");
        public static string TempDir = Path.Combine(AppDir, "TEMP");
        public static string PatchDir = Path.Combine(AppDir, "PATCH");

        //setting names
        public const string PATCH_SERVER_ROOT = nameof(PATCH_SERVER_ROOT);
        public const string GAME_GUIDE = nameof(GAME_GUIDE);
        public const string GITHUB_REPO = nameof(GITHUB_REPO);
        public const string DISCORD_LINK = nameof(DISCORD_LINK);
        public const string INSTALLER_URL = nameof(INSTALLER_URL);
        public const string REMEMBER_PASSWORD = nameof(REMEMBER_PASSWORD);
        public const string REMEMBER_USER = nameof(REMEMBER_USER);
        public const string LAUNCHER_TAB = nameof(LAUNCHER_TAB);
        public const string GAME_FOLDER = nameof(GAME_FOLDER);
        public const string TRANSLATE_LINK = nameof(TRANSLATE_LINK);
        public const string GOOGLE_FONT = nameof(GOOGLE_FONT);
        public const string EXITLAG = nameof(EXITLAG);

        public static void MakeSureFolderExists(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not create directory {path}\n\n{ex}");
            }
        }

        public static string GetDefault(string name)
        {
            switch (name)
            {
                case PATCH_SERVER_ROOT:
                    return "https://maplestory2.info/patch"; //This is the server url where the SERVER files have to be put in.
                case GAME_GUIDE:
                    return "https://bit.ly/kms2guide";
                case GITHUB_REPO:
                    return "https://github.com/ircluzar/kms2launcher";
                case INSTALLER_URL:
                    return "http://maplestory2.dn.nexoncdn.co.kr/fullinst/fullinst.exe";
                case DISCORD_LINK:
                    return "https://bit.ly/playkms2";
                case TRANSLATE_LINK:
                    return "http://translate.maplestory2.info";
                case GOOGLE_FONT:
                    return "https://fonts.google.com/specimen/Noto+Sans+KR";
                default:
                    return null;
            }
        }

        public static string GetWebValue(string name)
        {
            string url = $"{GetValue(PATCH_SERVER_ROOT)}/{name}.txt";
            string defaultValue = GetDefault(name);
            try
            {
                WebClient wc = new WebClient();
                string value = wc.DownloadString(url);
                return value;
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrWhiteSpace(defaultValue))
                    return defaultValue;

                MessageBox.Show($"Could not fetch Web Value at {url}\n\n{ex}");
                return null;
            }
        }


        public static string GetValue(string name)
        {
            string tentativeFile = Path.Combine(AppDir, $"{name}.txt");
            string defaultValue = GetDefault(name);

            if (File.Exists(tentativeFile))
            {
                if (name.Contains("REMEMBER"))
                {
                    var data = File.ReadAllText(tentativeFile);
                    var newVal = Compile.Decompile32(data);
                    return newVal;
                }
                else
                {
                    return File.ReadAllText(tentativeFile);
                }
                
            }
            else
                return defaultValue;
        }

        public static void SetValue(string name, string value)
        {
            string tentativeFile = Path.Combine(AppDir, $"{name}.txt");

            try
            {
                if(name.Contains("REMEMBER"))
                {
                    var newVal = Compile.Compile32(value);
                    File.WriteAllText(tentativeFile, newVal);
                }
                else
                {
                    File.WriteAllText(tentativeFile, value);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not fetch saved value at {tentativeFile}\n\n{ex}");
            }
        }

        public static void DeleteValue(string name)
        {
            string tentativeFile = Path.Combine(AppDir, $"{name}.txt");

            try
            {
                if (File.Exists(tentativeFile))
                    File.Delete(tentativeFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not delete saved value at {tentativeFile}\n\n{ex}");
            }
        }

    }


    public static class WebBrowserExtensions
    {
        public static Dictionary<string, string> GetCookies(this WebBrowser webBrowser)
        {
            var result = new Dictionary<string, string>();

            string[] cookieStrings = webBrowser.Document?.Cookie?.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            if (cookieStrings != null)
            {
                for (int i = 0; i < cookieStrings.Length; i++)
                {
                    string cookieString = cookieStrings[i].Trim();
                    int index = cookieString.IndexOf('=');
                    if (index > 0)
                    {
                        string key = cookieString.Substring(0, index);
                        string value = cookieString.Substring(index + 1);

                        result.Add(key, value);
                    }
                }
            }

            return result;
        }
    }


    public static class FormSync
    {
        public static Form SyncObject { get; set; }

        public static void FormExecute(Action a)
        {
            if (a == null)
            {
                throw new ArgumentNullException(nameof(a));
            }

            if (SyncObject.InvokeRequired)
            {
                SyncObject.InvokeCorrectly(new MethodInvoker(a.Invoke));
            }
            else
            {
                a.Invoke();
            }
        }

        //https://stackoverflow.com/a/56931457
        private static object InvokeCorrectly(this Control control, Delegate method, params object[] args)
        {
            Exception failure = null;
            var result = control.Invoke(new Func<object>(() =>
            {
                try
                {
                    return method.DynamicInvoke(args);
                }
                catch (Exception ex)
                {
                    failure = ex.InnerException;
                    return failure;
                }
            }));
            if (failure != null)
            {
                ExceptionDispatchInfo.Capture(failure).Throw();
            }
            return result;
        }
    }

    public enum TabName
    {
        WELCOME,
        INSTALL,
        PATCH,
        LAUNCH
    }
}
