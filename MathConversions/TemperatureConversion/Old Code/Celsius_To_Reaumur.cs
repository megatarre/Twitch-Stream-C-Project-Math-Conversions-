using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathConversions
{
    public partial class Celsius_To_Reaumur : Form
    {
        public Celsius_To_Reaumur()
        {
            InitializeComponent();
        }

        float celsius; // Var
        float reaumur; // Var

        private void button1_Click(object sender, EventArgs e)
        {
            reaumur = celsius * 0.80000f; // This is the math formula for the conversoin.
            textBox2.Text = celsius + " Degree Celsius = " + reaumur.ToString("N3") + " Degree Reaumur";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(textBox1.Text, out celsius); // Converts the string representation of a number in a specified style and culture-specific format to its single-precision floating-point number equivalent. 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Conversion from Celsius to Reaumur goes here.
        }

        private void Celsius_To_Reaumur_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; // Var

            if (!Char.IsDigit(ch) && ch != 8 && ch != '-' && ch != '.') // if a Char is different then a decimal digit number then this returns true.  // Only allows the use of numbers and the "-" sign in the textbox 1.
            {
                e.Handled = true; // Gets or sets a value indicating whether the KeyPress event was handled.
            }
        }
    }
}
