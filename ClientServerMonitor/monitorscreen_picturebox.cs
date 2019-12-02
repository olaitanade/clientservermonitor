using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ClientServerMonitor
{
    //This is the server waiting to receive connection request and receive the images
    public partial class monitorscreen_picturebox : MetroForm
    {
        //singleton to managed the number of this form
        private FormsManager formsManager = FormsManager.Instance;

        bool notifyIconVisible = false;

        public int port;
        private TcpClient client;
        private TcpListener server;
        private NetworkStream mainStream;

        private Thread Listening;
        private Thread GetImage;

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd,
            int hWndInsertAfter, int x, int y, int cx, int cy, int uFlags);

        private const int HWND_TOPMOST = -1;
        private const int HWND_NOTOPMOST = -2;
        private const int SWP_NOMOVE = 0x0002;
        private const int SWP_NOSIZE = 0x0001;

        public monitorscreen_picturebox(int port_no,bool systemtray)
        {
            port = port_no;
            notifyIconVisible = systemtray;
            client = new TcpClient();
            Listening = new Thread(StartListening);
            GetImage = new Thread(ReceiveImage);
            FormsManager._openForms.Add(this);
            InitializeComponent();
            //notifyIcon.Visible = notifyIconVisible;
        }

        private void ReceiveImage(object obj)
        {
            //To format the image
            BinaryFormatter binFormatter = new BinaryFormatter();
            try
            {
                while (client.Connected)
                {
                    mainStream = client.GetStream();
                    pictureBox1.Image = (Image)binFormatter.Deserialize(mainStream);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Disconnected Stream");
                client.Close();
                metroButton1.BeginInvoke((Action)delegate() 
                {
                    metroButton1.Text = "Restart Monitor";
                    metroButton1.Enabled = true;
                });
                var context = Thread.CurrentThread;
                context.Abort();
                
            }
            
        }

        private void StartListening(object obj)
        {
            //Runs while not connected
            while (!client.Connected)
            {
                try
                {
                    server.Start();
                    client = server.AcceptTcpClient();
                }catch(Exception ex){
                    //FormsManager._openForms.RemoveAt(FormsManager._openForms.Count - 1);
                    var context = Thread.CurrentThread;
                    context.Abort();
                    //MessageBox.Show("The current port is unavailable/already in use by another application");
                }
                
            }//Already connected, so it would move to the next line of code
            GetImage.Start();//Runs the thread to get images
        }

        private void StopListening()
        {
            if (GetImage.IsAlive)
            {
                GetImage.Abort();
            }
            if (Listening.IsAlive)
            {
                Listening.Abort();
            }
            server.Stop();
            

            if (client.Connected)
            {
                client.GetStream().Close();
                client.Close();
                client = null;
            }
        }

        public static IPAddress GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //string myHost = System.Net.Dns.GetHostName();
            IPAddress myIpno = GetLocalIPAddress();
            IPAddress myIp = IPAddress.Any;
            ip_port_lbl.Text = "Ip: " + myIpno.ToString() + " Port: " + port;

            //Initialize the server
            server = new TcpListener(myIp, port);
            Listening.Start();
            metroButton1.Text = "Monitor Started";
            SetWindowPos(this.Handle,HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            //Check if this is the last form
            if (FormsManager._openForms.Count == 1)
            {
                var prevPage = (monitorscreen)Tag;
                prevPage.Close();
            }
            else
            {
                FormsManager._openForms.RemoveAt(FormsManager._openForms.Count-1);
            }
            StopListening();
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

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void newMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open new monitor window with its own server and port
            if (FormsManager._openForms.Count < 4)
            {
                monitorscreen_picturebox mp = new monitorscreen_picturebox(2015 + FormsManager._openForms.Count, false);
                mp.Tag = (monitorscreen)Tag;
                mp.Show();
            }
            else
            {
                MessageBox.Show("Can only open max of 4");
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            StopListening();
            Listening = new Thread(StartListening);
            GetImage = new Thread(ReceiveImage);
            Listening.Start();
            metroButton1.Text = "Monitor Started";
            metroButton1.Enabled = false;
        }
    }
}
