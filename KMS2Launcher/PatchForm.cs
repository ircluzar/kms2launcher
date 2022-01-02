using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS2Launcher
{
    public partial class PatchForm : Form
    {
        public bool CurrentlyLoading = false;

        public PatchForm()
        {
            InitializeComponent();

            CurrentlyLoading = true;

            string gameFolder = LauncherSettings.GetValue(LauncherSettings.GAME_FOLDER);
            if (gameFolder != null)
            {
                tbGameDirectory.Text = gameFolder;

                UnlockPatchInterface();
            }
            else
                LockPatchInterface();

            btnRefreshAvailablePatches_Click(null, null);

            var exitlag = LauncherSettings.GetValue(LauncherSettings.EXITLAG);
            if (exitlag == "true")
            {
                cbExitLag.Checked = true;
            }


            CurrentlyLoading = false;
        }

        private void cbVoiceLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVoiceLanguage.SelectedIndex == -1)
                return;

            string gameFolder = tbGameDirectory.Text;
            string configPath = Path.Combine(gameFolder, "Config", "GameOption.xml");

            string language = cbVoiceLanguage.SelectedItem.ToString();

            int languageValue;

            switch (language)
            {
                default:
                case "KOREAN":
                    languageValue = 0;
                    break;
                case "JAPANESE":
                    languageValue = 1;
                    break;
                case "ENGLISH":
                    languageValue = 2;
                    break;
                case "CHINESE":
                    languageValue = 3;
                    break;
            }

            var configData = File.ReadAllText(configPath);

            var normalizedConfig = configData
                .Replace("voiceIndex=\"0\"", "voiceIndex=\"$$$\"")
                .Replace("voiceIndex=\"1\"", "voiceIndex=\"$$$\"")
                .Replace("voiceIndex=\"2\"", "voiceIndex=\"$$$\"")
                .Replace("voiceIndex=\"3\"", "voiceIndex=\"$$$\"");

            var changedConfig = normalizedConfig.Replace("voiceIndex=\"$$$\"", $"voiceIndex=\"{languageValue}\"");

            File.WriteAllText(configPath, changedConfig);

            MessageBox.Show("Config changed successfully");
            cbVoiceLanguage.SelectedIndex = -1;
        }

        public void lbPatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPatches.SelectedIndex == -1)
            {
                lbPatchDescription.Text = "";
                lbPatchStatus.Text = "";
                return;
            }


            string patchname = lbPatches.SelectedItem.ToString();
            string patchDescriptionUrl = $"{LauncherSettings.GetValue(LauncherSettings.PATCH_SERVER_ROOT)}/{patchname}/description.txt";
            string patchDateUrl = $"{LauncherSettings.GetValue(LauncherSettings.PATCH_SERVER_ROOT)}/{patchname}/patchdate.php";

            try
            {
                WebClient wc = new WebClient();
                string patchDescription = wc.DownloadString(patchDescriptionUrl);

                lbPatchDescription.Text = patchDescription;

            }
            catch { } //eat it

            string installedPatchDate = LauncherSettings.GetValue(patchname);

            if (installedPatchDate == null)
                lbPatchStatus.Text = "Not installed";
            else
            {

                string serverPatchDate = null;

                try
                {
                    WebClient wc = new WebClient();
                    serverPatchDate = wc.DownloadString(patchDateUrl);
                }
                catch { } //eat it

                if (serverPatchDate == null)
                {
                    lbPatchStatus.Text = "Error fetching server patch date";
                }
                else
                {
                    string postText = (installedPatchDate == serverPatchDate ? "" : "\n(Update available)");
                    lbPatchStatus.Text = $"Installed patch date:\n{installedPatchDate}\n\nOnline patch date:\n{serverPatchDate}{postText}";
                }




            }

        }


        public void LockPatchInterface()
        {
            btnInstallPatch.Enabled = false;
            cbVoiceLanguage.Enabled = false;
        }

        public void UnlockPatchInterface()
        {
            btnInstallPatch.Enabled = true;
            cbVoiceLanguage.Enabled = true;
        }

        private void btnRefreshAvailablePatches_Click(object sender, EventArgs e)
        {

            string downloadUrl = $"{LauncherSettings.GetValue(LauncherSettings.PATCH_SERVER_ROOT)}/patchlist.php";

            try
            {
                var osVerMajor = System.Environment.OSVersion.Version.Major;
                var osVerMinor = System.Environment.OSVersion.Version.Minor;

                if (((osVerMajor <= 6) && (osVerMinor < 2)))
                { // OS Check for Win 7 SP1 (NT 6.2) or Lower
                    //MessageBox.Show(System.Environment.OSVersion.Version.ToString());
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                }

                WebClient wc = new WebClient();
                string patchlist = wc.DownloadString(downloadUrl);

                lbPatches.Items.Clear();

                foreach (var item in patchlist.Split('|'))
                    if (!string.IsNullOrWhiteSpace(item))
                        lbPatches.Items.Add(item);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to list available patches\n\n{ex}");
            }

        }

        private void btnBrowseGameDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result != DialogResult.OK)
                return;

            string folder = fbd.SelectedPath;
            string x64Folder = Path.Combine(folder, "x64");

            var rootFiles = Directory.GetFiles(folder);
            var x64Files = Directory.GetFiles(x64Folder);

            string MS2 = x64Files.FirstOrDefault(it => it.ToUpper().Contains("MAPLESTORY2.EXE"));
            string NGM = rootFiles.FirstOrDefault(it => it.ToUpper().Contains("NGM.EXE"));
            string NGM64 = rootFiles.FirstOrDefault(it => it.ToUpper().Contains("NGM64.EXE"));

            bool maplestoryLocated = !(string.IsNullOrWhiteSpace(MS2));
            bool launcherLocated = !string.IsNullOrWhiteSpace(NGM) || !string.IsNullOrWhiteSpace(NGM64);

            if (!maplestoryLocated || !launcherLocated)
            {
                MessageBox.Show("Could not find Maplestory2 and/or the Nexon game launcher.");
                folder = "";
                tbGameDirectory.Text = folder;
                LauncherSettings.DeleteValue(LauncherSettings.GAME_FOLDER);
                LockPatchInterface();
                return;
            }

            tbGameDirectory.Text = folder;
            LauncherSettings.SetValue(LauncherSettings.GAME_FOLDER, folder);
            UnlockPatchInterface();

        }

        private void btnInstallPatch_Click(object sender, EventArgs e)
        {
            if (lbPatches.SelectedIndex == -1)
            {
                return;
            }


            string patchname = lbPatches.SelectedItem.ToString();
            string patchPackUrl = $"{LauncherSettings.GetValue(LauncherSettings.PATCH_SERVER_ROOT)}/{patchname}/pack.zip";
            string tempFilename = Path.Combine(LauncherSettings.TempDir, "pack.zip");
            string ms2Folder = tbGameDirectory.Text;

            DownloadForm.DownloadFile(patchPackUrl, tempFilename, ms2Folder);
        }

        private void cbExitLag_CheckedChanged(object sender, EventArgs e)
        {
            if (CurrentlyLoading)
                return;

            if(cbExitLag.Checked)
            {
                LauncherSettings.SetValue(LauncherSettings.EXITLAG, "true");
                Program.SwitchToExitlagIfNeeded();

            }
            else
            {
                LauncherSettings.SetValue(LauncherSettings.EXITLAG, "false");
            }
        }
    }
}
