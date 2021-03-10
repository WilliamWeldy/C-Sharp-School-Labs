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
  Lab #3
*****************************************************/
namespace Convert
{
    public partial class convertForm : Form
    {
        public convertForm()
        {
            InitializeComponent();
        }

        bool enteringCelcius;
        bool enteringFahrenheit;
        double fahrenheit;
        double celcius;

        private void convertBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (enteringFahrenheit==true)
                {
                    fahrenheit = double.Parse(fahrText.Text);
                    celcius = (fahrenheit - 32) / 1.8;
                    celciusLbl.Visible = true;
                    celciusText.Visible = true;
                    celciusText.Text = celcius.ToString("n");
                }
                else if(enteringCelcius==true)
                {
                    celcius = double.Parse(celciusText.Text);
                    fahrenheit = (celcius * 1.8) + 32;
                    fahrLbl.Visible = true;
                    fahrText.Visible = true;
                    fahrText.Text = fahrenheit.ToString("n");
                }
                else
                {
                    MessageBox.Show("Select a conversion method, and enter a value in the textbox you are converting.");
                }
            }
            catch
            {
                MessageBox.Show("Value needs to be numeric.");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            fahrText.Text = "";
            celciusText.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Temperature Conversion Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fahrToCelciusBtn_CheckedChanged(object sender, EventArgs e)
        {
            enteringFahrenheit = true;
            enteringCelcius = false;
            titleLbl.Text = "Fahrenheit to Celcius";
            celciusLbl.Visible = false;
            celciusText.Visible = false;
            fahrLbl.Visible = true;
            fahrText.Visible = true;
        }

        private void celciusToFahrBtn_CheckedChanged(object sender, EventArgs e)
        {
            enteringCelcius = true;
            enteringFahrenheit = false;
            titleLbl.Text = "Celcius to Fahrenheit";
            fahrLbl.Visible = false;
            fahrText.Visible = false;
            celciusLbl.Visible = true;
            celciusText.Visible = true;
        }
    }
}
