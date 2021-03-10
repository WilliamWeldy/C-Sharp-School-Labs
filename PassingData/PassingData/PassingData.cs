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
  Lab #7
*****************************************************/
namespace PassingData
{
    public partial class PassingData : Form
    {
        public PassingData()
        {
            InitializeComponent();
        }

        double globalOne;
        double globalTwo;
        double globalThree = 69;
        double result;

        private void Max(double maxOne, double maxTwo, double maxThree)
        {
            num1Text.Text = "";
            num2Text.Text = "";
            num3Text.Text = "";
            answerText.Text = result.ToString("n2");
        }

        private double MaxReturn(double returnOne, double returnTwo, double returnThree)
        {
            if (returnOne > returnTwo)
                if (returnOne > returnThree)
                    result = returnOne;
                if (returnTwo > returnOne)
                    if (returnTwo > returnThree)
                        result = returnTwo;
                    if (returnThree > returnOne)
                        if (returnThree > returnTwo)
                            result = returnThree;

            return result;
        }

        private double MaxGlobal(double one, double two, double three)
        {
            globalOne = one;
            globalTwo = two;
            globalThree = three;

            if (globalOne > globalTwo)
                if (globalOne > globalThree)
                    result = globalOne;
            if (globalTwo > globalThree)
                if (globalTwo > globalThree)
                    result = globalTwo;
            if (globalThree > globalOne)
                if (globalThree > globalTwo)
                    result = globalThree;

            return result;
        }

        private double MaxRef(ref double numOne, ref double numTwo, ref double numThree)
        {
            if (numOne > numTwo && numOne > numThree)
                result = numOne;
            else if (numTwo > numOne && numTwo > numThree)
                result = numTwo;
            else if (numThree > numOne && numThree > numTwo)
                result = numThree;
            else if (numOne == numTwo || numOne == numThree)
                result = numOne;
            else if (numTwo == numOne || numTwo == numThree)
                result = numTwo;
            else if (numThree == numOne || numThree == numTwo)
                result = numThree;

            return result;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            double.TryParse(num1Text.Text, out double numOne);
            double.TryParse(num2Text.Text, out double numTwo);
            double.TryParse(num3Text.Text, out double numThree);
            MaxReturn(numOne, numTwo, numThree);
            Max(numOne, numTwo, numThree);
        }

        private void globalButton_Click(object sender, EventArgs e)
        {
            double.TryParse(num1Text.Text, out double numOne);
            double.TryParse(num2Text.Text, out double numTwo);
            double.TryParse(num3Text.Text, out double numThree);
            MaxGlobal(numOne, numTwo, numThree);
            Max(globalOne, globalTwo, globalThree);
        }

        private void refButton_Click(object sender, EventArgs e)
        {
            double.TryParse(num1Text.Text, out double numOne);
            double.TryParse(num2Text.Text, out double numTwo);
            double.TryParse(num3Text.Text, out double numThree);
            MaxRef(ref numOne, ref numTwo, ref numThree);
            Max(numOne, numTwo, numThree);
        }
    }
}
