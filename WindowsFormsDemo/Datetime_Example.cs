using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsDemo
{
    public partial class Datetime_Example : Form
    {
        public Datetime_Example()
        {
            InitializeComponent();
        }

        private void Datetime_Example_Load(object sender, EventArgs e)
        {
            dtpickerDOB.Value = DateTime.Now.AddYears(-20);
        }

        private void dtpickerDOB_ValueChanged(object sender, EventArgs e)
        {
            DateTime DOB = dtpickerDOB.Value;
            DateTime NOW = DateTime.Now;

            if (NOW > DOB)
            {
                TimeSpan ts = NOW - DOB;
                int age = ts.Days / 365;
                txtage.Text = age + "years";
            }
            else
            {
                txtage.Text = "Invalid date of birth";
            }
        }
    }
}
