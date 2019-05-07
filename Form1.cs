using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public static string prevEquation = "", prevOperation = "", operation = "";
        public static double answer = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void AllBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            switch(btn.Name)
            {
                case "btnDelete":
                    if (txtDisplay1.Text.Length > 0)
                    {
                        txtDisplay1.Text = txtDisplay1.Text.Substring(0, txtDisplay1.Text.Length - 1);
                    }
                    break;

                case "btnClear":
                    operation = "";
                    txtDisplay1.ResetText();
                    txtDisplay2.ResetText();
                    break;
                case "btnClearEntry":
                    txtDisplay1.ResetText();
                    break;
                case "btnDecimal":
                    if (!txtDisplay1.Text.Contains("."))
                    {
                        txtDisplay1.Text += ".";
                    }
                    break;
                case "btnPlusMinus":
                    if (txtDisplay1.Text.Length > 0)
                    {
                        if (!txtDisplay1.Text.Contains("-"))
                        {
                            txtDisplay1.Text = "-" + txtDisplay1.Text;
                        }else if (txtDisplay1.Text.Contains("-"))
                        {
                            txtDisplay1.Text = txtDisplay1.Text.Substring(1, txtDisplay1.Text.Length-1);
                        }
                    }
                    break;
                default:
                    if (operation == "=")
                    {
                        operation = "";
                        txtDisplay1.ResetText();
                    }

                    txtDisplay1.Text += btn.Text;
                    break;
            }
        }

        private void TxtDisplay2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button opr = sender as Button;

            switch(opr.Text)
            {
                case "+":
                    if(txtDisplay1.Text.Length > 0)
                    {
                        if(operation == "" || operation == "=")
                        {
                            operation = "+";
                            prevOperation = operation;
                            prevEquation = txtDisplay1.Text;
                            txtDisplay2.Text = prevEquation + operation;
                            txtDisplay1.ResetText();
                        }
                    }
                    else
                    {
                        operation = "+";
                        multi_equations();
                    }
                    break;

                case "-":
                    if (txtDisplay1.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "-";
                            prevOperation = operation;
                            prevEquation = txtDisplay1.Text;
                            txtDisplay2.Text = prevEquation + operation;
                            txtDisplay1.ResetText();
                        }
                    }
                    else
                    {
                        operation = "-";
                        multi_equations();
                    }
                    break;

                case "/":
                    if (txtDisplay1.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "/";
                            prevOperation = operation;
                            prevEquation = txtDisplay1.Text;
                            txtDisplay2.Text = prevEquation + operation;
                            txtDisplay1.ResetText();
                        }
                    }
                    else
                    {
                        operation = "/";
                        multi_equations();
                    }
                    break;

                case "X":
                    if (txtDisplay1.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "X";
                            prevOperation = operation;
                            prevEquation = txtDisplay1.Text;
                            txtDisplay2.Text = prevEquation + operation;
                            txtDisplay1.ResetText();
                        }
                    }
                    else
                    {
                        operation = "X";
                        multi_equations();
                    }
                    break;

                case "=":
                    if (txtDisplay1.Text.Length > 0)
                    {
                        operation = "=";
                        multi_equations();
                        txtDisplay2.ResetText();
                        txtDisplay1.Text = answer.ToString();
                    }
                    break;
            }

        }

        private void multi_equations()
        {
            if (prevOperation == "+")
            {
                prevOperation = operation;
                answer = Convert.ToDouble(prevEquation) + Convert.ToDouble(txtDisplay1.Text);
                prevEquation = answer.ToString();
                txtDisplay2.Text = prevEquation + operation;
                txtDisplay1.ResetText();
            }
            else if (prevOperation == "-")
            {
                prevOperation = operation;
                answer = Convert.ToDouble(prevEquation) - Convert.ToDouble(txtDisplay1.Text);
                prevEquation = answer.ToString();
                txtDisplay2.Text = prevEquation + operation;
                txtDisplay1.ResetText();
            }
            else if (prevOperation == "/")
            {
                prevOperation = operation;
                answer = Convert.ToDouble(prevEquation) / Convert.ToDouble(txtDisplay1.Text);
                prevEquation = answer.ToString();
                txtDisplay2.Text = prevEquation + operation;
                txtDisplay1.ResetText();
            }
            else if (prevOperation == "X")
            {
                prevOperation = operation;
                answer = Convert.ToDouble(prevEquation) * Convert.ToDouble(txtDisplay1.Text);
                prevEquation = answer.ToString();
                txtDisplay2.Text = prevEquation + operation;
                txtDisplay1.ResetText();
            }
        }
    }
}
