﻿namespace KMS2Launcher
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbRememberPassword = new System.Windows.Forms.TextBox();
            this.btnSendCredentials = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRememberUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.WebBrowser.Visible = false;
            this.WebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser_DocumentCompleted);
            this.WebBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebBrowser_Navigated);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginPageToolStripMenuItem,
            this.ModeToolStripComboBox});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(784, 27);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // LoginPageToolStripMenuItem
            // 
            this.LoginPageToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.LoginPageToolStripMenuItem.Name = "LoginPageToolStripMenuItem";
            this.LoginPageToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.LoginPageToolStripMenuItem.Text = "Refresh";
            this.LoginPageToolStripMenuItem.Click += new System.EventHandler(this.LoginPageToolStripMenuItem_Click);
            // 
            // ModeToolStripComboBox
            // 
            this.ModeToolStripComboBox.BackColor = System.Drawing.Color.Black;
            this.ModeToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeToolStripComboBox.ForeColor = System.Drawing.Color.White;
            this.ModeToolStripComboBox.Name = "ModeToolStripComboBox";
            this.ModeToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(560, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password :";
            // 
            // tbRememberPassword
            // 
            this.tbRememberPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRememberPassword.BackColor = System.Drawing.Color.Black;
            this.tbRememberPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRememberPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbRememberPassword.ForeColor = System.Drawing.Color.White;
            this.tbRememberPassword.Location = new System.Drawing.Point(625, 4);
            this.tbRememberPassword.Name = "tbRememberPassword";
            this.tbRememberPassword.PasswordChar = '*';
            this.tbRememberPassword.Size = new System.Drawing.Size(114, 19);
            this.tbRememberPassword.TabIndex = 3;
            this.tbRememberPassword.TabStop = false;
            this.tbRememberPassword.TextChanged += new System.EventHandler(this.lbRememberPassword_TextChanged);
            // 
            // btnSendCredentials
            // 
            this.btnSendCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCredentials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSendCredentials.FlatAppearance.BorderSize = 0;
            this.btnSendCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCredentials.ForeColor = System.Drawing.Color.White;
            this.btnSendCredentials.Location = new System.Drawing.Point(743, 3);
            this.btnSendCredentials.Name = "btnSendCredentials";
            this.btnSendCredentials.Size = new System.Drawing.Size(37, 20);
            this.btnSendCredentials.TabIndex = 4;
            this.btnSendCredentials.TabStop = false;
            this.btnSendCredentials.Text = ">>";
            this.btnSendCredentials.UseVisualStyleBackColor = false;
            this.btnSendCredentials.Click += new System.EventHandler(this.btnSendPassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loading Nexon Login Page...";
            // 
            // tbRememberUser
            // 
            this.tbRememberUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRememberUser.BackColor = System.Drawing.Color.Black;
            this.tbRememberUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRememberUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbRememberUser.ForeColor = System.Drawing.Color.White;
            this.tbRememberUser.Location = new System.Drawing.Point(438, 4);
            this.tbRememberUser.Name = "tbRememberUser";
            this.tbRememberUser.Size = new System.Drawing.Size(116, 19);
            this.tbRememberUser.TabIndex = 6;
            this.tbRememberUser.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(397, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "User :";
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRememberUser);
            this.Controls.Add(this.btnSendCredentials);
            this.Controls.Add(this.tbRememberPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WebBrowser);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRememberPassword;
        private System.Windows.Forms.Button btnSendCredentials;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRememberUser;
        private System.Windows.Forms.Label label3;
    }
}

