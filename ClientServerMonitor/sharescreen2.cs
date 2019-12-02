using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientServerMonitor
{
    public partial class sharescreen2 : MetroForm
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int MYACTION_HOTKEYIN_ID = 1;
        const int MYACTION_HOTKEYOUT_ID = 2;

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd,
            int hWndInsertAfter, int x, int y, int cx, int cy, int uFlags);

        private const int HWND_TOPMOST = -1;
        private const int HWND_NOTOPMOST = -2;
        private const int SWP_NOMOVE = 0x0002;
        private const int SWP_NOSIZE = 0x0001;

        public sharescreen2()
        {
            InitializeComponent();
            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            
            RegisterHotKey(this.Handle, MYACTION_HOTKEYIN_ID, 2, (int)Keys.F1);
            RegisterHotKey(this.Handle, MYACTION_HOTKEYOUT_ID, 2, (int)Keys.F2);
            
        }

        Graphics g;//Graphics object that draws the image captured around the cursor

        Bitmap bmp;//Bitmap object that handles the pixels around the cursor

        int zoomFactor = 1;
        int zoompercentage = 0;

        bool tellhim = true;

        readonly object stateLock = new object();

        int x = 300;//initial size of the square around the cursor
        int y = 300;

        int newx = 300;
        int newy = 300;

        int screendiffwidth = 0;
        int screendiffheight = 0;
        int screendiffwidRatio = 0;
        int screendiffheightRatio = 0;

        //This method runs every 100miliseconds to create the images on the view box
        private void timer_eventhandler(object sender, EventArgs e)
        {
            if (MonitorM.Instance.client.Connected)
            {
                if (zoomFactor == 1 || zoomFactor > 1)
                {
                    this.DoubleBuffered = true;
                    bmp = new Bitmap(newx, newy);//Setting the bitmap size to hold or contain pixels round the cursor


                    g = this.CreateGraphics();//initializing the graphics object

                    g = Graphics.FromImage(bmp);//creates graphics from the bitmap image

                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    //Copies the pixels around the cursor
                    g.CopyFromScreen(MousePosition.X - (newx / 2), MousePosition.Y - (newy / 2), 0, 0, new Size(x, y));




                    if (zoomFactor == 1)
                    {
                        pictureBox1.Image = bmp;
                    }
                    else
                    {
                        pictureBox1.Image = new Bitmap(bmp, bmp.Width * zoomFactor, bmp.Height * zoomFactor);
                    }

                }
                else if (zoomFactor < 1)
                {

                    this.DoubleBuffered = true;

                    bmp = new Bitmap(newx, newy);
                    //bmp = new Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);

                    g = this.CreateGraphics();//initializing the graphics object

                    g = Graphics.FromImage(bmp);//creates graphics from the bitmap image

                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    //Copies the pixels around the cursor

                    g.CopyFromScreen(MousePosition.X - (newx / 2), MousePosition.Y - (newy / 2), 0, 0, new Size(newx, newy));
                    //g.CopyFromScreen(0, 0, 0, 0, new Size(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height));


                    pictureBox1.Image = new Bitmap(bmp, x, y);
                }
            }
            else
            {
                
                timer1.Stop();
                MessageBox.Show("Disconnected/Closed  from the Monitor pc");
                //var prevPage = (sharescreen)Tag;
                //prevPage.Show();
                //Close();
            }

           

            //view the captured pixels in the view box on the window

        }

        

        //This method handles the changing of the rectangle size around the cursor
        private void click_eventhandler(object sender, EventArgs e)
        {
            string xvalue = x_tb.Text;
            string yvalue = y_tb.Text;

            if (!int.TryParse(xvalue, out x) || !int.TryParse(yvalue, out y))
            {
                MessageBox.Show("Expects an integer or double");

            }
            else
            {
                //pictureBox1.Size = new Size(x, y);
                //this.Size = new Size(x + 90, y + 150);
                newx = x;
                newy = y;
            }

        }

       

        private void Form1_keydown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F1)
            {
                if (MonitorM.Instance.client.Connected)
                {
                    //save the current screen capture as selected
                    MonitorM.setScreen(x, y, MousePosition.X, MousePosition.Y, new Size(x, y));
                }
                else
                {
                    MessageBox.Show("Disconnected....Server has been stoped/closed by the other pc.");
                }
            }
            else if (e.Control && e.KeyCode == Keys.F2)
            {
                if (MonitorM.Instance.client.Connected)
                {
                    MonitorM.setDefaultScreen();
                    
                }
                else
                {
                    MessageBox.Show("Disconnected....Server has been stoped/closed by the other pc.");
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEYIN_ID)
            {
                if (MonitorM.Instance.client.Connected)
                {
                    //save the current screen capture as selected
                    MonitorM.setScreen(x, y, MousePosition.X, MousePosition.Y, new Size(x, y)); 
                }
                else
                {
                    MessageBox.Show("Disconnected...Server has been stoped/closed by the other pc.");
                }
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEYOUT_ID)
            {
                if (MonitorM.Instance.client.Connected)
                {
                    MonitorM.setDefaultScreen();
                    
                }
                else
                {
                    MessageBox.Show("Disconnected.....Server has been stoped/closed by the other pc.");
                }
            }
            base.WndProc(ref m);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            var prevPage = (sharescreen)Tag;
            prevPage.Close();
        }

        //form minimize action
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

        //notify icon in the system tray
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
    }
}
