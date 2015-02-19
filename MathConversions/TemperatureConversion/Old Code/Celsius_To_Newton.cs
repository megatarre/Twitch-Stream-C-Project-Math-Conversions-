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
    public partial class Celsius_To_Newton : Form
    {
        public Celsius_To_Newton()
        {
            InitializeComponent();
        }

        //...................................................................................

        float celsius; // Var
        float newton; // Var

        //...................................................................................

        private void button1_Click(object sender, EventArgs e)
        {
            newton = celsius * 0.33000f; // Math for the conversion.
            textBox2.Text = celsius + " Degree Celsius = " + newton.ToString("N5") + " Newton"; // after the math is done this is outputed to textbox 2. 
        }

        //....................................................................................................

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(textBox1.Text, out celsius); // Converts the string representation of a number in a specified style and culture-specific format to its single-precision floating-point number equivalent. 
        }

        //.....................................................................................................................................

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Math from celsius to newton goes here.
        }

        //....................................................................................................................................

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; // Var

            if (!Char.IsDigit(ch) && ch != 8 && ch != '-' && ch != '.') // if a Char is different then a decimal digit number then this returns true. // Only allows the use of numbers and the "-"
            {
                e.Handled = true; // Gets or sets a value indicating whether the KeyPress event was handled.
            }
        }

        //.............................................................................................................................................
    }
}
