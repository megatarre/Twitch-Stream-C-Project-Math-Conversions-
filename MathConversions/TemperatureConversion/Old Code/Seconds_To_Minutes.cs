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
    public partial class Seconds_To_Minutes : Form
    {
        public Seconds_To_Minutes()
        {
            InitializeComponent();
        }

        //.........................

        decimal calculatedMinutes; //Var
        decimal userInputedSeconds; //Var

        //.........................

        private void button1_Click(object sender, EventArgs e)
        {
            calculatedMinutes = userInputedSeconds * 0.016667m; // Math To Convert Seconds To Minutes.
            textBox2.Text = userInputedSeconds + " Seconds = " + calculatedMinutes.ToString("N3") + " Minutes"; // This Outputs the anwsner in the format I want and how many decimals.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userInputedSeconds = Convert.ToDecimal(textBox1.Text); // Converts a specified value to a decimal number.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Displays the output of button1_Click.
        }
    }
}
