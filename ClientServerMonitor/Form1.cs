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
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Handles the sharescreen button to open the sharescreen window
        private void sharescreen_btn_Click(object sender, EventArgs e)
        {
            //new sharescreen().Show();

            //open up the sharescreen window and close this
            sharescreen shareS = new sharescreen();
            shareS.Tag = this;
            shareS.Show(this);
            Hide();
        }

        //Handles the monitorscreen button to open the monitorscreen window
        private void monitor_btn_Click(object sender, EventArgs e)
        {
            //new monitorscreen().Show();

            //open up the monitorscreen window and close this
            monitorscreen monitorS = new monitorscreen();
            monitorS.Tag = this;
            monitorS.Show();
            Hide();
        }

        //Checks the form resize if it is being minimized
        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                //Hide(); it would hide the window from the collection of windows running on the desktop
                notifyIcon.Visible = true;
            }
        }

        //Handles mouse double click on the notify icon
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            //notifyIcon.Visible = false;
        }
    }
}
