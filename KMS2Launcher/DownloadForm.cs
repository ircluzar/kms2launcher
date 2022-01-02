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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS2Launcher
{
    public partial class DownloadForm : Form
    {
        WebClient webClient;

        public DownloadForm(string downloadURL, string downloadedFile, string extractDirectory)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;

            webClient = new WebClient();

            webClient.DownloadProgressChanged += (ov, ev) =>
            {

                FormSync.FormExecute(() => {

                    MainForm.dform.progressBar.Value = ev.ProgressPercentage;
                    if (ev.BytesReceived == ev.TotalBytesToReceive)
                        lbDownloadProgress.Text = "Extracting files...";
                    else
                        lbDownloadProgress.Text = $"{String.Format("{0:0.##}", (Convert.ToDouble(ev.BytesReceived) / (1024d * 1024d)))}/{String.Format("{0:0.##}", (Convert.ToDouble(ev.TotalBytesToReceive) / (1024d * 1024d)))}MB";

                });



            };

            webClient.DownloadFileCompleted += (ov, ev) =>
            {

                FormSync.FormExecute(() => {

                    lbDownloadProgress.Text = $"Uncompressing files...";
                    DownloadComplete(downloadedFile, extractDirectory);
                });

            };

            if (File.Exists(downloadedFile))
                File.Delete(downloadedFile);

            webClient.DownloadFileAsync(new Uri(downloadURL), downloadedFile);

        }


        public static void DownloadFile(string downloadURL, string downloadedFile, string extractDirectory)
        {
            MainForm.mf.HideTopButtons();


            MainForm.dform = new DownloadForm(downloadURL, downloadedFile, extractDirectory);


            MainForm.dform.TopLevel = false;
            MainForm.dform.Location = new Point(0, 0);
            MainForm.dform.Dock = DockStyle.Fill;
            MainForm.mf.Controls.Add(MainForm.dform);
            MainForm.dform.Show();
            MainForm.dform.Focus();
            MainForm.dform.BringToFront();
        }

        private void DownloadForm_Load(object sender, EventArgs e)
        {
            Point loc = new Point((this.Width- pnDownloadBar.Width)/2, (this.Height - pnDownloadBar.Height) / 2);
            pnDownloadBar.Location = loc;
            pnDownloadBar.Visible = true;
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

                        string patchname = MainForm.pform.lbPatches.SelectedItem.ToString();

                        string patchDateUrl = $"{LauncherSettings.GetValue(LauncherSettings.PATCH_SERVER_ROOT)}/{patchname}/patchdate.php";

                        string serverPatchDate = null;

                        try
                        {
                            WebClient wc = new WebClient();
                            serverPatchDate = wc.DownloadString(patchDateUrl);

                        }
                        catch { return; } //eat it

                        LauncherSettings.SetValue(patchname, serverPatchDate);

                        MainForm.pform.lbPatches_SelectedIndexChanged(null, null);
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


                MainForm.dform.Close();
                MainForm.dform = null;

                MainForm.mf.ShowTopButtons();
            }
        }

    }
}
