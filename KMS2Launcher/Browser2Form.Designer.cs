namespace KMS2Launcher
{
    partial class Browser2Form
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
            this.loginWebview = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.bottomLeftPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.launchTypeSelectBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginWebview)).BeginInit();
            this.bottomLeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginWebview
            // 
            this.loginWebview.CreationProperties = null;
            this.loginWebview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginWebview.Location = new System.Drawing.Point(0, 0);
            this.loginWebview.Name = "loginWebview";
            this.loginWebview.Size = new System.Drawing.Size(800, 450);
            this.loginWebview.Source = new System.Uri("https://kkiro.kr/", System.UriKind.Absolute);
            this.loginWebview.TabIndex = 1;
            this.loginWebview.ZoomFactor = 1D;
            // 
            // bottomLeftPanel
            // 
            this.bottomLeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottomLeftPanel.Controls.Add(this.label1);
            this.bottomLeftPanel.Controls.Add(this.launchTypeSelectBox);
            this.bottomLeftPanel.Location = new System.Drawing.Point(0, 400);
            this.bottomLeftPanel.Name = "bottomLeftPanel";
            this.bottomLeftPanel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.bottomLeftPanel.Size = new System.Drawing.Size(127, 50);
            this.bottomLeftPanel.TabIndex = 2;
            this.bottomLeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // launchTypeSelectBox
            // 
            this.launchTypeSelectBox.FormattingEnabled = true;
            this.launchTypeSelectBox.Location = new System.Drawing.Point(13, 20);
            this.launchTypeSelectBox.Name = "launchTypeSelectBox";
            this.launchTypeSelectBox.Size = new System.Drawing.Size(103, 20);
            this.launchTypeSelectBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Launch Type";
            // 
            // Browser2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bottomLeftPanel);
            this.Controls.Add(this.loginWebview);
            this.Name = "Browser2Form";
            this.Text = "Browser2Form";
            ((System.ComponentModel.ISupportInitialize)(this.loginWebview)).EndInit();
            this.bottomLeftPanel.ResumeLayout(false);
            this.bottomLeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 loginWebview;
        private System.Windows.Forms.FlowLayoutPanel bottomLeftPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox launchTypeSelectBox;
    }
}