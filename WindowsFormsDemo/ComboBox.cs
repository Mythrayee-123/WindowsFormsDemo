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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourse.SelectedIndex == 0)
            {
                txtFee.Text = "Rs 3,500";
                txtMessage.Text=cmbCourse.Text+" " +"Costs"+" " + txtFee.Text;
            }
            else if (cmbCourse.SelectedIndex == 1)
            {
                txtFee.Text = "Rs 6,200";
                txtMessage.Text = cmbCourse.Text + " " + "Costs" + " " + txtFee.Text;
            }
            else if (cmbCourse.SelectedIndex == 2)
            {
                txtFee.Text = "Rs 1,200";
            }

            else if (cmbCourse.SelectedIndex == 3)
            {
                txtFee.Text = "Rs 1,500";
            }
            else if (cmbCourse.SelectedIndex == 4)
            {
                txtFee.Text = "Rs 1000";
            }
            }
    }
}
