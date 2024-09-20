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
    public partial class WindowsEvents : Form
    {
        public WindowsEvents()
        {
            InitializeComponent();
        }

        private void lblText_MouseHover(object sender, EventArgs e)
        {
            lblText.ForeColor = Color.Red;
        }

        private void lblText_MouseLeave(object sender, EventArgs e)
        {
            lblText.ForeColor= Color.Yellow;
        }

        private void WindowsEvents_Load(object sender, EventArgs e)
        {
            //logic
        }
    }
}
