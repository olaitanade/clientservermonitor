namespace ClientServerMonitor
{
    partial class monitorscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(monitorscreen));
            this.label1 = new System.Windows.Forms.Label();
            this.port_tb = new MetroFramework.Controls.MetroTextBox();
            this.listen_btn = new MetroFramework.Controls.MetroButton();
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
            this.label1.Location = new System.Drawing.Point(131, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // port_tb
            // 
            this.port_tb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.port_tb.CustomButton.Image = null;
            this.port_tb.CustomButton.Location = new System.Drawing.Point(82, 2);
            this.port_tb.CustomButton.Name = "";
            this.port_tb.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.port_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.port_tb.CustomButton.TabIndex = 1;
            this.port_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.port_tb.CustomButton.UseSelectable = true;
            this.port_tb.CustomButton.Visible = false;
            this.port_tb.Lines = new string[0];
            this.port_tb.Location = new System.Drawing.Point(173, 75);
            this.port_tb.MaxLength = 32767;
            this.port_tb.Name = "port_tb";
            this.port_tb.PasswordChar = '\0';
            this.port_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.port_tb.SelectedText = "";
            this.port_tb.SelectionLength = 0;
            this.port_tb.SelectionStart = 0;
            this.port_tb.ShortcutsEnabled = true;
            this.port_tb.Size = new System.Drawing.Size(100, 20);
            this.port_tb.TabIndex = 1;
            this.port_tb.UseSelectable = true;
            this.port_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.port_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listen_btn
            // 
            this.listen_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listen_btn.Location = new System.Drawing.Point(134, 113);
            this.listen_btn.Name = "listen_btn";
            this.listen_btn.Size = new System.Drawing.Size(139, 23);
            this.listen_btn.TabIndex = 2;
            this.listen_btn.Text = "Listen";
            this.listen_btn.UseSelectable = true;
            this.listen_btn.Click += new System.EventHandler(this.listen_btn_Click);
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
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.listen_btn);
            this.metroTabPage1.Controls.Add(this.port_tb);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(412, 268);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Start Server";
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
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(328, 133);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = resources.GetString("metroLabel2.Text");
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(182, 368);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Copyright 2017";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Monitor Screen";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton1.Location = new System.Drawing.Point(184, 234);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(53, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Back";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // monitorscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 390);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "monitorscreen";
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

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox port_tb;
        private MetroFramework.Controls.MetroButton listen_btn;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}