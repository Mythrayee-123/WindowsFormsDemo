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
    public partial class Domain_Example : Form
    {
        public Domain_Example()
        {
            InitializeComponent();
        }
        private void changefont()
        {
            string font = Convert.ToString(donFont.SelectedItem);
            int size = Convert.ToInt32(numSize.Value);
            txtMyText.Font = new Font(font, size);
        }

        private void donFont_SelectedItemChanged(object sender, EventArgs e)
        {
            changefont();
        }

        private void numSize_ValueChanged(object sender, EventArgs e)
        {
            changefont();

            #region GetAllEmployess
              //Logic
            #endregion


            #region GetEmployeeBYID
            //logic
            #endregion


            #region UpdateEmployee
            //logic
            #endregion
        }
    }
}

