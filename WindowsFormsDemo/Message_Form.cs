﻿using System;
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
    public partial class Message_Form : Form
    {
        public Message_Form()
        {
            InitializeComponent();
        }

      

        private void btnOk_Click(object sender, EventArgs e)
        {
            string name=txtName.Text;
            string message="welcome to" + name;
            lblMessage.Text = message;
            lblMessage.Visible = true; 
        }
    }
}
