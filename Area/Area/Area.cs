using System;
using System.Windows.Forms;

/****************************************************
  William Weldy
  Lab #6
*****************************************************/
namespace Area
{
    public partial class areaForm : Form
    {
        public areaForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) //Program Title
        {
        }

        private void radiusLbl_Click(object sender, EventArgs e)
        {

        }

        bool isCircle = true;
        bool isSquare = false;
        double area;

        private void circButton_CheckedChanged(object sender, EventArgs e)
        {
            isCircle = true; isSquare = false;
            radiusLbl.Text = "Radius: ";
            widthLbl.Visible = false;
            widthText.Visible = false;
            areaLbl.Visible = false;
            areaText.Visible = false;
        }

        private void squareButton_CheckedChanged(object sender, EventArgs e)
        {
            isSquare = true; isCircle = false;
            radiusLbl.Text = "Side: ";
            widthLbl.Visible = false;
            widthText.Visible = false;
            areaLbl.Visible = false;
            areaText.Visible = false;
        }

        private void rectButton_CheckedChanged(object sender, EventArgs e)
        {
            isCircle = false; isSquare = false;
            radiusLbl.Text = "Height: ";
            widthLbl.Visible = true;
            widthText.Visible = true;
            areaLbl.Visible = false;
            areaText.Visible = false;
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circButton.Checked = true;
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            squareButton.Checked = true;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectButton.Checked = true;
        }

        private void calcBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                double parsedResult = double.Parse(mainText.Text);

                if (isCircle == true)
                    calcCircle(parsedResult);
                else if (isSquare == true)
                    calcSquare(parsedResult);
                else
                {
                    double width = double.Parse(widthText.Text);

                    //"parsedResult" represents the Height
                    calcRectangle(parsedResult, width);
                }

                areaLbl.Visible = true;
                areaText.Visible = true;
                areaText.Text = area.ToString("n2");
            }
            catch
            {
                MessageBox.Show("Make sure all textboxes have a numeric value.");
            }
        }

        private double calcCircle(double calcRadius)
        {
            area = 3.1416 * calcRadius;

            return area;
        }
        private double calcSquare(double calcSide)
        {
            area = calcSide * calcSide;

            return area;
        }
        private double calcRectangle(double calcHeight, double calcWidth)
        {
            area = calcHeight * calcWidth;

            return area;
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            exit();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit();
        }
        private void exit()
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Area Calculator App", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void clear()
        {
            mainText.Text = "";
            widthText.Text = "";
            areaText.Text = "";
            rectButton.Checked = false;
            circButton.Checked = false;
            squareButton.Checked = false;
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            clear();
        }
    }
}
