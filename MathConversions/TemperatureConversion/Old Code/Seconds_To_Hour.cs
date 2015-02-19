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
    public partial class Seconds_To_Hour : Form
    {
        public Seconds_To_Hour()
        {
            InitializeComponent();
        }

        //..........................

        decimal calculatedHour; //Var
        decimal userInputedSeconds; //Var

        //...........................
        

        private void button1_Click(object sender, EventArgs e)
        {
            calculatedHour = userInputedSeconds * 0.00027778m; // Math To Convert Seconds To Hour.
            textBox2.Text = userInputedSeconds + " Seconds = " + calculatedHour.ToString("N3") + " Hours"; // This Outputs the anwsner in the format I want and how many decimals.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userInputedSeconds = Convert.ToDecimal(textBox1.Text); // Converts a specified value to a decimal number.
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // CalculatedHour OutPut Goes Here.
        }
    }
}
