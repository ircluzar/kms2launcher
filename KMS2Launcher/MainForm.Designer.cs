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
            this.pnBottomPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnAnchorRight = new System.Windows.Forms.Panel();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.pnTopPanel = new System.Windows.Forms.Panel();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnPatch = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnWelcome = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnBottomPanel.SuspendLayout();
            this.pnAnchorRight.SuspendLayout();
            this.pnTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBottomPanel
            // 
            this.pnBottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pnBottomPanel.Controls.Add(this.label5);
            this.pnBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottomPanel.Location = new System.Drawing.Point(0, 401);
            this.pnBottomPanel.Name = "pnBottomPanel";
            this.pnBottomPanel.Size = new System.Drawing.Size(640, 19);
            this.pnBottomPanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(249, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 18);
            this.label5.TabIndex = 132;
            this.label5.Text = "2022 - KMS2 Launcher Version 1.10";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pnAnchorRight
            // 
            this.pnAnchorRight.AutoSize = true;
            this.pnAnchorRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnAnchorRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnAnchorRight.Controls.Add(this.pnContainer);
            this.pnAnchorRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAnchorRight.Location = new System.Drawing.Point(0, 41);
            this.pnAnchorRight.Name = "pnAnchorRight";
            this.pnAnchorRight.Size = new System.Drawing.Size(640, 360);
            this.pnAnchorRight.TabIndex = 133;
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pnContainer.Location = new System.Drawing.Point(7, 6);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(625, 348);
            this.pnContainer.TabIndex = 0;
            // 
            // pnTopPanel
            // 
            this.pnTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pnTopPanel.BackgroundImage = global::KMS2Launcher.Properties.Resources.newkms2banner2;
            this.pnTopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnTopPanel.Controls.Add(this.btnLaunch);
            this.pnTopPanel.Controls.Add(this.btnPatch);
            this.pnTopPanel.Controls.Add(this.btnInstall);
            this.pnTopPanel.Controls.Add(this.btnWelcome);
            this.pnTopPanel.Controls.Add(this.btnMinimize);
            this.pnTopPanel.Controls.Add(this.btnQuit);
            this.pnTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopPanel.Location = new System.Drawing.Point(0, 0);
            this.pnTopPanel.Name = "pnTopPanel";
            this.pnTopPanel.Size = new System.Drawing.Size(640, 41);
            this.pnTopPanel.TabIndex = 131;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLaunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLaunch.FlatAppearance.BorderSize = 0;
            this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunch.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnLaunch.ForeColor = System.Drawing.Color.White;
            this.btnLaunch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLaunch.Location = new System.Drawing.Point(454, 8);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(63, 24);
            this.btnLaunch.TabIndex = 137;
            this.btnLaunch.TabStop = false;
            this.btnLaunch.Tag = "";
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnPatch
            // 
            this.btnPatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPatch.FlatAppearance.BorderSize = 0;
            this.btnPatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatch.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnPatch.ForeColor = System.Drawing.Color.White;
            this.btnPatch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatch.Location = new System.Drawing.Point(328, 8);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(120, 24);
            this.btnPatch.TabIndex = 136;
            this.btnPatch.TabStop = false;
            this.btnPatch.Tag = "";
            this.btnPatch.Text = "Patches and tweaks";
            this.btnPatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatch.UseVisualStyleBackColor = false;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInstall.FlatAppearance.BorderSize = 0;
            this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstall.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnInstall.ForeColor = System.Drawing.Color.White;
            this.btnInstall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInstall.Location = new System.Drawing.Point(234, 8);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(88, 24);
            this.btnInstall.TabIndex = 135;
            this.btnInstall.TabStop = false;
            this.btnInstall.Tag = "";
            this.btnInstall.Text = "Game Install";
            this.btnInstall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnWelcome
            // 
            this.btnWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWelcome.FlatAppearance.BorderSize = 0;
            this.btnWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnWelcome.ForeColor = System.Drawing.Color.White;
            this.btnWelcome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWelcome.Location = new System.Drawing.Point(154, 8);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(74, 24);
            this.btnWelcome.TabIndex = 134;
            this.btnWelcome.TabStop = false;
            this.btnWelcome.Tag = "";
            this.btnWelcome.Text = "Welcome";
            this.btnWelcome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWelcome.UseVisualStyleBackColor = false;
            this.btnWelcome.Click += new System.EventHandler(this.btnWelcome_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(582, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 24);
            this.btnMinimize.TabIndex = 131;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Tag = "";
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(610, 8);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(22, 24);
            this.btnQuit.TabIndex = 130;
            this.btnQuit.TabStop = false;
            this.btnQuit.Tag = "";
            this.btnQuit.Text = "X";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            this.btnQuit.MouseEnter += new System.EventHandler(this.btnQuit_MouseEnter);
            this.btnQuit.MouseLeave += new System.EventHandler(this.btnQuit_MouseLeave);
            // 
            // NewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.Controls.Add(this.pnAnchorRight);
            this.Controls.Add(this.pnBottomPanel);
            this.Controls.Add(this.pnTopPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 420);
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "NewMainForm";
            this.Tag = "";
            this.Text = "kms2launcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnBottomPanel.ResumeLayout(false);
            this.pnAnchorRight.ResumeLayout(false);
            this.pnTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBottomPanel;
        private System.Windows.Forms.Panel pnTopPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnAnchorRight;
        private System.Windows.Forms.Panel pnContainer;
        public System.Windows.Forms.Button btnLaunch;
        public System.Windows.Forms.Button btnPatch;
        public System.Windows.Forms.Button btnInstall;
        public System.Windows.Forms.Button btnWelcome;
    }
}

