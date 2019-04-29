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
using System.IO;

namespace ImageTest
{
    public partial class MainWindow : Form
    {
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
            byte[] photo = GetPhotoFromFile(rtbFileName.Text);
            DataAccess.UploadPhoto(Path.GetFileName(rtbFileName.Text), photo);
        }

        private byte[] GetPhotoFromFile(string fileName)
        {
            return File.ReadAllBytes(fileName);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var myControl = new TopBar
            {
                ParentForm = this
            };
            TopBarPanel.Controls.Add(myControl);
            myControl.Dock = DockStyle.Top;
        }

        

        private void ShowPictureButton_Click(object sender, EventArgs e)
        {
            byte[] photo = DataAccess.GetPhoto(int.Parse(GetIDRichTextBox.Text));

            pictureBox1.Image = ConvertBinaryArrayToImage(photo);
        }

        private Image ConvertBinaryArrayToImage(byte[] photo)
        {
            using (MemoryStream ms = new MemoryStream(photo))
            {
                return Image.FromStream(ms);
            }
        }

        //private byte[] GetPhoto(string filePath)
        //{
        //    byte[] photo;

        //    FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        //    BinaryReader br = new BinaryReader(fs);

        //    photo = br.ReadBytes((int)fs.Length);

        //    br.Close();
        //    fs.Close();

        //    return photo;
        //}
    }
}
