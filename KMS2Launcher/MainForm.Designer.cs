namespace KMS2Launcher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTranslation = new System.Windows.Forms.Button();
            this.btnDiscord = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuide = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenGuide2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDownloadInstall = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbFontsize = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSetKRFont = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGetKRFont = new System.Windows.Forms.Button();
            this.cbVoiceLanguage = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbPatchStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPatchDescription = new System.Windows.Forms.Label();
            this.btnInstallPatch = new System.Windows.Forms.Button();
            this.btnRefreshAvailablePatches = new System.Windows.Forms.Button();
            this.lbPatches = new System.Windows.Forms.ListBox();
            this.btnBrowseGameDirectory = new System.Windows.Forms.Button();
            this.tbGameDirectory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGithub = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 461);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(876, 435);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Launch";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BackgroundImage = global::KMS2Launcher.Properties.Resources.back_whiter;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.btnGithub);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.btnTranslation);
            this.tabPage1.Controls.Add(this.btnDiscord);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnGuide);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Welcome";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::KMS2Launcher.Properties.Resources.kms2launcher_icon_fatter_outline_256x256;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(546, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(325, 218);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnTranslation
            // 
            this.btnTranslation.BackColor = System.Drawing.SystemColors.Control;
            this.btnTranslation.FlatAppearance.BorderSize = 0;
            this.btnTranslation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslation.Location = new System.Drawing.Point(13, 298);
            this.btnTranslation.Name = "btnTranslation";
            this.btnTranslation.Size = new System.Drawing.Size(275, 40);
            this.btnTranslation.TabIndex = 5;
            this.btnTranslation.Text = "MapleStory 2 Translation project";
            this.btnTranslation.UseVisualStyleBackColor = false;
            this.btnTranslation.Click += new System.EventHandler(this.btnTranslation_Click);
            // 
            // btnDiscord
            // 
            this.btnDiscord.BackColor = System.Drawing.SystemColors.Control;
            this.btnDiscord.FlatAppearance.BorderSize = 0;
            this.btnDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscord.Location = new System.Drawing.Point(13, 252);
            this.btnDiscord.Name = "btnDiscord";
            this.btnDiscord.Size = new System.Drawing.Size(275, 40);
            this.btnDiscord.TabIndex = 4;
            this.btnDiscord.Text = "Korean MapleStory 2 Discord";
            this.btnDiscord.UseVisualStyleBackColor = false;
            this.btnDiscord.Click += new System.EventHandler(this.btnDiscord_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(755, 113);
            this.label4.TabIndex = 3;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome to KMS2 Launcher";
            // 
            // btnGuide
            // 
            this.btnGuide.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuide.FlatAppearance.BorderSize = 0;
            this.btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuide.Location = new System.Drawing.Point(13, 206);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(275, 40);
            this.btnGuide.TabIndex = 0;
            this.btnGuide.Text = "Online Guide";
            this.btnGuide.UseVisualStyleBackColor = false;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.BackgroundImage = global::KMS2Launcher.Properties.Resources.back_whiter;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnOpenGuide2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnDownloadInstall);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game Install";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KMS2Launcher.Properties.Resources.installer;
            this.pictureBox1.Location = new System.Drawing.Point(380, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpenGuide2
            // 
            this.btnOpenGuide2.FlatAppearance.BorderSize = 0;
            this.btnOpenGuide2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenGuide2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOpenGuide2.Location = new System.Drawing.Point(13, 252);
            this.btnOpenGuide2.Name = "btnOpenGuide2";
            this.btnOpenGuide2.Size = new System.Drawing.Size(275, 40);
            this.btnOpenGuide2.TabIndex = 3;
            this.btnOpenGuide2.Text = "Online Guide";
            this.btnOpenGuide2.UseVisualStyleBackColor = true;
            this.btnOpenGuide2.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 120);
            this.label2.TabIndex = 2;
            this.label2.Text = "Click the button below to download and execute the game installer. If this doesn\'" +
    "t work, follow the guide steps for installing the game.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Installing Maple Story 2";
            // 
            // btnDownloadInstall
            // 
            this.btnDownloadInstall.FlatAppearance.BorderSize = 0;
            this.btnDownloadInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadInstall.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDownloadInstall.Location = new System.Drawing.Point(13, 206);
            this.btnDownloadInstall.Name = "btnDownloadInstall";
            this.btnDownloadInstall.Size = new System.Drawing.Size(275, 40);
            this.btnDownloadInstall.TabIndex = 0;
            this.btnDownloadInstall.Text = "Download and Start Installer";
            this.btnDownloadInstall.UseVisualStyleBackColor = true;
            this.btnDownloadInstall.Click += new System.EventHandler(this.btnDownloadInstall_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::KMS2Launcher.Properties.Resources.back_whiter;
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.btnInstallPatch);
            this.tabPage3.Controls.Add(this.btnRefreshAvailablePatches);
            this.tabPage3.Controls.Add(this.lbPatches);
            this.tabPage3.Controls.Add(this.btnBrowseGameDirectory);
            this.tabPage3.Controls.Add(this.tbGameDirectory);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(876, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Patches and tweaks";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(828, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Warning: Installed patches can get overwritten by official game patches. You may " +
    "need to redownload patches when a new update rolls out.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbFontsize);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnSetKRFont);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnGetKRFont);
            this.groupBox3.Controls.Add(this.cbVoiceLanguage);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(380, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 276);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game tweaks";
            // 
            // cbFontsize
            // 
            this.cbFontsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFontsize.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbFontsize.FormattingEnabled = true;
            this.cbFontsize.Items.AddRange(new object[] {
            "100%",
            "95%",
            "90%",
            "85%"});
            this.cbFontsize.Location = new System.Drawing.Point(107, 240);
            this.cbFontsize.Name = "cbFontsize";
            this.cbFontsize.Size = new System.Drawing.Size(111, 25);
            this.cbFontsize.TabIndex = 21;
            this.cbFontsize.SelectedIndexChanged += new System.EventHandler(this.cbFontsize_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(42, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Font size:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.Location = new System.Drawing.Point(39, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Step 3: Change font size";
            // 
            // btnSetKRFont
            // 
            this.btnSetKRFont.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSetKRFont.Location = new System.Drawing.Point(36, 177);
            this.btnSetKRFont.Name = "btnSetKRFont";
            this.btnSetKRFont.Size = new System.Drawing.Size(349, 33);
            this.btnSetKRFont.TabIndex = 18;
            this.btnSetKRFont.Text = "Set \"Noto Sans KR\" font in fontconfig.txt file";
            this.btnSetKRFont.UseVisualStyleBackColor = true;
            this.btnSetKRFont.Click += new System.EventHandler(this.btnSetKRFont_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Step 2: Change the game font and font size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Step 1: Download and install this font family";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "♦ Installing a cleaner font for the game";
            // 
            // btnGetKRFont
            // 
            this.btnGetKRFont.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnGetKRFont.Location = new System.Drawing.Point(36, 113);
            this.btnGetKRFont.Name = "btnGetKRFont";
            this.btnGetKRFont.Size = new System.Drawing.Size(349, 40);
            this.btnGetKRFont.TabIndex = 14;
            this.btnGetKRFont.Text = "Get \"Noto Sans KR\" font from Google Fonts";
            this.btnGetKRFont.UseVisualStyleBackColor = true;
            this.btnGetKRFont.Click += new System.EventHandler(this.btnGetKRFont_Click);
            // 
            // cbVoiceLanguage
            // 
            this.cbVoiceLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoiceLanguage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbVoiceLanguage.FormattingEnabled = true;
            this.cbVoiceLanguage.Items.AddRange(new object[] {
            "KOREAN",
            "JAPANESE",
            "ENGLISH",
            "CHINESE"});
            this.cbVoiceLanguage.Location = new System.Drawing.Point(349, 28);
            this.cbVoiceLanguage.Name = "cbVoiceLanguage";
            this.cbVoiceLanguage.Size = new System.Drawing.Size(121, 25);
            this.cbVoiceLanguage.TabIndex = 13;
            this.cbVoiceLanguage.SelectedIndexChanged += new System.EventHandler(this.cbVoiceLanguage_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(332, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "♦ Change voice language (Required for patch):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPatchStatus);
            this.groupBox2.Location = new System.Drawing.Point(215, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 131);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patch Status";
            // 
            // lbPatchStatus
            // 
            this.lbPatchStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPatchStatus.Location = new System.Drawing.Point(11, 21);
            this.lbPatchStatus.Name = "lbPatchStatus";
            this.lbPatchStatus.Size = new System.Drawing.Size(134, 99);
            this.lbPatchStatus.TabIndex = 9;
            this.lbPatchStatus.Text = "[Patch status]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPatchDescription);
            this.groupBox1.Location = new System.Drawing.Point(214, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 138);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Patch";
            // 
            // lbPatchDescription
            // 
            this.lbPatchDescription.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPatchDescription.Location = new System.Drawing.Point(11, 23);
            this.lbPatchDescription.Name = "lbPatchDescription";
            this.lbPatchDescription.Size = new System.Drawing.Size(131, 101);
            this.lbPatchDescription.TabIndex = 9;
            this.lbPatchDescription.Text = "[Patch description]";
            // 
            // btnInstallPatch
            // 
            this.btnInstallPatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInstallPatch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnInstallPatch.Location = new System.Drawing.Point(14, 393);
            this.btnInstallPatch.Name = "btnInstallPatch";
            this.btnInstallPatch.Size = new System.Drawing.Size(195, 31);
            this.btnInstallPatch.TabIndex = 7;
            this.btnInstallPatch.Text = "Download and install patch";
            this.btnInstallPatch.UseVisualStyleBackColor = true;
            this.btnInstallPatch.Click += new System.EventHandler(this.btnInstallPatch_Click);
            // 
            // btnRefreshAvailablePatches
            // 
            this.btnRefreshAvailablePatches.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnRefreshAvailablePatches.Location = new System.Drawing.Point(12, 148);
            this.btnRefreshAvailablePatches.Name = "btnRefreshAvailablePatches";
            this.btnRefreshAvailablePatches.Size = new System.Drawing.Size(195, 30);
            this.btnRefreshAvailablePatches.TabIndex = 6;
            this.btnRefreshAvailablePatches.Text = "Refresh available patches";
            this.btnRefreshAvailablePatches.UseVisualStyleBackColor = true;
            this.btnRefreshAvailablePatches.Click += new System.EventHandler(this.btnRefreshAvailablePatches_Click);
            // 
            // lbPatches
            // 
            this.lbPatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPatches.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbPatches.FormattingEnabled = true;
            this.lbPatches.IntegralHeight = false;
            this.lbPatches.ItemHeight = 17;
            this.lbPatches.Location = new System.Drawing.Point(14, 177);
            this.lbPatches.Name = "lbPatches";
            this.lbPatches.Size = new System.Drawing.Size(193, 217);
            this.lbPatches.TabIndex = 5;
            this.lbPatches.SelectedIndexChanged += new System.EventHandler(this.lbPatches_SelectedIndexChanged);
            // 
            // btnBrowseGameDirectory
            // 
            this.btnBrowseGameDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseGameDirectory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBrowseGameDirectory.Location = new System.Drawing.Point(793, 80);
            this.btnBrowseGameDirectory.Name = "btnBrowseGameDirectory";
            this.btnBrowseGameDirectory.Size = new System.Drawing.Size(75, 30);
            this.btnBrowseGameDirectory.TabIndex = 4;
            this.btnBrowseGameDirectory.Text = "Browse";
            this.btnBrowseGameDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseGameDirectory.Click += new System.EventHandler(this.btnBrowseGameDirectory_Click);
            // 
            // tbGameDirectory
            // 
            this.tbGameDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGameDirectory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbGameDirectory.Location = new System.Drawing.Point(12, 81);
            this.tbGameDirectory.Name = "tbGameDirectory";
            this.tbGameDirectory.ReadOnly = true;
            this.tbGameDirectory.Size = new System.Drawing.Size(775, 25);
            this.tbGameDirectory.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(10, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 40);
            this.label6.TabIndex = 2;
            this.label6.Text = "Patches and tweaks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Game Directory:";
            // 
            // btnGithub
            // 
            this.btnGithub.BackColor = System.Drawing.SystemColors.Control;
            this.btnGithub.FlatAppearance.BorderSize = 0;
            this.btnGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGithub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGithub.Location = new System.Drawing.Point(546, 398);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(323, 29);
            this.btnGithub.TabIndex = 7;
            this.btnGithub.Text = "Credits, Source Code and Launcher Updates on GitHub";
            this.btnGithub.UseVisualStyleBackColor = false;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 409);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "2020 - Launcher Version 1.02";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainForm";
            this.Text = "kms2launcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownloadInstall;
        private System.Windows.Forms.Button btnOpenGuide2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowseGameDirectory;
        private System.Windows.Forms.TextBox tbGameDirectory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPatchDescription;
        private System.Windows.Forms.Button btnInstallPatch;
        private System.Windows.Forms.Button btnRefreshAvailablePatches;
        private System.Windows.Forms.ListBox lbPatches;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbPatchStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbVoiceLanguage;
        private System.Windows.Forms.Button btnDiscord;
        private System.Windows.Forms.Button btnTranslation;
        private System.Windows.Forms.Button btnGetKRFont;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSetKRFont;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbFontsize;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.Label label14;
    }
}