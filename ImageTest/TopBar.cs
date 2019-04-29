using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTest
{
    public partial class TopBar : UserControl
    {
        public Form ParentForm;
        public TopBar()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            switch (ParentForm.WindowState)
            {
                case FormWindowState.Normal:
                    ParentForm.WindowState = FormWindowState.Maximized;
                    break;
                case FormWindowState.Maximized:
                    ParentForm.WindowState = FormWindowState.Normal;
                    break;
                default:
                    break;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Minimized;
        }
    }
}
