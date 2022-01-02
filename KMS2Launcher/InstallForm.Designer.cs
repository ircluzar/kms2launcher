namespace KMS2Launcher
{
    partial class InstallForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenGuide2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDownloadInstall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KMS2Launcher.Properties.Resources.install;
            this.pictureBox1.Location = new System.Drawing.Point(277, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpenGuide2
            // 
            this.btnOpenGuide2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnOpenGuide2.FlatAppearance.BorderSize = 0;
            this.btnOpenGuide2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenGuide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnOpenGuide2.ForeColor = System.Drawing.Color.White;
            this.btnOpenGuide2.Location = new System.Drawing.Point(19, 290);
            this.btnOpenGuide2.Name = "btnOpenGuide2";
            this.btnOpenGuide2.Size = new System.Drawing.Size(202, 37);
            this.btnOpenGuide2.TabIndex = 8;
            this.btnOpenGuide2.TabStop = false;
            this.btnOpenGuide2.Text = "Online Guide";
            this.btnOpenGuide2.UseVisualStyleBackColor = false;
            this.btnOpenGuide2.Click += new System.EventHandler(this.btnOpenGuide2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 120);
            this.label2.TabIndex = 7;
            this.label2.Text = "Click the button below to download and execute the game installer. If this doesn\'" +
    "t work, follow the guide steps for installing the game.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Installing Maple Story 2";
            // 
            // btnDownloadInstall
            // 
            this.btnDownloadInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnDownloadInstall.FlatAppearance.BorderSize = 0;
            this.btnDownloadInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDownloadInstall.ForeColor = System.Drawing.Color.White;
            this.btnDownloadInstall.Location = new System.Drawing.Point(19, 237);
            this.btnDownloadInstall.Name = "btnDownloadInstall";
            this.btnDownloadInstall.Size = new System.Drawing.Size(202, 37);
            this.btnDownloadInstall.TabIndex = 5;
            this.btnDownloadInstall.TabStop = false;
            this.btnDownloadInstall.Text = "Download and Start Installer";
            this.btnDownloadInstall.UseVisualStyleBackColor = false;
            this.btnDownloadInstall.Click += new System.EventHandler(this.btnDownloadInstall_Click);
            // 
            // InstallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.BackgroundImage = global::KMS2Launcher.Properties.Resources.newkms2background2;
            this.ClientSize = new System.Drawing.Size(625, 348);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpenGuide2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDownloadInstall);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstallForm";
            this.Text = "InstallForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpenGuide2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownloadInstall;
    }
}