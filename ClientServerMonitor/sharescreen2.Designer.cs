namespace ClientServerMonitor
{
    partial class sharescreen2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sharescreen2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x_tb = new MetroFramework.Controls.MetroTextBox();
            this.y_tb = new MetroFramework.Controls.MetroTextBox();
            this.set_btn = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // x_tb
            // 
            // 
            // 
            // 
            this.x_tb.CustomButton.Image = null;
            this.x_tb.CustomButton.Location = new System.Drawing.Point(31, 2);
            this.x_tb.CustomButton.Name = "";
            this.x_tb.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.x_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.x_tb.CustomButton.TabIndex = 1;
            this.x_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.x_tb.CustomButton.UseSelectable = true;
            this.x_tb.CustomButton.Visible = false;
            this.x_tb.Lines = new string[0];
            this.x_tb.Location = new System.Drawing.Point(206, 33);
            this.x_tb.MaxLength = 32767;
            this.x_tb.Name = "x_tb";
            this.x_tb.PasswordChar = '\0';
            this.x_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.x_tb.SelectedText = "";
            this.x_tb.SelectionLength = 0;
            this.x_tb.SelectionStart = 0;
            this.x_tb.ShortcutsEnabled = true;
            this.x_tb.Size = new System.Drawing.Size(49, 20);
            this.x_tb.TabIndex = 3;
            this.x_tb.UseSelectable = true;
            this.x_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.x_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // y_tb
            // 
            // 
            // 
            // 
            this.y_tb.CustomButton.Image = null;
            this.y_tb.CustomButton.Location = new System.Drawing.Point(34, 2);
            this.y_tb.CustomButton.Name = "";
            this.y_tb.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.y_tb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.y_tb.CustomButton.TabIndex = 1;
            this.y_tb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.y_tb.CustomButton.UseSelectable = true;
            this.y_tb.CustomButton.Visible = false;
            this.y_tb.Lines = new string[0];
            this.y_tb.Location = new System.Drawing.Point(281, 33);
            this.y_tb.MaxLength = 32767;
            this.y_tb.Name = "y_tb";
            this.y_tb.PasswordChar = '\0';
            this.y_tb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.y_tb.SelectedText = "";
            this.y_tb.SelectionLength = 0;
            this.y_tb.SelectionStart = 0;
            this.y_tb.ShortcutsEnabled = true;
            this.y_tb.Size = new System.Drawing.Size(52, 20);
            this.y_tb.TabIndex = 4;
            this.y_tb.UseSelectable = true;
            this.y_tb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.y_tb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // set_btn
            // 
            this.set_btn.Location = new System.Drawing.Point(339, 31);
            this.set_btn.Name = "set_btn";
            this.set_btn.Size = new System.Drawing.Size(75, 23);
            this.set_btn.TabIndex = 5;
            this.set_btn.Text = "set";
            this.set_btn.UseSelectable = true;
            this.set_btn.Click += new System.EventHandler(this.click_eventhandler);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer_eventhandler);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Sharing Screen running";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ClientServerMonitor.Properties.Resources.lowpolyT;
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sharescreen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 380);
            this.Controls.Add(this.set_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x_tb);
            this.Controls.Add(this.y_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "sharescreen2";
            this.ShowInTaskbar = false;
            this.Text = "Screen Shared";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_keydown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTextBox x_tb;
        private MetroFramework.Controls.MetroTextBox y_tb;
        private MetroFramework.Controls.MetroButton set_btn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}