using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientServerMonitor
{
    public class FormsManager
    {
        public static List<monitorscreen_picturebox> _openForms = new List<monitorscreen_picturebox>();
        public static FormsManager instance;

        public static FormsManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new FormsManager();
                return instance;
            }
        }

        private FormsManager()
        {

        }
    }
}
