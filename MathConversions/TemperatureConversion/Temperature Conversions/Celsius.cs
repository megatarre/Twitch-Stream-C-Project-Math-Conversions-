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
    public partial class Celsius : Form
    {
        public Celsius()
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
            fahrenheit = celsius * 9 / 5 + 32;
            kelvin = celsius + 273.15f;
            newton = celsius * 0.33000f;
            rankine = celsius * 9 / 5 + 491.67f;
            reaumur = celsius * 0.80000f;
            romer = celsius * 0.52500f + 7.50f;
            delisle = (100 - celsius) * 1.500f;
            textBox2.Text = celsius + " °Celsius = " + fahrenheit.ToString("N6") + " °Fahrenheit";
            textBox3.Text = celsius + " °Celsius = " + kelvin.ToString("N6") + " °Kelvin";
            textBox4.Text = celsius + " °Celsius = " + newton.ToString("N6") + " °Newton";
            textBox5.Text = celsius + " °Celsius = " + rankine.ToString("N6") + " °Rankine";
            textBox6.Text = celsius + " °Celsius = " + reaumur.ToString("N6") + " °Reaumur";
            textBox7.Text = celsius + " °Celsius = " + romer.ToString("N6") + " °Romer";
            textBox8.Text = celsius + " °Celsius = " + delisle.ToString("N6") + " °Delisle";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(textBox1.Text, out celsius);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar; // Var

            if (!Char.IsDigit(ch) && ch != 8 && ch != '-' && ch != '.') // if a Char is different then a decimal digit number then this returns true.  // Only allows the use of numbers and the "-" sign in the textbox 1.
            {
                e.Handled = true; // Gets or sets a value indicating whether the KeyPress event was handled.
            }
        }
    }
}
