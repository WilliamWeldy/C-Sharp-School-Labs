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
  Lab #9
*****************************************************/
namespace MyArray
{
    public partial class myArray : Form
    {
        public myArray()
        {
            InitializeComponent();
        }

        decimal[] MyArray = new decimal[10];
        int element = 0;

        private void addButton_Click(object sender, EventArgs e)
        {
            decimal.TryParse(arrayTextBox.Text, out decimal tempArrayNum);
            try {
                MyArray[element] = tempArrayNum;
            }
            catch {
                if (element == 10)
                {
                    List<decimal> MyList = new List<decimal>();
                    foreach (int increment in MyArray)
                    {
                        MyList[element] = MyArray[element];
                        MyArray[element] = 0;
                    }
                }
                else if (element > 10) {
                    MyList.Add(tempArrayNum);
                }
            }
            switch (element)
            {
                case 0:
                    confirmLbl.Text = "1st Value Accepted";
                    break;
                case 1:
                    confirmLbl.Text = "2nd Value Accepted";
                    break;
                case 2:
                    confirmLbl.Text = "3rd Value Accepted";
                    break;
                case 21:
                    confirmLbl.Text = "21st Value Accepted";
                    break;
                case 22:
                    confirmLbl.Text = "22nd Value Accepted";
                    break;
                case 23:
                    confirmLbl.Text = "23rd Value Accepted";
                    break;
                case 31:
                    confirmLbl.Text = "Value Accepted";
                    break;
                default:
                    confirmLbl.Text = (element+1) + "th Value Accepted";
                    break;
            }
            element++;
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            foreach(int increment in MyArray) {
                Console.WriteLine();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Array App", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void myArray_Load(object sender, EventArgs e)
        {

        }
    }
}
