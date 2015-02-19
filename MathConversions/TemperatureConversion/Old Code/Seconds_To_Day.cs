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
    public partial class Seconds_To_Day : Form
    {
        public Seconds_To_Day()
        {
            InitializeComponent();
        }

        //.........................

        decimal calculatedDay;
        decimal userInputedSeconds;

        //..........................

        private void button1_Click(object sender, EventArgs e)
        {
            calculatedDay = userInputedSeconds / 86400; // Math to convert seconds to days.
            textBox2.Text = userInputedSeconds + " Seconds = " + calculatedDay.ToString("N3") + " Days"; // This Outputs the anwsner in the format I want and how many decimals.
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userInputedSeconds = Convert.ToDecimal(textBox1.Text); // Converts a specified value to a decimal number.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // CalculatedDay Goes Here.
        }

        //........................................................................................................
    }
}
