using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathConversions.Main_Menu
{
    public partial class Fahrenheit : Form
    {
        public Fahrenheit()
        {
            InitializeComponent();
        }

        float celsius;
        float fahrenheit;
        float kelvin;
        float newton;
        float rankine;
        float reaumur;
        float romer;
        float delisle;

        private void button1_Click(object sender, EventArgs e)
        {
            celsius = (fahrenheit - 32) / 9 * 5;
            kelvin = (fahrenheit - 32) / 1.8f + 273.15f;
            newton = (fahrenheit - 32) * 0.18333333333f;
            rankine = (fahrenheit - 32) + 491.67f; 
            reaumur = (fahrenheit - 32) * 0.44444444444f;
            romer = (fahrenheit - 32) * 0.29166666667f + 7.5f;
            delisle = (212 - fahrenheit) * 0.83333f;
            textBox2.Text = fahrenheit + " °Fahrenheit = " + celsius.ToString("N6") + " °Celsius";
            textBox3.Text = fahrenheit + " °Fahrenheit = " + kelvin.ToString("N6") + " °Kelvin";
            textBox4.Text = fahrenheit + " °Fahrenheit = " + newton.ToString("N6") + " °Newton";
            textBox5.Text = fahrenheit + " °Fahrenheit = " + rankine.ToString("N6") + " °Rankine";
            textBox6.Text = fahrenheit + " °Fahrenheit = " + reaumur.ToString("N6") + " °Reaumur";
            textBox7.Text = fahrenheit + " °Fahrenheit = " + romer.ToString("N6") + " °Romer";
            textBox8.Text = fahrenheit + " °Fahrenheit = " + delisle.ToString("N6") + " °Delisle";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(textBox1.Text, out fahrenheit);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; // Var

            if (!Char.IsDigit(ch) && ch != 8 && ch != '-' && ch != '.')  // if a Char is different then a decimal digit number then this returns true.  // Only allows the use of numbers and the "-" sign in the textbox 1.
            {
                e.Handled = true; // Gets or sets a value indicating whether the KeyPress event was handled.
            }
        }
    }
}
