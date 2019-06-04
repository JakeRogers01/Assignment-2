using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // calculate the total resistance
            try
            {
                double resistance1, resistance2, resistanceTotal;
                resistance1 = Convert.ToDouble(textBox1.Text);
                resistance2 = Convert.ToDouble(textBox2.Text);
                resistanceTotal = resistance1 * resistance2;
                label1.Text = "total resistance = " + resistanceTotal;
            }
            catch
            {
                MessageBox.Show("type in two numbers. "); 

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
