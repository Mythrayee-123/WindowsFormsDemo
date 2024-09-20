using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class PictureBox : Form
    {
        public PictureBox()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string imagepath= txtImagePath.Text;
            FileInfo image = new FileInfo(imagepath);
            if (image.Exists)
            {
             pictureBox1.Image= Image.FromFile(imagepath);
            }
            else
            {
                MessageBox.Show("Image file not found.");
            }

        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode=PictureBoxSizeMode.Normal;   
        }

        private void rbstretch_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void rbCenter_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void rbZoom_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;   
        }
    }
}
