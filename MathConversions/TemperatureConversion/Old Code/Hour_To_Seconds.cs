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
    public partial class Hour_To_Seconds : Form
    {
        public Hour_To_Seconds()
        {
            InitializeComponent();
        }

        //.........................

        decimal calculatedSeconds; //Var
        decimal userInputedHour; //Var

        //..........................


        private void button1_Click(object sender, EventArgs e)
        {
            calculatedSeconds = userInputedHour / 0.0002778m; // Math To Convert Seconds To Hour.
            textBox2.Text = userInputedHour + " Hour = " + calculatedSeconds.ToString("N3") + " Seconds"; // This Outputs the anwsner in the format I want and how many decimals.
        }

        //......................................................................................................

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userInputedHour = Convert.ToDecimal(textBox1.Text); // Converts a specified value to a decimal number.
        }

        //.......................................................................................................

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // calculatedSeconds goes here.
        }
        
        //........................................................................................................
    }
}
