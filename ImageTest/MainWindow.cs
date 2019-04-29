using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ImageTest
{
    public partial class MainWindow : Form
    {
        public static string ConnectionString = "Server=tcp:tonur.database.windows.net;Initial Catalog=EAL;Persist Security Info=False;User ID=SpecOpticAps;Password=Ole12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            rtbFileName.Text = openFileDialog1.FileName;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string cmdString = $"INSERT INTO ImageTest (Img) VALUES ;";
            using (SqlConnection sqlConn = new SqlConnection(ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand(cmdString, sqlConn);
                sqlCmd.ExecuteNonQuery();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var myControl = new TopBar();
            myControl.ParentForm = this;
            TopBarPanel.Controls.Add(myControl);
            myControl.Dock = DockStyle.Top;
        }
    }
}
