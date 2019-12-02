namespace ClientServerMonitor
{
    partial class monitorscreen_picturebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(monitorscreen_picturebox));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ip_port_lbl = new MetroFramework.Controls.MetroLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ClientServerMonitor.Properties.Resources.lowpolyT;
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ip_port_lbl
            // 
            this.ip_port_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ip_port_lbl.AutoSize = true;
            this.ip_port_lbl.Location = new System.Drawing.Point(226, 29);
            this.ip_port_lbl.Name = "ip_port_lbl";
            this.ip_port_lbl.Size = new System.Drawing.Size(162, 19);
            this.ip_port_lbl.TabIndex = 1;
            this.ip_port_lbl.Text = "Ip Address: ---- Port: ----";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Monitor Screen Running";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMonitorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 26);
            // 
            // newMonitorToolStripMenuItem
            // 
            this.newMonitorToolStripMenuItem.Name = "newMonitorToolStripMenuItem";
            this.newMonitorToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.newMonitorToolStripMenuItem.Text = "New Monitor";
            this.newMonitorToolStripMenuItem.Click += new System.EventHandler(this.newMonitorToolStripMenuItem_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.White;
            this.metroButton1.Enabled = false;
            this.metroButton1.ForeColor = System.Drawing.Color.DarkRed;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(461, 29);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(91, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Restart Monitor";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // monitorscreen_picturebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 433);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.ip_port_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "monitorscreen_picturebox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Monitor Screen";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel ip_port_lbl;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newMonitorToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}