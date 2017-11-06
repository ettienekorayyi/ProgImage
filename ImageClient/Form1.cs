using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgImage;
using ProgImage.Controllers;

namespace ImageClient
{
    public partial class Form1 : Form
    {
        public static ImageController imageController { get; set; }
        public static OpenFileDialog file { get; set; }
        public Form1()
        {
            imageController = new ImageController();
            file = new OpenFileDialog();
            InitializeComponent();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            file.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";//"JPG(*.JPG)|*.jpg";


            file.InitialDirectory = ProgImage.Common.Constants.ImagePath;
            if (file.ShowDialog() == DialogResult.OK)
            {
                BrowseTxt.Text = file.FileName;
                picBox.Image = Image.FromFile(file.FileName);
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            textBox2.Text = imageController.Get().ToString();
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            imageController.Post(file.FileName);
        }

        private void LeftRotation_Click(object sender, EventArgs e)
        {
            picBox.Image = imageController.Post(file.FileName, "left");
        }

        private void RightRotation_Click(object sender, EventArgs e)
        {
            picBox.Image = imageController.Post(file.FileName, "right"); 
        }

        private void ConverttoPNG_Click(object sender, EventArgs e)
        {
            if(imageController.Post(file.FileName, "png", true) == true)
                MessageBox.Show("Conversion of image successful", "Convert JPG to PNG");
            else
                MessageBox.Show("Conversion of image failed", "Convert Image to PNG");
        }

        private void ConverttoJPG_Click(object sender, EventArgs e)
        {
            if (imageController.Post(file.FileName, "jpg", true) == true)
                MessageBox.Show("Conversion of image successful", "Convert Image to JPG");
            else
                MessageBox.Show("Conversion of image failed", "Convert JPG to PNG");
        }
    }
}
