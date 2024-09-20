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
    public partial class ListBox1 : Form
    {
        public ListBox1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstCities.Items.Clear();
            MessageBox.Show("All cities cleared.");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCitiName.Text != "")
            {
                lstCities.Items.Add(txtCitiName.Text);
                txtCitiName.Clear();
            }
            else
            {
                MessageBox.Show("Enter new CitiName");
                txtCitiName.Focus();    
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int count=lstCities.Items.Count;
            MessageBox.Show("There are " + count + "Cities");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCities.SelectedIndex >= 0)
            {
                lstCities.Items.Remove(lstCities.SelectedIndex);
            }
            else
                MessageBox.Show("Select any city.");
        }
    }
}
