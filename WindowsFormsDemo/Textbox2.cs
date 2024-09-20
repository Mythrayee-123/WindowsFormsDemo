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
    public partial class Textbox2 : Form
    {
        public Textbox2()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtFrom.Text);
            int n2 = int.Parse(txtTo.Text);
            txtNumbers.Clear();
            for (int i = n1; i <= n2; i++)
            {
                txtNumbers.Text += i + ",";
            }
            txtFrom.Focus();
        }
    }
}
