using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServerMonitor
{
    //This is the client sending request for connection and send the images
    public partial class sharescreen : MetroForm
    {
        private MonitorM monitormodel = MonitorM.Instance;
        
        public sharescreen()
        {
            InitializeComponent();
        }

        //Connect to the server
        private void connectbtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(port_txb.Text, out monitormodel.portNumber))
            {
                try
                {
                    //Object to do the connection
                    monitormodel.client.Connect(ip_txb.Text, monitormodel.portNumber);
                    connectbtn.Text = "Connected";
                    connectbtn.Enabled = false;
                    sharebtn.Enabled = true;
                    MessageBox.Show("Connected");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "(Failed to connect....Check the ip address and port no)");
                }
            }
            else
            {
                MessageBox.Show("Check the port no, it contains invalid character");
            }
            
        }

        //Share the images by opening the sharescreen2 which handles the part of the screen images to send to the server
        private void sharebtn_Click(object sender, EventArgs e)
        {
            if (sharebtn.Text.StartsWith("Share"))
            {
                //The timer sends the images to the server
                timer1.Start();
                sharebtn.Text = "Share";
                sharescreen2 sc = new sharescreen2();
                sc.Tag = this;
                sc.Show(this);
                Hide();
            }
            else
            {
                timer1.Stop();
                sharebtn.Text = "Share Screen";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (monitormodel.client.Connected)
            {
                try
                {
                    monitormodel.SendDesktopImage();
                }
                catch (Exception)
                {
                    timer1.Stop();
                    //monitormodel.client.GetStream().Close();
                    monitormodel.client.Close();
                    //monitormodel.client = null;
                    sharebtn.Text = "Share Screen";
                    //MessageBox.Show("");
                }
            }
            else
            {
                connectbtn.Enabled = true;
                sharebtn.Text = "Share Screen";
                sharebtn.Enabled = false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            timer1.Stop();
            monitormodel.client.Close();
            var homePage = (Form1)Tag;
            homePage.Close();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        //Handles this window's notifyicon mousedouble click
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        //Handles the back button click event
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Tag;
            form1.Show();
            Hide();
        }
    }
}
