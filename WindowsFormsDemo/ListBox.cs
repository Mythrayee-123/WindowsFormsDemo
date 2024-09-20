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
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void lstCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedCourse.Text= lstCourse.SelectedItem.ToString();
            lblCourseIndex.Text = lstCourse.SelectedIndex.ToString();
        }

        private void lblSelectedCourse_Click(object sender, EventArgs e)
        {

        }
    }
}
