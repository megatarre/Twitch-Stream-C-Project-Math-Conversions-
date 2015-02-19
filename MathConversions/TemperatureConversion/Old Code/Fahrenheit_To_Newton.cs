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
    public partial class Fahrenheit_To_Newton : Form
    {
        public Fahrenheit_To_Newton()
        {
            InitializeComponent();
        }

        float fahrenheit;
        float newton;

        private void button1_Click(object sender, EventArgs e)
        {
            newton = (fahrenheit - 32) * 0.18333333333f;
            textBox2.Text = fahrenheit + " °Fahrenheit = " + newton.ToString("N3") + " °Newton ";
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
