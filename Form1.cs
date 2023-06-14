/* - - - - * 
 March 2021, OOP Project 1
 * - - - - *
 Team: noble rubber duckies
 * - - - - * 
 Members:
 Emirhan Caliskan (56140)
 Nattawat Srisuriyaprateep (55499)
 * - - - - *
 Simple calculator app that can perform several operations.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class calcForm : Form
    {
        
        //stores what operator is chosen
        string oper = "";

        public calcForm()
        {
            InitializeComponent();
            result.BringToFront();            
        }

        //clear all fileds
        private void clearClick(object sender, EventArgs e)
        {
            val1Box.Text = "";
            val2Box.Text = "";
            oper = "";
            operatorDisplay.Text = "";
            result.Text = "";
        }

        //exit the app
        private void exitClick(object sender, EventArgs e)
        {
            Close();
        }

        //clears operator and its display upon clicking its label
        private void operDispClick(object sender, EventArgs e)
        {
            oper = "";
            operatorDisplay.Text = "";
        }

        //initiates colorful blinking effect on credits label upon clicking the label
        private void authorClick(object sender, EventArgs e)
        {
            blinker();
        }
    
        //swaps inputs between text boxes
        private void swapClick(object sender, EventArgs e)
        {
            string buffer = val1Box.Text;
            val1Box.Text = val2Box.Text;
            val2Box.Text = buffer;
        }

        //clear output upon clicking "OUTPUT:" text
        private void clickTextOutput(object sender, EventArgs e)
        {
            result.Text = "";
        }

        //manages operation choice
        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            oper = button.Text;
            operatorDisplay.Text = oper;
        }

        //manages "calculate" button click behaviour
        private void calcClick(object sender, EventArgs e)
        {
            //both input has to be a double
            if (double.TryParse(val1Box.Text, out _) && double.TryParse(val2Box.Text, out _)) 
            {
                result.Text = registerOper(oper);
            } 
            //handle "not both are a double" case
            else 
            {
                result.Text = userErrorHandle(val1Box.Text, val2Box.Text);
            }
        }

        //defining what each operator does
        private string registerOper(string oper) 
        {
            //after return break is unreachable and also useless
            switch (oper)
            {
                case "+":
                    return val1Box.Text + " " + oper + negationHandle(val2Box.Text, true) + (Double.Parse(val1Box.Text) + Double.Parse(val2Box.Text)).ToString();

                case "-":
                    return val1Box.Text + " " + oper + negationHandle(val2Box.Text, true) + (Double.Parse(val1Box.Text) - Double.Parse(val2Box.Text)).ToString();

                case "/":
                    return result.Text = divisionZero(val1Box.Text, val2Box.Text, true);

                case "*":
                    return val1Box.Text + " " + oper + negationHandle(val2Box.Text, true) + (Double.Parse(val1Box.Text) * Double.Parse(val2Box.Text)).ToString();

                case "%":
                    return divisionZero(val1Box.Text, val2Box.Text, false);

                case "^":
                    return negationHandle(val1Box.Text, false) + oper + negationHandle(val2Box.Text, true) + (Math.Pow(Double.Parse(val1Box.Text), Double.Parse(val2Box.Text))).ToString();

                case "!":
                    return factCalc(val1Box.Text) + Environment.NewLine + Environment.NewLine + factCalc(val2Box.Text);

                case "log":
                    return logCalc(val1Box.Text, val2Box.Text);

                case "lcm":
                    return oper + " of " + val1Box.Text + " and " + val2Box.Text + " is:" + Environment.NewLine + lcmCalc(val1Box.Text, val2Box.Text).ToString();

                case "gcd":
                    return oper + " of " + val1Box.Text + " and " + val2Box.Text + " is:" + Environment.NewLine + gcdCalc(val1Box.Text, val2Box.Text).ToString();

                //ERROR: no operation is selected
                default:
                    return "No operation selected!";
            }
        }

        private string userErrorHandle(string a, string b) 
        {
            bool isNumber = double.TryParse(a, out _) || double.TryParse(b, out _);
            bool isEmpty = a == "" && b == "";

            //chosen operation is factorial and not all text boxes are empty
            if (!isEmpty && oper == "!")
            {
                return handleFact();
            }
            //error: there is an empty text box
            else if (a == "" || b == "")
            {
                return "Fill in boxes first!";
            }
            //error: no operation can take place with this set of inputs
            else
            {
                return "Invalid Input! Enter numbers only.";
            }

        }
       
        //handles how program reacts to division by zero + modulus and division operation
        private string divisionZero(string a, string b, bool c) 
        {
            //ERROR: can't divide by zero
            if (double.Parse(b) == 0)
            {
                return "Mathematically undefined request:" + Environment.NewLine + "Can't divide by zero";
            }
            else if (c == true)
            {
                return val1Box.Text + " " + oper + negationHandle(val2Box.Text, true) + (Double.Parse(val1Box.Text) / Double.Parse(val2Box.Text)).ToString();
            }
            else 
            {
                return val1Box.Text + " " + oper + negationHandle(val2Box.Text, true) + (Double.Parse(val1Box.Text) % Double.Parse(val2Box.Text)).ToString();
            }
        }

        //CHECK: is factorial possible? + CALCULATE: factorial
        private string factCalc(string a)
        {
            //is it integer? AND is it positive?
            if (int.TryParse(a, out _) && double.Parse(a) >= 0)
            {
                ulong result = ulong.Parse(a);

                //by defination: 0! = 1
                if (uint.Parse(a) == 0)
                    result = 1;

                //calculate factorial for a>0
                for (uint i = 1; i < uint.Parse(a); i++)
                {
                    result *= i;
                }

                if (int.Parse(a) > 65) //result of 66! cannot be stored in a ulong
                {
                    return "Can't compute.. Too big!";
                }
                else 
                {
                    return a + oper + " = " + (result).ToString();
                }
                
            }
            //ERROR: mathematically undefined request, either negative or noninteger
            else
            {
                return "Mathematically undefined request:" + Environment.NewLine + "'" + a + "' has to be a positive integer";
            }
        }

        //detect that a single input is provided: calculate the factorial for that + do not display any error message for the other
        private string handleFact() 
        {
            if (val1Box.Text == "" || val2Box.Text == "")
            {
                if (val1Box.Text == "")
                    return factCalc(val2Box.Text);
                if (val2Box.Text == "")
                    return factCalc(val1Box.Text);
                return ""; //given the context from "calcClick", this line will never be exacuted
            }
            else
            {
                return factCalc(val1Box.Text) + Environment.NewLine + Environment.NewLine + factCalc(val2Box.Text);
            }           
        }

        //calculate logarithm given argument and base + handle invalid cases
        private string logCalc(string a, string b) 
        {
            if (double.Parse(b) >= 0 && double.Parse(a) > 0)
            {
                return "The base " + val2Box.Text + " logarithm of " + val1Box.Text + " is:" + Environment.NewLine + (Math.Log(double.Parse(a)) / Math.Log(double.Parse(b))).ToString();
            }
            else if (double.Parse(b) < 0 || double.Parse(a) < 0) 
            {
                return "Mathematically undefined request:" + Environment.NewLine + "The base of the logarithm (" + b + ") and/or" + Environment.NewLine + "the argument (" + a + ") cannot be negative!";
            }
            // argument is zero
            else 
            {
                return "Mathematically undefined request:" + Environment.NewLine + "The argument of the logarithm" + Environment.NewLine + "cannot be zero";
            }
        }

        //calculate gcd
        private double gcdCalc(string a, string b)
        {
            if (double.Parse(b) == 0)
            {
                return double.Parse(a);
            }

            return Math.Abs(gcdCalc(b, (double.Parse(a) % double.Parse(b)).ToString()));
        }

        //calculate lcm
        private double lcmCalc(string a, string b) 
        {
            double result = Math.Abs(double.Parse(a) * double.Parse(b)) / gcdCalc(a, b);           
            return Math.Abs(result);
        }

        /*
          implementation of feature to add paranthesis to negative second values so that the
          output does not look awkward. ex: '3 - -4 = 7' is bad, '3 - (-4) = 7' is better.     
        */
        private string negationHandle(string a, bool b) 
        {
            if (double.Parse(a) < 0 && b) 
            {              
                return " (" + a + ") = ";
            }
            else if (double.Parse(a) >= 0 && b)
            {
                return " " + a + " = ";
            }
            else if (double.Parse(a) < 0 && !b) 
            {
                return "(" + a + ") ";
            }
            else 
            {
                return a + " ";
            }
        }

        // blinking colorful text effect for "DEVELOPED BY: ..." text, activated after a click
        private async void blinker()
        {
            while (true)
            {
                await Task.Delay(500);
                authors.BackColor = authors.BackColor == Color.Red ? Color.Green : Color.Red;
            }
        }       
    }
}




