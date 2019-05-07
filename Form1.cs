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
                    if (lblDisplay.Text.Length > 0)
                    {
                        lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
                    }
                    break;

                case "btnClear":
                    operation = "";
                    lblDisplay.ResetText();
                    break;
                case "btnClearEntry":
                    lblDisplay.ResetText();
                    break;
                case "btnDecimal":
                    if (!lblDisplay.Text.Contains("."))
                    {
                        lblDisplay.Text += ".";
                    }
                    break;
                case "btnPlusMinus":
                    if (lblDisplay.Text.Length > 0)
                    {
                        if (!lblDisplay.Text.Contains("-"))
                        {
                            lblDisplay.Text = "-" + lblDisplay.Text;
                        }else if (lblDisplay.Text.Contains("-"))
                        {
                            lblDisplay.Text = lblDisplay.Text.Substring(1, lblDisplay.Text.Length-1);
                        }
                    }
                    break;
                default:
                    if (operation == "=")
                    {
                        operation = "";
                        lblDisplay.ResetText();
                    }

                    lblDisplay.Text += btn.Text;
                    break;
            }
        }
    }
}
