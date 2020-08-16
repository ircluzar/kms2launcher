namespace KMS2Launcher
{
    partial class BrowserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.LoginPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ArchitectureToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebBrowser
            // 
            this.WebBrowser.AllowWebBrowserDrop = false;
            this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.WebBrowser.Location = new System.Drawing.Point(0, 27);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.ScriptErrorsSuppressed = true;
            this.WebBrowser.Size = new System.Drawing.Size(784, 534);
            this.WebBrowser.TabIndex = 0;
            this.WebBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.WebBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebBrowser_Navigated);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginPageToolStripMenuItem,
            this.ModeToolStripComboBox,
            this.ArchitectureToolStripComboBox});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(784, 27);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // LoginPageToolStripMenuItem
            // 
            this.LoginPageToolStripMenuItem.Name = "LoginPageToolStripMenuItem";
            this.LoginPageToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.LoginPageToolStripMenuItem.Text = "Refresh";
            this.LoginPageToolStripMenuItem.Click += new System.EventHandler(this.LoginPageToolStripMenuItem_Click);
            // 
            // ModeToolStripComboBox
            // 
            this.ModeToolStripComboBox.Name = "ModeToolStripComboBox";
            this.ModeToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // ArchitectureToolStripComboBox
            // 
            this.ArchitectureToolStripComboBox.Name = "ArchitectureToolStripComboBox";
            this.ArchitectureToolStripComboBox.Size = new System.Drawing.Size(80, 23);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.WebBrowser);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "BrowserForm";
            this.Text = "Nexon Login";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem LoginPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ModeToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox ArchitectureToolStripComboBox;
    }
}

