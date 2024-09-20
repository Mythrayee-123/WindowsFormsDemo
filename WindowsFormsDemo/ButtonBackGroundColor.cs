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
    public partial class ButtonBackGroundColor : Form
    {
        public ButtonBackGroundColor()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;   
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Green;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.Blue;   
        }
    }
}
