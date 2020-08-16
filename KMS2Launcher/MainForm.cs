using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS2Launcher
{
    public partial class MainForm : Form
    {

        public BrowserForm bForm = null;
        public static DownloadForm dForm = null;
        public static MainForm mf;

        public MainForm()
        {
            InitializeComponent();

            mf = this;

            MakeSureFolderExists(LauncherSettings.AppDir);
            MakeSureFolderExists(LauncherSettings.TempDir);
            MakeSureFolderExists(LauncherSettings.PatchDir);

            lbPatchDescription.Text = "";
            lbPatchStatus.Text = "";
        }


        public void InvokeUI(Action a)
        {
            this.BeginInvoke(new MethodInvoker(a));
        }

        public void DownloadFile(string downloadURL, string downloadedFile, string extractDirectory)
        {
            MainForm.dForm = new DownloadForm(downloadURL, downloadedFile, extractDirectory);


            MainForm.dForm.TopLevel = false;
            MainForm.dForm.Location = new Point(0, 0);
            MainForm.dForm.Dock = DockStyle.Fill;
            this.Controls.Add(MainForm.dForm);
            MainForm.dForm.Show();
            MainForm.dForm.Focus();
            MainForm.dForm.BringToFront();
        }


        public void DownloadComplete(string downloadedFile, string extractDirectory)
        {

            try
            {

                if (extractDirectory != null)
                {

                    if (!Directory.Exists(extractDirectory))
                        Directory.CreateDirectory(extractDirectory);

                    try
                    {
                        //System.IO.Compression.ZipFile.ExtractToDirectory(downloadedFile, extractDirectory);

                        using (ZipArchive archive = ZipFile.OpenRead(downloadedFile))
                        {
                            foreach (var entry in archive.Entries)
                            {
                                var entryPath = Path.Combine(extractDirectory, entry.FullName).Replace("/", "\\");

                                if (entryPath.EndsWith("\\"))
                                {
                                    if (!Directory.Exists(entryPath))
                                        Directory.CreateDirectory(entryPath);
                                }
                                else
                                {
                                    entry.ExtractToFile(entryPath, true);
                                }


                            }
                        }

                        MessageBox.Show("Patch installed successfully");

                        string patchname = lbPatches.SelectedItem.ToString();
                        string patchDateUrl = $"{LauncherSettings.GetValue(LauncherSettings.PATCH_SERVER_ROOT)}/{patchname}/patchdate.php";

                        string serverPatchDate = null;

                        try
                        {
                            WebClient wc = new WebClient();
                            serverPatchDate = wc.DownloadString(patchDateUrl);

                        }
                        catch { return; } //eat it

                        LauncherSettings.SetValue(patchname, serverPatchDate);

                        lbPatches_SelectedIndexChanged(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred during extraction\n\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }


                    if (File.Exists(downloadedFile))
                        File.Delete(downloadedFile);

                }
                else
                {
                    Process.Start(downloadedFile);
                }

            }
            finally
            {


                dForm.Close();
                dForm = null;

            }
        }


        public void MakeSureFolderExists(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Could not create directory {path}\n\n{ex}");
            }
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            string guideUrl = LauncherSettings.GetWebValue(LauncherSettings.GAME_GUIDE);

            if(string.IsNullOrEmpty(guideUrl))
            {
                MessageBox.Show("Could not fetch the guide url");
                return;
            }

            Process.Start(guideUrl);
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            //save last tab
            var tab = tabControl.SelectedTab;
            LauncherSettings.SetValue(LauncherSettings.LAUNCHER_TAB, tab.Text);

            //init the launch tab only if needed to save ressources on init loading
            if(tab.Text == "Launch" && bForm == null)
            {
                bForm = new BrowserForm();
                bForm.TopLevel = false;
                bForm.FormBorderStyle = FormBorderStyle.None;
                tab.Controls.Add(bForm);
                bForm.Dock = DockStyle.Fill;
                bForm.Show();
            }
        }

        public void KillProcess(string name)
        {
            //wmic is safer than taskkill but it's also async so...

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "wmic";
            psi.Arguments = $"process where name='{name}' delete";
            Process.Start(psi).WaitForExit();
            Thread.Sleep(420);
        }

        private void btnDownloadInstall_Click(object sender, EventArgs e)
        {
            string downloadUrl = LauncherSettings.GetWebValue(LauncherSettings.INSTALLER_URL);
            string filename = downloadUrl.Substring(downloadUrl.LastIndexOf('/') + 1);
            string tempPath = Path.Combine(LauncherSettings.TempDir, filename);

            KillProcess(filename);


            /*
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFile(downloadUrl, tempPath);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Failed to download {downloadUrl}\n\n{ex}");
            }

            try
            {
                Process.Start(tempPath);
            }
            catch { } //eat it
            */

            DownloadFile(downloadUrl, tempPath, null);

        }

        public void LockPatchInterface()
        {
            btnInstallPatch.Enabled = false;
            cbVoiceLanguage.Enabled = false;
            btnSetKRFont.Enabled = false;
        }

        public void UnlockPatchInterface()
        {
            btnInstallPatch.Enabled = true;
            cbVoiceLanguage.Enabled = true;
            btnSetKRFont.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Restores the last opened tab
            string lastTab = LauncherSettings.GetValue(LauncherSettings.LAUNCHER_TAB);
            if(lastTab != null)
            {
                var tab = tabControl.TabPages.OfType<TabPage>().FirstOrDefault(o => o.Text == lastTab);
                if (tab != null)
                    tabControl.SelectedTab = tab;
            }
                 
            string gameFolder = LauncherSettings.GetValue(LauncherSettings.GAME_FOLDER);
            if (gameFolder != null)
            {
                tbGameDirectory.Text = gameFolder;
                UnlockPatchInterface();
            }
            else
                LockPatchInterface();

            btnRefreshAvailablePatches_Click(null, null);

        }

        private void btnBrowseGameDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result != DialogResult.OK)
                return;

            string folder = fbd.SelectedPath;
            var files = Directory.GetFiles(folder);
            string foundMS2 = files.FirstOrDefault(it => it.ToUpper().Contains("MAPLESTORY2.EXE"));
            string foundNGM = files.FirstOrDefault(it => it.ToUpper().Contains("NGM.EXE"));

            if(foundMS2 == null || foundNGM == null)
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

        private void cbVoiceLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVoiceLanguage.SelectedIndex == -1)
                return;

            string gameFolder = tbGameDirectory.Text;
            string configPath = Path.Combine(gameFolder, "Config", "GameOption.xml");

            string language = cbVoiceLanguage.SelectedItem.ToString();

            int languageValue;

            switch(language)
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

        private void btnRefreshAvailablePatches_Click(object sender, EventArgs e)
        {

            string downloadUrl = $"{LauncherSettings.GetValue(LauncherSettings.PATCH_SERVER_ROOT)}/patchlist.php";

            try
            {
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

        private void lbPatches_SelectedIndexChanged(object sender, EventArgs e)
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
                catch {} //eat it

                if(serverPatchDate == null)
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

            DownloadFile(patchPackUrl, tempFilename, ms2Folder);
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            string Url = LauncherSettings.GetWebValue(LauncherSettings.DISCORD_LINK);

            if (string.IsNullOrEmpty(Url))
            {
                MessageBox.Show("Could not fetch the discord url");
                return;
            }

            Process.Start(Url);
        }

        private void btnTranslation_Click(object sender, EventArgs e)
        {
            string Url = LauncherSettings.GetWebValue(LauncherSettings.TRANSLATE_LINK);

            if (string.IsNullOrEmpty(Url))
            {
                MessageBox.Show("Could not fetch the translation url");
                return;
            }

            Process.Start(Url);
        }

        private void btnGetKRFont_Click(object sender, EventArgs e)
        {
            string Url = LauncherSettings.GetWebValue(LauncherSettings.GOOGLE_FONT);

            if (string.IsNullOrEmpty(Url))
            {
                MessageBox.Show("Could not fetch the font url");
                return;
            }

            Process.Start(Url);
        }

        private void cbFontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbFontsize.SelectedIndex == -1)
            //    return;

            string gameFolder = tbGameDirectory.Text;
            string configPath = Path.Combine(gameFolder, "Data", "Resource", "gfx", "fontconfig.txt");

            string size = cbFontsize.SelectedItem?.ToString() ?? "";

            string sizeValue;

            switch (size)
            {
                default:
                    sizeValue = "";
                    break;
                case "100%":
                    sizeValue = " 1.00";
                    break;
                case "95%":
                    sizeValue = " 0.95";
                    break;
                case "90%":
                    sizeValue = " 0.90";
                    break;
                case "85%":
                    sizeValue = " 0.85";
                    break;
            }

            var configData = File.ReadAllLines(configPath);

            for(int i = 0; i<configData.Length;i++)
            {
                string line = configData[i];

                if (line.StartsWith("map \"$Font_SD_Neo_1\""))
                    configData[i] = $"map \"$Font_SD_Neo_1\"    = \"Noto Sans KR Regular\"{sizeValue}";

                if (line.StartsWith("map \"$Font_SD_Neo_3\""))
                    configData[i] = $"map \"$Font_SD_Neo_3\"    = \"Noto Sans KR Regular\"{sizeValue}";
            }

            File.WriteAllLines(configPath, configData);

            MessageBox.Show("Config changed successfully");

        }

        private void btnSetKRFont_Click(object sender, EventArgs e)
        {
            cbFontsize_SelectedIndexChanged(null, null);
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            string githubUrl = LauncherSettings.GetWebValue(LauncherSettings.GAME_GUIDE);

            if (string.IsNullOrEmpty(githubUrl))
            {
                MessageBox.Show("Could not fetch the github url");
                return;
            }

            Process.Start(githubUrl);
        }
    }
}
