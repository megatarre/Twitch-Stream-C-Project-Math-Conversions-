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
    public partial class Kelvin : Form
    {
        public Kelvin()
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
            celsius = kelvin - 273.15f;
            fahrenheit = (kelvin - 273.15f) * 1.800f + 32.00f;
            rankine = (kelvin - 273.15f) * 1.8000f + 491.67f;
            newton = (kelvin - 273.15f) * 0.33000f;
            reaumur = (kelvin - 273.15f) * 0.80000f;
            romer = (kelvin - 273.15f) * 0.52500f + 7.50f;
            delisle = (373.15f - kelvin) * 1.5000f;
            textBox2.Text = kelvin + " °Kelvin = " + celsius.ToString("N6") + " °Celsius";
            textBox3.Text = kelvin + " °Kelvin = " + fahrenheit.ToString("N6") + " °Fahrenheit";
            textBox4.Text = kelvin + " °Kelvin = " + rankine.ToString("N6") + " °Rankine";
            textBox5.Text = kelvin + " °Kelvin = " + newton.ToString("N6") + " °Newton";
            textBox6.Text = kelvin + " °Kelvin = " + reaumur.ToString("N6") + " °Reaumur";
            textBox7.Text = kelvin + " °Kelvin = " + romer.ToString("N6") + " °Romer";
            textBox8.Text = kelvin + " °Kelvin = " + delisle.ToString("N6") + " °Delisle";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(textBox1.Text, out kelvin);
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
