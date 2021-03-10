namespace UltimateDice21
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.diceOneLbl = new System.Windows.Forms.Label();
            this.finalDiceLbl = new System.Windows.Forms.Label();
            this.diceTwoLbl = new System.Windows.Forms.Label();
            this.rollBtn = new System.Windows.Forms.Button();
            this.dicePic1 = new System.Windows.Forms.PictureBox();
            this.dicePic2 = new System.Windows.Forms.PictureBox();
            this.finalDicePic = new System.Windows.Forms.PictureBox();
            this.currentText = new System.Windows.Forms.TextBox();
            this.historyText1 = new System.Windows.Forms.TextBox();
            this.historyText2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dicePic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDicePic)).BeginInit();
            this.SuspendLayout();
            // 
            // diceOneLbl
            // 
            this.diceOneLbl.AutoSize = true;
            this.diceOneLbl.Location = new System.Drawing.Point(26, 181);
            this.diceOneLbl.Name = "diceOneLbl";
            this.diceOneLbl.Size = new System.Drawing.Size(35, 13);
            this.diceOneLbl.TabIndex = 0;
            this.diceOneLbl.Text = "Three";
            this.diceOneLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finalDiceLbl
            // 
            this.finalDiceLbl.AutoSize = true;
            this.finalDiceLbl.Location = new System.Drawing.Point(167, 181);
            this.finalDiceLbl.Name = "finalDiceLbl";
            this.finalDiceLbl.Size = new System.Drawing.Size(35, 13);
            this.finalDiceLbl.TabIndex = 1;
            this.finalDiceLbl.Text = "Three";
            this.finalDiceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.finalDiceLbl.Visible = false;
            // 
            // diceTwoLbl
            // 
            this.diceTwoLbl.AutoSize = true;
            this.diceTwoLbl.Location = new System.Drawing.Point(303, 181);
            this.diceTwoLbl.Name = "diceTwoLbl";
            this.diceTwoLbl.Size = new System.Drawing.Size(35, 13);
            this.diceTwoLbl.TabIndex = 2;
            this.diceTwoLbl.Text = "Three";
            this.diceTwoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rollBtn
            // 
            this.rollBtn.Location = new System.Drawing.Point(152, 224);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(75, 23);
            this.rollBtn.TabIndex = 3;
            this.rollBtn.Text = "&Roll Dice!";
            this.rollBtn.UseVisualStyleBackColor = true;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click_1);
            // 
            // dicePic1
            // 
            this.dicePic1.Image = global::UltimateDice21.Properties.Resources.DiceThree;
            this.dicePic1.Location = new System.Drawing.Point(12, 114);
            this.dicePic1.Name = "dicePic1";
            this.dicePic1.Size = new System.Drawing.Size(65, 64);
            this.dicePic1.TabIndex = 4;
            this.dicePic1.TabStop = false;
            // 
            // dicePic2
            // 
            this.dicePic2.Image = global::UltimateDice21.Properties.Resources.DiceThree;
            this.dicePic2.Location = new System.Drawing.Point(291, 111);
            this.dicePic2.Name = "dicePic2";
            this.dicePic2.Size = new System.Drawing.Size(65, 64);
            this.dicePic2.TabIndex = 5;
            this.dicePic2.TabStop = false;
            // 
            // finalDicePic
            // 
            this.finalDicePic.Image = global::UltimateDice21.Properties.Resources.DiceThree;
            this.finalDicePic.Location = new System.Drawing.Point(152, 111);
            this.finalDicePic.Name = "finalDicePic";
            this.finalDicePic.Size = new System.Drawing.Size(65, 64);
            this.finalDicePic.TabIndex = 6;
            this.finalDicePic.TabStop = false;
            this.finalDicePic.Visible = false;
            // 
            // currentText
            // 
            this.currentText.Location = new System.Drawing.Point(14, 33);
            this.currentText.Name = "currentText";
            this.currentText.ReadOnly = true;
            this.currentText.Size = new System.Drawing.Size(342, 20);
            this.currentText.TabIndex = 7;
            this.currentText.Text = "INSTRUCTIONS: Click Roll Dice to roll the dice.";
            this.currentText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentText.TextChanged += new System.EventHandler(this.currentText_TextChanged);
            // 
            // historyText1
            // 
            this.historyText1.Location = new System.Drawing.Point(14, 59);
            this.historyText1.Name = "historyText1";
            this.historyText1.ReadOnly = true;
            this.historyText1.Size = new System.Drawing.Size(342, 20);
            this.historyText1.TabIndex = 8;
            this.historyText1.Text = "Your goal is to get to 21 without going over.";
            this.historyText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // historyText2
            // 
            this.historyText2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.historyText2.Location = new System.Drawing.Point(14, 85);
            this.historyText2.Name = "historyText2";
            this.historyText2.ReadOnly = true;
            this.historyText2.Size = new System.Drawing.Size(342, 20);
            this.historyText2.TabIndex = 9;
            this.historyText2.Text = "Good luck and have fun!";
            this.historyText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 264);
            this.Controls.Add(this.historyText2);
            this.Controls.Add(this.historyText1);
            this.Controls.Add(this.currentText);
            this.Controls.Add(this.finalDicePic);
            this.Controls.Add(this.dicePic2);
            this.Controls.Add(this.dicePic1);
            this.Controls.Add(this.rollBtn);
            this.Controls.Add(this.diceTwoLbl);
            this.Controls.Add(this.finalDiceLbl);
            this.Controls.Add(this.diceOneLbl);
            this.Name = "Form1";
            this.Text = "Three";
            ((System.ComponentModel.ISupportInitialize)(this.dicePic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDicePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label diceOneLbl;
        private System.Windows.Forms.Label finalDiceLbl;
        private System.Windows.Forms.Label diceTwoLbl;
        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.PictureBox dicePic1;
        private System.Windows.Forms.PictureBox dicePic2;
        private System.Windows.Forms.PictureBox finalDicePic;
        private System.Windows.Forms.TextBox currentText;
        private System.Windows.Forms.TextBox historyText1;
        private System.Windows.Forms.TextBox historyText2;
    }
}

