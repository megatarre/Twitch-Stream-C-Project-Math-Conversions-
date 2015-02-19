using MathConversions.Main_Menu;
using MathConversions.Project_Updates;
using MathConversions.Temperature_Conversions;
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
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
           
        }

              

        #region Var
        double userInput1 = 0.0;
        double userInput2 = 0.0;
        double result = 0.0;
        string operatorString = "";
        string strInput1 = string.Empty;
        string strInput2 = string.Empty;
        //bool haveDecimal = false;
        //bool numberEntered = true;
        bool isOperatorUsed = false;
        
        
        #endregion
                       
        #region Links

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCG7UP_EU19NyH1IJfrjYeyg");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://twitter.com/GYGamers");

        }

        //private void pictureBox4_Click(object sender, EventArgs e)
        //{
        //    System.Diagnostics.Process.Start("www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=PXZKXHBRREFMY");
        //}

        #endregion

        #region Temp conversions forms

        private void celsiusToFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Celsius f = new Celsius();
            f.Show();
        }

        private void fahrenheitToCelsiusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fahrenheit f = new Fahrenheit();
            f.Show();
        }

        private void kelvinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kelvin f = new Kelvin();
            f.Show();
        }

        private void rankineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rankine f = new Rankine();
            f.Show();
        }

        private void newtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newton f = new Newton();
            f.Show();
        }


        private void reaumurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reaumur f = new Reaumur();
            f.Show();
        }

        private void romerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Romer f = new Romer();
            f.Show();
        }

        private void delisleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delisle f = new Delisle();
            f.Show();
        }



        #endregion

        #region Calcu
        private void buttonClickNumbers(object sender, EventArgs e)
        {
            
            //If textbox is equal to a 0 then clear textbox.
            //if (textBox1.Text == "0" || textBox1.Text == ) 
            //{
            //    textBox1.Text = "";           
            //}       

            Button button = (Button)sender;
            textBox1.Text +=  button.Text; 
            CurrentOperation.Text += button.Text; //label that show the math.
 
            //If no operator is used then use strinput1 as first input, if a operator has been entered then use strinput2.
            if (operatorString == "") 
            {
                strInput1 += button.Text;
                
            }
            else
                strInput2 += button.Text;
            }

        private void theDecimal(object sender, EventArgs e)

        {
            
            if (textBox1.Text == "0") //If textbox is equal to a 0 then clear textbox.
            {
                textBox1.Text = "";
            }

          
            Button button = (Button)sender;
            textBox1.Text += button.Text;
            CurrentOperation.Text += button.Text; //label that show the math.

            //If no operator is used then use strinput1 as first input, if a operator has been entered then use strinput2.
            if (operatorString == "") 
            {
                
                strInput1 += button.Text;

            }
            else
                strInput2 += button.Text;

        }


        private void operatorButtonClick(object sender, EventArgs e)
        {
            isOperatorUsed = true; //set to true when a operator is used.

            //Code for the "+" "-" "/" and "*" 
            //textBox1.Text = "";
            Button button = (Button)sender;
            operatorString += button.Text;
            CurrentOperation.Text += button.Text; //label that show the math.

            if (isOperatorUsed == true) 
            {
                plus.Enabled = false;
            }

        }



        private void percentClick(object sender, EventArgs e)
        {
            //Need to add logic code still!
            textBox1.Text = "";
            Button button = (Button)sender;
            CurrentOperation.Text += button.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //Clears all var and strings 

            textBox1.Text = "0";
            plus.Enabled = true;
            strInput1 = "";
            strInput2 = "";
            userInput1 = 0;
            userInput2 = 0;
            operatorString = "";
            CurrentOperation.Text = "";
            result = 0.0;
            
            
        }

        private void equals_Click(object sender, EventArgs e)
        {
            //If textbox is equal to a 0 then do nothing.
            if (textBox1.Text == "0") 
            {
                return;
            }

            if (strInput1 == "") //check to see if stringinput1  is empty, If so do code in {}.
            {
                strInput2 = "0";
                    
            }

            if (strInput2 == "") //check to see if stringinput2 is empty, If so do code in {}.
            {
                strInput1 = "0";
            }
           
            //Takes the strings and parse's them as doubles for the userInput1 and 2.
                userInput1 = double.Parse(strInput1);
                userInput2 = double.Parse(strInput2);
            
            switch (operatorString) 
            {
                case "+":

                    result = userInput1 + userInput2;
                    textBox1.Text = result.ToString();
                    strInput1 = "";
                    strInput2 = "";
                    userInput1 = 0;
                    userInput2 = 0;
                    operatorString = "";
                    break;

                case "-":

                    result = userInput1 - userInput2;
                    textBox1.Text = result.ToString();
                    break;

                case "*":

                    result = userInput1 * userInput2;
                    textBox1.Text = result.ToString();
                    break;

                case "/":

                    result = userInput1 / userInput2;
                    textBox1.Text = result.ToString();
                    break;

                //case "":
                //default:
                //    break; // add the infinity text to texbox.


            }
        }

       
      
    }
#endregion


}

        