using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS2Launcher
{
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
        public const string LAUNCHER_TAB = nameof(LAUNCHER_TAB);
        public const string GAME_FOLDER = nameof(GAME_FOLDER);
        public const string TRANSLATE_LINK = nameof(TRANSLATE_LINK);
        public const string GOOGLE_FONT = nameof(GOOGLE_FONT);

        public static string GetDefault(string name)
        {
            switch(name)
            {
                case PATCH_SERVER_ROOT:
                    return "https://maplestory2.info/patch"; //This is the server url where the SERVER files have to be put in.
                case GAME_GUIDE:
                    return "http://bit.ly/kms2download";
                case GITHUB_REPO:
                    return "https://github.com/ircluzar/kms2launcher";
                case INSTALLER_URL:
                    return "http://maplestory2.dn.nexoncdn.co.kr/fullinst/fullinst.exe";
                case DISCORD_LINK:
                    return "http://discord.maplestory2.info";
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
                return File.ReadAllText(tentativeFile);
            else
                return defaultValue;
        }

        public static void SetValue(string name, string value)
        {
            string tentativeFile = Path.Combine(AppDir, $"{name}.txt");

            try
            {
                File.WriteAllText(tentativeFile, value);
            }
            catch(Exception ex)
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
}
