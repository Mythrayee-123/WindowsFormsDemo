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
    public partial class GroupBox : Form
    {
        public GroupBox()
        {
            InitializeComponent();
        }

        private void rbWhite_CheckedChanged(object sender, EventArgs e)
        {
            txtMytextBox.Clear();
            txtMytextBox.BackColor = Color.White;
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            txtMytextBox.Clear();
            txtMytextBox.BackColor = Color.Red;
        }

        private void rbYellow_CheckedChanged(object sender, EventArgs e)
        {
            txtMytextBox.Clear();
            txtMytextBox.BackColor = Color.Yellow;
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            txtMytextBox.Clear();
            txtMytextBox.BackColor = Color.Blue;
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            txtMytextBox.Clear();
            txtMytextBox.BackColor = Color.Green;
            txtMytextBox.Text = "Green";

        }

        private void rbOrange_CheckedChanged(object sender, EventArgs e)
        {
            txtMytextBox.Clear();
            txtMytextBox.BackColor = Color.Orange;
            txtMytextBox.Text = "orange";

        }
    }
}
