using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************
  William Weldy
  Lab #4
*****************************************************/
namespace SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void leftText_TextChanged(object sender, EventArgs e)
        {
            resultText.Text = ""; //Clears the result text box
        }

        private void rightText_TextChanged(object sender, EventArgs e)
        {
            resultText.Text = ""; //Clears the result text box
        }

        byte calcOperator;

        private void addButton_CheckedChanged(object sender, EventArgs e)
        {
            calcOperator = 1;
            operandLbl.Text = "+";
        }

        private void subtractButton_CheckedChanged(object sender, EventArgs e)
        {
            calcOperator = 2;
            operandLbl.Text = "-";
        }

        private void multiplyButton_CheckedChanged(object sender, EventArgs e)
        {
            calcOperator = 3;
            operandLbl.Text = "*";
        }

        private void divideButton_CheckedChanged(object sender, EventArgs e)
        {
            calcOperator = 4;
            operandLbl.Text = "/";
        }

        private void modulusButton_CheckedChanged(object sender, EventArgs e)
        {
            calcOperator = 5;
            operandLbl.Text = "%";
        }

       /* private void exponentButton_CheckedChanged(object sender, EventArgs e)
        {
            calcOperator = 6;
            operandLbl.Text = "^";
        }*/

        private void calcButton_Click(object sender, EventArgs e)
        {
            decimal.TryParse(leftText.Text, out decimal leftNum);
            decimal.TryParse(rightText.Text, out decimal rightNum);
            decimal result = 0;

            switch (calcOperator)
            {
                case 0: //If you haven't selected anything yet
                    MessageBox.Show("ERROR: Operator not selected.");
                    resultText.Text = "NULL";
                    break;
                case 1: //Addition
                    result = leftNum + rightNum;
                    resultText.Text = result.ToString("N");
                    break;
                case 2: //Subtraction
                    result = leftNum - rightNum;
                    resultText.Text = result.ToString("N");
                    break;
                case 3: //Multiplication
                    result = leftNum * rightNum;
                    resultText.Text = result.ToString("N");
                    break;
                case 4: //Division
                    if (leftNum == 0 || rightNum == 0)
                    {
                        MessageBox.Show("ERROR: Cannot divide by zero!");
                        resultText.Text = "NULL";
                    }
                    else
                    {
                        result = leftNum / rightNum;
                        resultText.Text = result.ToString("N");
                    }
                    break;
                case 5: //Modulus
                    if (leftNum == 0 || rightNum == 0)
                    {
                        MessageBox.Show("ERROR: Cannot divide by zero!");
                        resultText.Text = "NULL";
                    }
                    else
                    {
                        result = leftNum % rightNum;
                        resultText.Text = result.ToString("N");
                    }
                    break;
                default: //if calcOperator equals 6, 7, or 8, somehow
                    MessageBox.Show ("ERROR: Invalid Operator!");
                    break;
            }
            try
            {

            }
            catch
            {

            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            leftText.Text = "";
            rightText.Text = "";
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to William Weldy's simple calculator!\n" + 
                "To use just click one of the radio buttons, enter data to the left side, and data on the right side.\n" +
                "Press Calculate to get your result in the textbox below the 2 entry textboxes.");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Simple Calculator App", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void resultText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
