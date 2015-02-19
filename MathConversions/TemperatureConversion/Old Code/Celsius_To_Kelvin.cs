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
    public partial class Celsius_To_Kelvin : Form
    {
        public Celsius_To_Kelvin()
        {
            InitializeComponent();
        }

        //.........................................................

        float userInputedCelsius; // Var
        float calcuKelvin; // Var

        //............................................................

        private void button1_Click(object sender, EventArgs e)
        {
            calcuKelvin = userInputedCelsius + 273.15f; // Math for the conversion.
            textBox2.Text = userInputedCelsius + " Degree Celsius = " + calcuKelvin.ToString("N3") + " Kelvin"; // after the math is done this is outputed to textbox 2. 
        }

        //.......................................................................................................................

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           float.TryParse(textBox1.Text, out userInputedCelsius); // Converts the string representation of a number in a specified style and culture-specific format to its single-precision floating-point number equivalent. 
        }

        //.................................................................................................................

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Out put from textBox 1 goes here.
        }

        //.......................................................................................................................



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // method that uses KeyChar property
        {
            char ch = e.KeyChar; // Var 

            if (!Char.IsDigit(ch) && ch != 8 && ch != '-' && ch != '.') // if a Char is different then a decimal digit number then this returns true. // Only allows the use of numbers and the "-" sign in the textbox 1.
            {
                e.Handled = true; // Gets or sets a value indicating whether the KeyPress event was handled.
            }
        }

        //........................................................................................................................
    }
}
