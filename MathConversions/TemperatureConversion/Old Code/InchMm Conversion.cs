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
    public partial class InchMm_Conversion : Form
    {
        public InchMm_Conversion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Varables for the lenth conversion math
        /// </summary>

        decimal millimeters;
        decimal inch;
        decimal calculatedMillimeter;
        decimal calculatedInches;



        private void InchMm_Conversion_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                inch = Convert.ToDecimal(textBox1.Text);
            }
            catch { MessageBox.Show("Please enter only numbers."); } //Message to tell user to only input numbers if error occers (Temp Fix)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculatedMillimeter = inch / 0.039370m;
            textBox2.Text = calculatedMillimeter.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //allows Input In textbox3 to be repracent as a decimal
                millimeters = Convert.ToDecimal(textBox3.Text);
            }
            catch { MessageBox.Show("Please enter only numbers."); } //Message to tell user to only input numbers if error occers (Temp Fix)
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //The math to turn millimeters Into Inches
            calculatedInches = millimeters * 0.039370m;

            //Outputs the calculatedInches Into textbox4
            textBox4.Text = calculatedInches.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

                       

    }
}
