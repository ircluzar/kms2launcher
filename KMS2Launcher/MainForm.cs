namespace KMS2Launcher
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;

    internal partial class MainForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        internal static MainForm mf = null;
        internal static DownloadForm dform = null;

        internal static TabName SelectedTab = TabName.WELCOME;

        internal static WelcomeForm wform = null;
        internal static InstallForm iform = null;
        internal static PatchForm pform = null;
        internal static LaunchForm lform = null;


        Color UnselectedButtonColor = Color.FromArgb(32, 32, 32);
        Color SelectedButtonColor = Color.FromArgb(64, 64, 64);

        public MainForm()
        {
            InitializeComponent();

            mf = this;
            FormSync.SyncObject = mf;
            RewireMouseMove();

            ReloadPrevTabFromSettings();
        }

        public void ReloadPrevTabFromSettings()
        {
            //Restores the last opened tab
            string lastTab = LauncherSettings.GetValue(LauncherSettings.LAUNCHER_TAB);

            TabName tab = TabName.WELCOME;
            if (lastTab != null)
            {
                try
                {
                    tab = (TabName)Enum.Parse(typeof(TabName), lastTab);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            SelectTab(tab);
        }

        internal void HideTopButtons()
        {
            btnWelcome.Visible = false;
            btnInstall.Visible = false;
            btnPatch.Visible = false;
            btnLaunch.Visible = false;
        }

        internal void ShowTopButtons()
        {
            btnWelcome.Visible = true;
            btnInstall.Visible = true;
            btnPatch.Visible = true;
            btnLaunch.Visible = true;
        }

        public void SaveSelectedTabToSettings(TabName t)
        {
            //save last tab
            var tab = t.ToString();
            LauncherSettings.SetValue(LauncherSettings.LAUNCHER_TAB, tab);

        }

        public void SelectTab(TabName tab)
        {
            //performs aestethic changes and anchors form into panel

            btnWelcome.BackColor = UnselectedButtonColor;
            btnInstall.BackColor = UnselectedButtonColor;
            btnPatch.BackColor = UnselectedButtonColor;
            btnLaunch.BackColor = UnselectedButtonColor;

            Form f = null;

            switch (tab)
            {
                case TabName.WELCOME: 
                    {
                        SelectedTab = TabName.WELCOME;
                        btnWelcome.BackColor = SelectedButtonColor;

                        if(wform == null)
                            wform = new WelcomeForm();

                        f = wform;

                        break; 
                    }
                case TabName.INSTALL: 
                    {
                        SelectedTab = TabName.INSTALL;
                        btnInstall.BackColor = SelectedButtonColor;

                        if (iform == null)
                            iform = new InstallForm();

                        f = iform;

                        break; 
                    }
                case TabName.PATCH: 
                    {
                        SelectedTab = TabName.PATCH;
                        btnPatch.BackColor = SelectedButtonColor;

                        if (pform == null)
                            pform = new PatchForm();

                        f = pform;

                        break; 
                    }
                case TabName.LAUNCH: 
                    {
                        SelectedTab = TabName.LAUNCH;
                        btnLaunch.BackColor = SelectedButtonColor;

                        if (lform == null)
                            lform = new LaunchForm();

                        f = lform;

                        break; 
                    }
            }

            SendFormToPanel(f);
            SaveSelectedTabToSettings(tab);
        }

        private void SendFormToPanel(Form f)
        {
            pnContainer.Controls.Clear();
            f.TopLevel = false;
            pnContainer.Controls.Add(f);
            f.Show();
        }

        private void RewireMouseMove()
        {
            foreach (Control control in Controls)
            {
                control.MouseMove -= RedirectMouseMove;
                control.MouseMove += RedirectMouseMove;
            }

            MouseMove -= MainForm_MouseMove;
            MouseMove += MainForm_MouseMove;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnQuit_MouseEnter(object sender, EventArgs e)
        {
            btnQuit.BackColor = Color.FromArgb(230, 46, 76);
        }

        private void btnQuit_MouseLeave(object sender, EventArgs e)
        {
            btnQuit.BackColor = Color.FromArgb(64, 64, 64);
        }


        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Installer, Patcher and Launcher for Korean Maple Story 2. Source code available at https://github.com/ircluzar/kms2launcher ");
        }


        private void RedirectMouseMove(object sender, MouseEventArgs e)
        {
            var control = (Control)sender;
            Point screenPoint = control.PointToScreen(new Point(e.X, e.Y));
            Point formPoint = PointToClient(screenPoint);
            var args = new MouseEventArgs(e.Button, e.Clicks,
                formPoint.X, formPoint.Y, e.Delta);
            OnMouseMove(args);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Default;
            Point cursor = PointToClient(Cursor.Position);

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void btnWelcome_Click(object sender, EventArgs e) => SelectTab(TabName.WELCOME);

        private void btnInstall_Click(object sender, EventArgs e) => SelectTab(TabName.INSTALL);

        private void btnPatch_Click(object sender, EventArgs e) => SelectTab(TabName.PATCH);

        private void btnLaunch_Click(object sender, EventArgs e) => SelectTab(TabName.LAUNCH);


    }
}
