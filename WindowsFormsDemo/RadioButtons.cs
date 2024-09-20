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
    public partial class RadioButtons : Form
    {
        public RadioButtons()
        {
            InitializeComponent();
        }

        private void rbBeige_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
        }

        private void rbLightgreen_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor= Color.LightGreen;   
        }

        private void rbLightyellow_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor=Color.LightYellow;    
        }

        private void rbBisque_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Bisque;  
        }
    }
}
