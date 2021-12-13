using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tempareture_converter_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // for Celsius to Fahrenheit
        private void button1_Click(object sender, EventArgs e)
        {
            if (celcius_box.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            float c = float.Parse(celcius_box.Text);
            float f = (9 * c + 160) / 5;

            result_fahrenheit.Text = f.ToString() + " F";

        }

        // For clear button
        private void button2_Click(object sender, EventArgs e)
        {
            celcius_box.Clear();
            fahrenheit_box.Clear();


            result_fahrenheit.Text = "0 F";
            result_celsius.Text = "0 C";
        }


        // for Fahrenheit to Celsius
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(fahrenheit_box.Text == "")
            {
                MessageBox.Show("Please enter a value!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            float f = float.Parse(fahrenheit_box.Text);
            float c = (5 * f - 160) / 9;
            result_celsius.Text = c.ToString() + " C";
        }
    }
}
