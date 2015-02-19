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
    public partial class Delisle : Form
    {
        public Delisle()
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
            celsius = 100f - delisle * .6667f;
            fahrenheit = 212f - delisle * 1.2f;
            kelvin = 373.15f - delisle * .6667f;
            newton = 33 - delisle * .22f;
            rankine = 671.67f - delisle * 1.2f;
            reaumur = 80 - delisle * 0.53333333333333f;
            romer = 60 - delisle * 0.35f;
            textBox2.Text = delisle + " °Delisle = " + celsius.ToString("N3") + " °Celsius";
            textBox3.Text = delisle + " °Delisle = " + fahrenheit.ToString("N3") + " °fahrenheit";
            textBox4.Text = delisle + " °Delisle = " + kelvin.ToString("N3") + " °Kelvin";
            textBox5.Text = delisle + " °Delisle = " + newton.ToString("N3") + " °Newton";
            textBox6.Text = delisle + " °Delisle = " + rankine.ToString("N3") + " °Rankine";
            textBox7.Text = delisle + " °Delisle = " + reaumur.ToString("N3") + " °Reaumur";
            textBox8.Text = delisle + " °Delisle = " + romer.ToString("N3") + " °Romer";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(textBox1.Text, out delisle);
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
