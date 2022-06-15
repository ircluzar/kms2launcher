namespace KMS2Launcher
{
    partial class PatchForm
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
            this.tbGameDirectory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrowseGameDirectory = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRefreshAvailablePatches = new System.Windows.Forms.Button();
            this.lbPatches = new System.Windows.Forms.ListBox();
            this.btnInstallPatch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbPatchStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPatchDescription = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbExitLag = new System.Windows.Forms.CheckBox();
            this.cbVoiceLanguage = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGameDirectory
            // 
            this.tbGameDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGameDirectory.BackColor = System.Drawing.Color.Black;
            this.tbGameDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGameDirectory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbGameDirectory.ForeColor = System.Drawing.Color.White;
            this.tbGameDirectory.Location = new System.Drawing.Point(112, 76);
            this.tbGameDirectory.Name = "tbGameDirectory";
            this.tbGameDirectory.ReadOnly = true;
            this.tbGameDirectory.Size = new System.Drawing.Size(416, 18);
            this.tbGameDirectory.TabIndex = 6;
            this.tbGameDirectory.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Patches and tweaks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Game Directory:";
            // 
            // btnBrowseGameDirectory
            // 
            this.btnBrowseGameDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseGameDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBrowseGameDirectory.FlatAppearance.BorderSize = 0;
            this.btnBrowseGameDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseGameDirectory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBrowseGameDirectory.ForeColor = System.Drawing.Color.White;
            this.btnBrowseGameDirectory.Location = new System.Drawing.Point(534, 69);
            this.btnBrowseGameDirectory.Name = "btnBrowseGameDirectory";
            this.btnBrowseGameDirectory.Size = new System.Drawing.Size(75, 30);
            this.btnBrowseGameDirectory.TabIndex = 7;
            this.btnBrowseGameDirectory.TabStop = false;
            this.btnBrowseGameDirectory.Text = "Browse";
            this.btnBrowseGameDirectory.UseVisualStyleBackColor = false;
            this.btnBrowseGameDirectory.Click += new System.EventHandler(this.btnBrowseGameDirectory_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(573, 38);
            this.label11.TabIndex = 17;
            this.label11.Text = "Warning: Installed patches can get overwritten by official game patches. You may " +
    "need to redownload patches when a new update rolls out.";
            // 
            // btnRefreshAvailablePatches
            // 
            this.btnRefreshAvailablePatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRefreshAvailablePatches.FlatAppearance.BorderSize = 0;
            this.btnRefreshAvailablePatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshAvailablePatches.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnRefreshAvailablePatches.ForeColor = System.Drawing.Color.White;
            this.btnRefreshAvailablePatches.Location = new System.Drawing.Point(14, 160);
            this.btnRefreshAvailablePatches.Name = "btnRefreshAvailablePatches";
            this.btnRefreshAvailablePatches.Size = new System.Drawing.Size(148, 30);
            this.btnRefreshAvailablePatches.TabIndex = 19;
            this.btnRefreshAvailablePatches.TabStop = false;
            this.btnRefreshAvailablePatches.Text = "Refresh available patches";
            this.btnRefreshAvailablePatches.UseVisualStyleBackColor = false;
            this.btnRefreshAvailablePatches.Click += new System.EventHandler(this.btnRefreshAvailablePatches_Click);
            // 
            // lbPatches
            // 
            this.lbPatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPatches.BackColor = System.Drawing.Color.Black;
            this.lbPatches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPatches.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbPatches.ForeColor = System.Drawing.Color.White;
            this.lbPatches.FormattingEnabled = true;
            this.lbPatches.IntegralHeight = false;
            this.lbPatches.Location = new System.Drawing.Point(16, 189);
            this.lbPatches.Name = "lbPatches";
            this.lbPatches.Size = new System.Drawing.Size(146, 113);
            this.lbPatches.TabIndex = 18;
            this.lbPatches.SelectedIndexChanged += new System.EventHandler(this.lbPatches_SelectedIndexChanged);
            // 
            // btnInstallPatch
            // 
            this.btnInstallPatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInstallPatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnInstallPatch.FlatAppearance.BorderSize = 0;
            this.btnInstallPatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallPatch.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnInstallPatch.ForeColor = System.Drawing.Color.White;
            this.btnInstallPatch.Location = new System.Drawing.Point(15, 301);
            this.btnInstallPatch.Name = "btnInstallPatch";
            this.btnInstallPatch.Size = new System.Drawing.Size(148, 31);
            this.btnInstallPatch.TabIndex = 20;
            this.btnInstallPatch.TabStop = false;
            this.btnInstallPatch.Text = "Download and install patch";
            this.btnInstallPatch.UseVisualStyleBackColor = false;
            this.btnInstallPatch.Click += new System.EventHandler(this.btnInstallPatch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbPatchStatus);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(312, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 172);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patch Status";
            // 
            // lbPatchStatus
            // 
            this.lbPatchStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPatchStatus.Location = new System.Drawing.Point(9, 20);
            this.lbPatchStatus.Name = "lbPatchStatus";
            this.lbPatchStatus.Size = new System.Drawing.Size(124, 142);
            this.lbPatchStatus.TabIndex = 9;
            this.lbPatchStatus.Text = "[Patch status]";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbPatchDescription);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(166, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 172);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Patch";
            // 
            // lbPatchDescription
            // 
            this.lbPatchDescription.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPatchDescription.Location = new System.Drawing.Point(9, 20);
            this.lbPatchDescription.Name = "lbPatchDescription";
            this.lbPatchDescription.Size = new System.Drawing.Size(124, 142);
            this.lbPatchDescription.TabIndex = 9;
            this.lbPatchDescription.Text = "[Patch description]";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cbExitLag);
            this.groupBox3.Controls.Add(this.cbVoiceLanguage);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(458, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 172);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game tweaks";
            // 
            // cbExitLag
            // 
            this.cbExitLag.AutoSize = true;
            this.cbExitLag.Location = new System.Drawing.Point(10, 88);
            this.cbExitLag.Name = "cbExitLag";
            this.cbExitLag.Size = new System.Drawing.Size(137, 17);
            this.cbExitLag.TabIndex = 14;
            this.cbExitLag.Text = "Exitlag vpn workaround";
            this.cbExitLag.UseVisualStyleBackColor = true;
            this.cbExitLag.CheckedChanged += new System.EventHandler(this.cbExitLag_CheckedChanged);
            // 
            // cbVoiceLanguage
            // 
            this.cbVoiceLanguage.BackColor = System.Drawing.Color.Black;
            this.cbVoiceLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoiceLanguage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbVoiceLanguage.ForeColor = System.Drawing.Color.White;
            this.cbVoiceLanguage.FormattingEnabled = true;
            this.cbVoiceLanguage.Items.AddRange(new object[] {
            "KOREAN",
            "JAPANESE",
            "ENGLISH",
            "CHINESE"});
            this.cbVoiceLanguage.Location = new System.Drawing.Point(10, 56);
            this.cbVoiceLanguage.Name = "cbVoiceLanguage";
            this.cbVoiceLanguage.Size = new System.Drawing.Size(134, 25);
            this.cbVoiceLanguage.TabIndex = 13;
            this.cbVoiceLanguage.SelectedIndexChanged += new System.EventHandler(this.cbVoiceLanguage_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 33);
            this.label9.TabIndex = 12;
            this.label9.Text = "♦ Change voice language (Required for patch):";
            // 
            // PatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(625, 348);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInstallPatch);
            this.Controls.Add(this.btnRefreshAvailablePatches);
            this.Controls.Add(this.lbPatches);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnBrowseGameDirectory);
            this.Controls.Add(this.tbGameDirectory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatchForm";
            this.Text = "PatchForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGameDirectory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrowseGameDirectory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRefreshAvailablePatches;
        public System.Windows.Forms.ListBox lbPatches;
        private System.Windows.Forms.Button btnInstallPatch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbPatchStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPatchDescription;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbVoiceLanguage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbExitLag;
    }
}