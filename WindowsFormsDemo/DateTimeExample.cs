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
    public partial class DateTimeExample : Form
    {
        public DateTimeExample()
        {
            InitializeComponent();
        }

        private void DateTime_Load(object sender, EventArgs e)
        {
            DateTime.Now.AddYears(-20);
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            

        }
    }
}
