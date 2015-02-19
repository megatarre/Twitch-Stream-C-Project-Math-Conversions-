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
    public partial class TimeConversion : Form
    {
        public TimeConversion()
        {
            InitializeComponent();
            comboBox3.Items.Add("Seconds To Hour");
            comboBox3.Items.Add("Seconds To Minutes");
            comboBox3.Items.Add("Seconds To Day");
            comboBox3.Items.Add("Hour To Seconds");
            comboBox3.Items.Add("Hour To Minutes");
            comboBox3.Items.Add("Hour To Day");
        }


        decimal calculatedHour;
        decimal userInputedSeconds;
        decimal calculatedMinutes;
        decimal calculatedDay;
        decimal userInputedHour;
        decimal calculatedSeconds;
       
        

        private void TimeConversion_Load(object sender, EventArgs e)
        {

        }

       
        //List of Time Conversions 
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                userInputedSeconds = Convert.ToDecimal(textBox1.Text);
                userInputedHour = Convert.ToDecimal(textBox1.Text);
            }
            catch { MessageBox.Show("Only numbers please"); }
        }

       
        private void doMath_Click(object sender, EventArgs e)
        {
            //Seconds To Hour
            if (comboBox3.SelectedIndex == 0)
            {
                calculatedHour = userInputedSeconds * 0.00027778m;
                textBox2.Text = userInputedSeconds + " Seconds Is" + calculatedHour.ToString("N3") + " Hours";
                //label2.Text = userInputedSeconds + " Seconds Is " + calculatedHour.ToString("N3") + " Hours";
            }
            //Seconds To Minutes
            if (comboBox3.SelectedIndex == 1) 
            {
                calculatedMinutes = userInputedSeconds * 0.016667m;
                textBox2.Text = userInputedSeconds + " Seconds Is " + calculatedMinutes.ToString("N3") + " Minutes";
            }
            //Seconds To Day
            if (comboBox3.SelectedIndex == 2) 
            {
                calculatedDay = userInputedSeconds / 86400;
                textBox2.Text = userInputedSeconds + " Seconds Is " + calculatedDay.ToString("N3") + " Days";
            }
            //Hour To Seconds
            if (comboBox3.SelectedIndex == 3)
            {
                calculatedSeconds = userInputedHour / 0.0002778m;
                textBox2.Text = userInputedHour + " Hour Is " + calculatedSeconds.ToString("N3") + " Seconds";
            }
            //Hour To Minutes
            if (comboBox3.SelectedIndex == 4) 
            {
                calculatedMinutes = userInputedHour * 60.00m;
                textBox2.Text = userInputedHour + " Hour Is " + calculatedMinutes.ToString("N3") + " Minutes";
                
            }
            //Hour to Day
            if (comboBox3.SelectedIndex == 5) 
            {
                calculatedDay = userInputedHour / 24;
                textBox2.Text = userInputedHour + " Hour Is " + calculatedDay.ToString("N3") + " Day";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //The output textbox for all the conversions
        }

        private void setConversion_Click_1(object sender, EventArgs e)
        {
            //Outputs text to label1
            if (comboBox3.SelectedIndex == 0)
            {
                label1.Text = "Seconds To Hour";
            }
            //Outputs text to label1
            if (comboBox3.SelectedIndex == 1) 
            {
                label1.Text = "Seconds To Minutes";
            }
            //Outputs text to label1
            if (comboBox3.SelectedIndex == 2) 
            { 
                label1.Text = "Seconds To Day";
            }
            //Outputs text to label1
            if (comboBox3.SelectedIndex == 3) 
            {
                label1.Text = "Hour To Seconds";
            }
            //Outputs text to label1 and label2
            if (comboBox3.SelectedIndex == 4)
            {
                label1.Text = "Hour To Minutes";
            }
            //Outputs text to label1
            if (comboBox3.SelectedIndex == 5) 
            {
                label1.Text = "Hour to Day";
            }

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
