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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //logic for ADD 

            int a = int.Parse(textBox1.Text);   // string to int
            int b = int.Parse(textBox2.Text);
            int c = a + b;
            textBox3.Text= c.ToString();  // converting int to string

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);   // string to int
            int b = int.Parse(textBox2.Text);
            int c = a - b;
            textBox3.Text = c.ToString();  // converting int to string
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);   // string to int
            int b = int.Parse(textBox2.Text);
            int c = a * b;
            textBox3.Text = c.ToString();  // converting int to string
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);   // string to int
            int b = int.Parse(textBox2.Text);
            int c = a / b;
            textBox3.Text = c.ToString();  // converting int to string
        }

      
    }
}
