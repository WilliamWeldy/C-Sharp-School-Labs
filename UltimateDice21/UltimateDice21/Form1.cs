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
  Mini-Project Assignment
*****************************************************/
namespace UltimateDice21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int diceSum = 0;
        Dice dieOne = new Dice();
        Dice dieTwo = new Dice();
        string[] diceNumLbl = new String[7] { "NULL", "One", "Two", "Three", "Four", "Five", "Six" };

        private void rollBtn_Click_1(object sender, EventArgs e)
        {
            int diceOneRoll = dieOne.roll();
            int diceTwoRoll = dieTwo.roll();

            if (diceSum < 15)
            {
                diceSum = diceSum + dieOne.roll() + dieTwo.roll();
                if (diceSum >= 15 && diceSum < 21)
                {
                    diceOneLbl.Visible = false;
                    dicePic1.Visible = false;
                    diceTwoLbl.Visible = false;
                    dicePic2.Visible = false;
                    finalDiceLbl.Visible = true;
                    finalDicePic.Visible = true;
                }
            }
            else if (diceSum >= 15 && diceSum < 21)
            {
                diceSum = diceSum + dieOne.roll();

                diceOneLbl.Visible = false;
                dicePic1.Visible = false;
                diceTwoLbl.Visible = false;
                dicePic2.Visible = false;
                finalDiceLbl.Visible = true;
                finalDicePic.Visible = true;

            }
            if (diceSum == 21)
            {
                currentText.Text = "YOU";
                historyText2.Text = "WON!";

                historyText1.Text = "";

                if (MessageBox.Show("21!  You Win!!!  Want to play again?", "Ultimate Dice 21 Game", MessageBoxButtons.YesNo) == DialogResult.No)
                    this.Close();
                else
                {
                    finalDiceLbl.Visible = false;
                    finalDicePic.Visible = false;

                    diceOneLbl.Visible = true;
                    dicePic1.Visible = true;
                    diceTwoLbl.Visible = true;
                    dicePic2.Visible = true;

                    diceSum = 0;
                    currentText.Text = historyText1.Text;
                    historyText2.Text = historyText1.Text;
                }
            }

            else if (diceSum > 21)
            {
                finalDiceLbl.Visible = false;
                finalDicePic.Visible = false;
                historyText1.Text = "";
                currentText.Text = historyText1.Text;
                historyText2.Text = historyText1.Text;

                if (MessageBox.Show("Bust. You've gone over 21. Would you like to try it again?", "Ultimate Dice 21 Game", MessageBoxButtons.YesNo) == DialogResult.No)
                    this.Close();
                else
                {
                    diceOneLbl.Visible = true;
                    dicePic1.Visible = true;
                    diceTwoLbl.Visible = true;
                    dicePic2.Visible = true;
                    diceSum = 0;
                }
            }
            
            diceOneLbl.Text = diceNumLbl[dieOne.roll()];
            diceTwoLbl.Text = diceNumLbl[dieTwo.roll()];
            finalDiceLbl.Text = diceNumLbl[dieOne.roll()];
            ChangeFinalDicePic(dieOne.roll());
            changeDicePic1(dieOne.roll());
            changeDicePic2(dieTwo.roll());

            historyText2.Text = historyText1.Text;
            historyText1.Text = currentText.Text;
            currentText.Text = "You rolled a " + (dieOne.roll()) + " and a " + (dieTwo.roll()) + ". You're at " + diceSum + " total.";
        }

        private void changeDicePic1(int picRequest)
        {
            switch (picRequest)
            {
                case 1:
                    dicePic1.Image = UltimateDice21.Properties.Resources.DiceOne;
                    break;
                case 2:
                    dicePic1.Image = UltimateDice21.Properties.Resources.DiceTwo;
                    break;
                case 3:
                    dicePic1.Image = UltimateDice21.Properties.Resources.DiceThree;
                    break;
                case 4:
                    dicePic1.Image = UltimateDice21.Properties.Resources.DiceFour;
                    break;
                case 5:
                    dicePic1.Image = UltimateDice21.Properties.Resources.DiceFive;
                    break;
                case 6:
                    dicePic1.Image = UltimateDice21.Properties.Resources.DiceSix;
                    break;
                default:
                    MessageBox.Show("pic1 invalid Image");
                    break;
            }
        }
        private void changeDicePic2(int picRequest)
        {
            switch (picRequest)
            {
                case 1:
                    dicePic2.Image = UltimateDice21.Properties.Resources.DiceOne;
                    break;
                case 2:
                    dicePic2.Image = UltimateDice21.Properties.Resources.DiceTwo;
                    break;
                case 3:
                    dicePic2.Image = UltimateDice21.Properties.Resources.DiceThree;
                    break;
                case 4:
                    dicePic2.Image = UltimateDice21.Properties.Resources.DiceFour;
                    break;
                case 5:
                    dicePic2.Image = UltimateDice21.Properties.Resources.DiceFive;
                    break;
                case 6:
                    dicePic2.Image = UltimateDice21.Properties.Resources.DiceSix;
                    break;
                default:
                    MessageBox.Show("pic2 invalid Image");
                    break;
            }
        }
        private void ChangeFinalDicePic(int picRequest)
        {
            switch (picRequest)
            {
                case 1:
                    finalDicePic.Image = UltimateDice21.Properties.Resources.DiceOne;
                    break;
                case 2:
                    finalDicePic.Image = UltimateDice21.Properties.Resources.DiceTwo;
                    break;
                case 3:
                    finalDicePic.Image = UltimateDice21.Properties.Resources.DiceThree;
                    break;
                case 4:
                    finalDicePic.Image = UltimateDice21.Properties.Resources.DiceFour;
                    break;
                case 5:
                    finalDicePic.Image = UltimateDice21.Properties.Resources.DiceFive;
                    break;
                case 6:
                    finalDicePic.Image = UltimateDice21.Properties.Resources.DiceSix;
                    break;
                default:
                    MessageBox.Show("final pic invalid Image");
                    break;
            }
        }

        class Dice
        {
            int[] animation = new int[6] { 1, 2, 3, 4, 5, 6 };
            string[] dicePic = new String[7] { "NULL", "DiceOne", "DiceTwo", "DiceThree", "DiceFour", "DiceFive", "DiceSix" };

            //Dice's Constructor
            public Dice()
            {

            }

            public int roll()
            {
                Random rand = new Random();
                int diceRoll;

                diceRoll = rand.Next(6) + 1;

                return diceRoll;
            }
        }

        private void currentText_TextChanged(object sender, EventArgs e){}
    }
}
