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
    public partial class Hour_To_Day : Form
    {
        public Hour_To_Day()
        {
            InitializeComponent();
        }

        //.........................

        decimal calculatedDay; //Var
        decimal userInputedHour; //Var

        //............................

        private void button1_Click(object sender, EventArgs e)
        {
            calculatedDay = userInputedHour / 24; // Math To Convert Seconds To Hour.
            textBox2.Text = userInputedHour + " Hour = " + calculatedDay.ToString("N3") + " Day"; // This Outputs the anwsner in the format I want and how many decimals.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userInputedHour = Convert.ToDecimal(textBox1.Text); // Converts a specified value to a decimal number.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // CalculatedDay goes here.
        }
    }
}
