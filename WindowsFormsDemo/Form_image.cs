using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class Form_image : Form
    {
        public Form_image()
        {
            InitializeComponent();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\mythr\Downloads\bloom-blossom-flora-63638.jpg");

            this.BackgroundImageLayout = ImageLayout.Zoom;   
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
              this.BackgroundImage = null;    
        }
    }
}
