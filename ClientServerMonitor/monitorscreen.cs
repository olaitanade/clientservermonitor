using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServerMonitor
{
    //This is the server waiting to receive connection request
    public partial class monitorscreen : MetroForm
    {
        int portno = 0;
        public monitorscreen()
        {
            InitializeComponent();
        }

        //Handles the listen btn click event
        private void listen_btn_Click(object sender, EventArgs e)
        {
            //new monitorscreen_picturebox(int.Parse(port_tb.Text)).Show();

            //Try parse the port no or send an error message
            if (int.TryParse(port_tb.Text, out portno))
            {
                //The monitorscreen object handles the port no and turns the server on
                monitorscreen_picturebox mp = new monitorscreen_picturebox(portno,true);
                mp.Tag = this;
                mp.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("Make the port no a four digit integer (xxxx)");
            }
        }

        //Handles the window closing
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            var homePage = (Form1)Tag;
            homePage.Close();
        }

        //Handles form resize
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
