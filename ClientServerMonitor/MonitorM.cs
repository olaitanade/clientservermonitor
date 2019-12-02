using System;
using System.Collections.Generic;
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
    public class MonitorM
    {
        public readonly TcpClient client = new TcpClient();
        public NetworkStream mainStream;
        public int portNumber;

        //variables to hold the screen size and location to monitor.
        static int x = 0;
        static int y = 0;
        static int bitmap_x = 0;
        static int bitmap_y = 0;

        static Size msize = new Size();
        static Rectangle bounds = Screen.PrimaryScreen.Bounds;
        static int mousePX = 0;
        static int mousePY = 0;


        private static MonitorM instance;
        private MonitorM() 
        {
            mousePX = bounds.X;
            mousePY = bounds.Y;
            msize = bounds.Size;
            bitmap_x = bounds.Width;
            bitmap_y = bounds.Height;
        }
        public static MonitorM Instance
        {
            get
            {
                if (instance == null)
                    instance = new MonitorM();
                return instance;
            }
        }

        private static Image GrabDesktop()
        {
            //Rectangle bounds = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(bitmap_x, bitmap_y, PixelFormat.Format32bppArgb);
            Graphics graphic = Graphics.FromImage(screenshot);
            graphic.CopyFromScreen(mousePX - (x / 2), mousePY - (y / 2), 0, 0, msize, CopyPixelOperation.SourceCopy);
            return screenshot;
        }
        public static void setScreen(int x_para, int y_para,int mouseX,int mouseY,Size newSize)
        {
            x = x_para;
            y = y_para;
            bitmap_x = x_para;
            bitmap_y = x_para;
            mousePX = mouseX;
            mousePY = mouseY;
            msize = newSize; 
        }
        public void SendDesktopImage()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            if (client.Connected)
            {
                mainStream = client.GetStream();
                binFormatter.Serialize(mainStream, GrabDesktop()); 
            }
        }

        public static void setDefaultScreen()
        {
            bounds = Screen.PrimaryScreen.Bounds;
            mousePX = bounds.X;
            mousePY = bounds.Y;
            msize = bounds.Size;
            bitmap_x = bounds.Width;
            bitmap_y = bounds.Height;
            x = 0;
            y = 0;
        }
    }
}
