using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_3
{
    public partial class Form1 : Form
    {
        private string input = string.Empty;
        private double firstOperand = 0;
        private string operatorSelected = "";
        private bool isOperatorPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            input += button.Text; 
            txtDisplay.Text += button.Text;
        }
        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (double.TryParse(input, out firstOperand))
            {
                operatorSelected = button.Text;       
                txtDisplay.Text += " " + operatorSelected + " ";
                input = string.Empty;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double secondOperand;
            if (double.TryParse(input, out secondOperand))
            {
                double result = 0;
                switch (operatorSelected)
                {
                    case "+":
                        result = firstOperand + secondOperand;
                        break;
                    case "-":
                        result = firstOperand - secondOperand;
                        break;
                    case "*":
                        result = firstOperand * secondOperand;
                        break;
                    case "/":
                        result = secondOperand != 0 ? firstOperand / secondOperand : 0;
                        break;
                }

                txtDisplay.Text = result.ToString();
                input = result.ToString();
                firstOperand = result;
                isOperatorPressed = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            firstOperand = 0;
            operatorSelected = string.Empty;
            txtDisplay.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                double num;
                double.TryParse(input, out num);
                input = (-num).ToString();
                txtDisplay.Text = input;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            input = string.Empty;
            txtDisplay.Text = "0";
        }
    }
}