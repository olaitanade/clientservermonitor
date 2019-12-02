using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientServerMonitor
{
    public class CustomContext:ApplicationContext
    {
        private readonly List<Form1> _openForms = new List<Form1>();

        public CustomContext()
        {
            CreateForm();
        }

        private void CreateForm()
        {
            Form1 form = new Form1();
            //form.OpenNewForm += (sender, args) => CreateForm();
            form.Closed += (sender, args) => FormClosed(sender as Form1);
            _openForms.Add(form);
            form.Show();
        }



        private void FormClosed(Form1 form)
        {
            _openForms.Remove(form);
            if (_openForms.Count == 0)
            {
                ExitThread();
            }
        }

    }
}
