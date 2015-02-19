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
    public partial class Fahrenheit_To_Celsius : Form
    {
        public Fahrenheit_To_Celsius()
        {
            InitializeComponent();
        }

        //......................

        float Celsius; //Var
        float Fahrenheit; //Var

        //.......................

        private void button1_Click(object sender, EventArgs e)
        {
            Celsius = (Fahrenheit - 32) / 9 * 5; // This is the math formula for the conversoin.
            textBox2.Text = Fahrenheit + " Degree Fahrenheit = " + Celsius.ToString("N3") + " Degree Celsius "; // This Outputs the anwsner in the format I want.

        }

        //.......................................................................................................

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(textBox1.Text, out Fahrenheit); // Converts the string representation of a number in a specified style and culture-specific format to its single-precision floating-point number equivalent. 
        }

        //.......................................................................................................

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //The Output of textbox1 goes here.
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; // Var

            if (!Char.IsDigit(ch) && ch != 8 && ch != '-' && ch != '.') // if a Char is different then a decimal digit number then this returns true.  // Only allows the use of numbers and the "-" sign in the textbox 1.
            {
                e.Handled = true; // Gets or sets a value indicating whether the KeyPress event was handled.
            }
        }

        //.........................................................................................................

        
    }
}
