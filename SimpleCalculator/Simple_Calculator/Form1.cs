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
        double number1 = 0;
        double number2 = 0;
        double result = 0;
        string operation = " ";
        public Form1()
        {
            InitializeComponent();
            rdAdd.Checked = true;
            operation = "+";
        }

        private void rdAdd_CheckedChanged(object sender, EventArgs e)
        {
            operation = "+";

        }

        private void rdSub_CheckedChanged(object sender, EventArgs e)
        {
            operation = "-";
        }

        private void rdMul_CheckedChanged(object sender, EventArgs e)
        {
            operation = "*";
        }

        private void rdDiv_CheckedChanged(object sender, EventArgs e)
        {
            operation = "/";
        }

        private void rdModu_CheckedChanged(object sender, EventArgs e)
        {
            operation = "%";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool num1 = double.TryParse(txtLeftOperand.Text, out number1);
            bool num2 = double.TryParse(txtRightOperand.Text, out number2);

            if(num1 && num2)
            {
                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        txtResult.Text = result.ToString();
                        txtExpretion.Text = (txtLeftOperand.Text + '+' + txtRightOperand.Text).ToString();
                        break;

                    case "-":
                        result = number1 - number2;
                        txtResult.Text = result.ToString();
                        txtExpretion.Text = (txtLeftOperand.Text + '-' + txtRightOperand.Text).ToString();
                        break;

                    case "*":
                        result = number1 * number2;
                        txtResult.Text = result.ToString();
                        txtExpretion.Text = (txtLeftOperand.Text + '*' + txtRightOperand.Text).ToString();
                        break;

                    case "/":
                        if(number2 != 0)
                        {
                            result = number1 / number2;
                            txtResult.Text = result.ToString("0.00");
                            txtExpretion.Text = (txtLeftOperand.Text + '/' + txtRightOperand.Text).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Denominator can't be 0 !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case "%":
                        if (number2 != 0)
                        {
                            result = number1 % number2;
                            txtResult.Text = result.ToString();
                            txtExpretion.Text = (txtLeftOperand.Text + '%' + txtRightOperand.Text).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Denominator can't be 0 !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                }
            }
            else
            {
                MessageBox.Show("Data Provided is Invalid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
