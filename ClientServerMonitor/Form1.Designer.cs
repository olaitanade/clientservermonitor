namespace ClientServerMonitor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sharescreen_btn = new MetroFramework.Controls.MetroButton();
            this.monitor_btn = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sharescreen_btn
            // 
            this.sharescreen_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sharescreen_btn.Location = new System.Drawing.Point(138, 71);
            this.sharescreen_btn.Name = "sharescreen_btn";
            this.sharescreen_btn.Size = new System.Drawing.Size(126, 35);
            this.sharescreen_btn.TabIndex = 0;
            this.sharescreen_btn.Text = "Share Screen";
            this.sharescreen_btn.UseSelectable = true;
            this.sharescreen_btn.Click += new System.EventHandler(this.sharescreen_btn_Click);
            // 
            // monitor_btn
            // 
            this.monitor_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monitor_btn.Location = new System.Drawing.Point(138, 141);
            this.monitor_btn.Name = "monitor_btn";
            this.monitor_btn.Size = new System.Drawing.Size(126, 40);
            this.monitor_btn.TabIndex = 1;
            this.monitor_btn.Text = "Monitor Screen";
            this.monitor_btn.UseSelectable = true;
            this.monitor_btn.Click += new System.EventHandler(this.monitor_btn_Click);
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
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.monitor_btn);
            this.metroTabPage1.Controls.Add(this.sharescreen_btn);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(412, 268);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Home";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(138, 26);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "What do you want ?";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroTile1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(412, 268);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "About";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 11);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(382, 171);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = resources.GetString("metroLabel3.Text");
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTile1.Location = new System.Drawing.Point(149, 225);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(110, 37);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Owner:  Kazi J.";
            this.metroTile1.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(162, 369);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(144, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Copyright 2017 (Tellula)";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Monitor/Share Screen";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 390);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Monitor Screen";
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

        private MetroFramework.Controls.MetroButton sharescreen_btn;
        private MetroFramework.Controls.MetroButton monitor_btn;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}