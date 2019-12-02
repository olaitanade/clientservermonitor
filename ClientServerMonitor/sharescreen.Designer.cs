namespace ClientServerMonitor
{
    partial class sharescreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sharescreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ip_txb = new MetroFramework.Controls.MetroTextBox();
            this.port_txb = new MetroFramework.Controls.MetroTextBox();
            this.connectbtn = new MetroFramework.Controls.MetroButton();
            this.sharebtn = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT";
            // 
            // ip_txb
            // 
            this.ip_txb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.ip_txb.CustomButton.Image = null;
            this.ip_txb.CustomButton.Location = new System.Drawing.Point(82, 2);
            this.ip_txb.CustomButton.Name = "";
            this.ip_txb.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.ip_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ip_txb.CustomButton.TabIndex = 1;
            this.ip_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ip_txb.CustomButton.UseSelectable = true;
            this.ip_txb.CustomButton.Visible = false;
            this.ip_txb.Lines = new string[0];
            this.ip_txb.Location = new System.Drawing.Point(169, 50);
            this.ip_txb.MaxLength = 32767;
            this.ip_txb.Name = "ip_txb";
            this.ip_txb.PasswordChar = '\0';
            this.ip_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ip_txb.SelectedText = "";
            this.ip_txb.SelectionLength = 0;
            this.ip_txb.SelectionStart = 0;
            this.ip_txb.ShortcutsEnabled = true;
            this.ip_txb.Size = new System.Drawing.Size(100, 20);
            this.ip_txb.TabIndex = 2;
            this.ip_txb.UseSelectable = true;
            this.ip_txb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ip_txb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // port_txb
            // 
            this.port_txb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.port_txb.CustomButton.Image = null;
            this.port_txb.CustomButton.Location = new System.Drawing.Point(82, 2);
            this.port_txb.CustomButton.Name = "";
            this.port_txb.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.port_txb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.port_txb.CustomButton.TabIndex = 1;
            this.port_txb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.port_txb.CustomButton.UseSelectable = true;
            this.port_txb.CustomButton.Visible = false;
            this.port_txb.Lines = new string[0];
            this.port_txb.Location = new System.Drawing.Point(169, 90);
            this.port_txb.MaxLength = 32767;
            this.port_txb.Name = "port_txb";
            this.port_txb.PasswordChar = '\0';
            this.port_txb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.port_txb.SelectedText = "";
            this.port_txb.SelectionLength = 0;
            this.port_txb.SelectionStart = 0;
            this.port_txb.ShortcutsEnabled = true;
            this.port_txb.Size = new System.Drawing.Size(100, 20);
            this.port_txb.TabIndex = 3;
            this.port_txb.UseSelectable = true;
            this.port_txb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.port_txb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // connectbtn
            // 
            this.connectbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.connectbtn.Location = new System.Drawing.Point(102, 132);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(75, 38);
            this.connectbtn.TabIndex = 4;
            this.connectbtn.Text = "Connect";
            this.connectbtn.UseSelectable = true;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // sharebtn
            // 
            this.sharebtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sharebtn.Location = new System.Drawing.Point(210, 132);
            this.sharebtn.Name = "sharebtn";
            this.sharebtn.Size = new System.Drawing.Size(75, 38);
            this.sharebtn.TabIndex = 5;
            this.sharebtn.Text = "Share Screen";
            this.sharebtn.UseSelectable = true;
            this.sharebtn.Click += new System.EventHandler(this.sharebtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(420, 310);
            this.metroTabControl1.TabIndex = 6;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.sharebtn);
            this.metroTabPage1.Controls.Add(this.connectbtn);
            this.metroTabPage1.Controls.Add(this.port_txb);
            this.metroTabPage1.Controls.Add(this.ip_txb);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(412, 268);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Connect";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(412, 268);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Help";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(365, 209);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = resources.GetString("metroLabel2.Text");
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(173, 369);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Copyright 2017";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Share Screen";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.Location = new System.Drawing.Point(169, 242);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(55, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Back";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // sharescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 390);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "sharescreen";
            this.ShowInTaskbar = false;
            this.Text = "Share Screen";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox ip_txb;
        private MetroFramework.Controls.MetroTextBox port_txb;
        private MetroFramework.Controls.MetroButton connectbtn;
        private MetroFramework.Controls.MetroButton sharebtn;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroFramework.Controls.MetroButton metroButton1;

    }
}