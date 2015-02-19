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
    /// <summary>
    /// A program that turns Fahrenheit to Celsius and back.
    /// </summary>

    public partial class TemperatureConversionGYG : Form
    {
        //......................................................................................
        public TemperatureConversionGYG()
        {
            InitializeComponent();
            comboBox1.Items.Add("Fahrenheit To Celsius");
            comboBox1.Items.Add("Celsius To Fahrenheit");
        }
        //........................................................................................

        /// <summary>
        /// Stores all my varables for the temperature conversions below
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        //.................................Varables.......................................................
       
        float Celsius;
        float Fahrenheit;
        
        //........................................................................................

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List of all Conversion Options.
        }

        //........................................................................................

        private void SetConversion_Click(object sender, EventArgs e)
        {
            //Output combobox1 choice to label6
            if (comboBox1.SelectedIndex == 0)
            {
                label6.Text = "Fahrenheit To Celsius";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label6.Text = " Celsius To Fahrenheit";
            }
        }

        //..........................................................................................

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Converts what is typed into textbox5 to a int.
                Fahrenheit = Convert.ToInt32(textBox5.Text);
                Celsius = Convert.ToInt32(textBox5.Text);

            }
            catch
            {
                MessageBox.Show("Please Enter Only Numbers!");
                {
                }
            }

        }

        //..................................................................................................

        private void DoMath_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) 
            {
                Celsius = (Fahrenheit - 32) / 9 * 5;
                textBox6.Text = Fahrenheit + " Degree Fahrenheit Is " + Celsius.ToString("N3") + " Degree Celsius";
            }
            if (comboBox1.SelectedIndex == 1) 
            {
                Fahrenheit = (Celsius * 9) / 5 + 32;
                textBox6.Text = Celsius + " Degree Celsius Is " + Fahrenheit.ToString("N3") + " Degree Fahrenheit";
            }
        }

        //.....................................................................................................

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label6.Text = "Fahrenheit To Celsius";
            }
        }

        
        


       
    }
}
