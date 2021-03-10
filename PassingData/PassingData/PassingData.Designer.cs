namespace PassingData
{
    partial class PassingData
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
            this.num2Lbl = new System.Windows.Forms.Label();
            this.num3Lbl = new System.Windows.Forms.Label();
            this.num1Lbl = new System.Windows.Forms.Label();
            this.answerLbl = new System.Windows.Forms.Label();
            this.num1Text = new System.Windows.Forms.TextBox();
            this.num2Text = new System.Windows.Forms.TextBox();
            this.num3Text = new System.Windows.Forms.TextBox();
            this.answerText = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.globalButton = new System.Windows.Forms.Button();
            this.refButton = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num2Lbl
            // 
            this.num2Lbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.num2Lbl.AutoSize = true;
            this.num2Lbl.Location = new System.Drawing.Point(62, 81);
            this.num2Lbl.Name = "num2Lbl";
            this.num2Lbl.Size = new System.Drawing.Size(35, 13);
            this.num2Lbl.TabIndex = 1;
            this.num2Lbl.Text = "Num2";
            // 
            // num3Lbl
            // 
            this.num3Lbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.num3Lbl.AutoSize = true;
            this.num3Lbl.Location = new System.Drawing.Point(62, 107);
            this.num3Lbl.Name = "num3Lbl";
            this.num3Lbl.Size = new System.Drawing.Size(35, 13);
            this.num3Lbl.TabIndex = 2;
            this.num3Lbl.Text = "Num3";
            // 
            // num1Lbl
            // 
            this.num1Lbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.num1Lbl.AutoSize = true;
            this.num1Lbl.Location = new System.Drawing.Point(62, 55);
            this.num1Lbl.Name = "num1Lbl";
            this.num1Lbl.Size = new System.Drawing.Size(35, 13);
            this.num1Lbl.TabIndex = 3;
            this.num1Lbl.Text = "Num1";
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.Location = new System.Drawing.Point(55, 133);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(42, 13);
            this.answerLbl.TabIndex = 4;
            this.answerLbl.Text = "Answer";
            // 
            // num1Text
            // 
            this.num1Text.Location = new System.Drawing.Point(103, 52);
            this.num1Text.Name = "num1Text";
            this.num1Text.Size = new System.Drawing.Size(100, 20);
            this.num1Text.TabIndex = 5;
            // 
            // num2Text
            // 
            this.num2Text.Location = new System.Drawing.Point(103, 78);
            this.num2Text.Name = "num2Text";
            this.num2Text.Size = new System.Drawing.Size(100, 20);
            this.num2Text.TabIndex = 6;
            // 
            // num3Text
            // 
            this.num3Text.Location = new System.Drawing.Point(103, 104);
            this.num3Text.Name = "num3Text";
            this.num3Text.Size = new System.Drawing.Size(100, 20);
            this.num3Text.TabIndex = 7;
            // 
            // answerText
            // 
            this.answerText.Location = new System.Drawing.Point(103, 130);
            this.answerText.Name = "answerText";
            this.answerText.ReadOnly = true;
            this.answerText.Size = new System.Drawing.Size(100, 20);
            this.answerText.TabIndex = 8;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(103, 167);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(91, 23);
            this.returnButton.TabIndex = 9;
            this.returnButton.Text = "Return Value";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // globalButton
            // 
            this.globalButton.Location = new System.Drawing.Point(112, 196);
            this.globalButton.Name = "globalButton";
            this.globalButton.Size = new System.Drawing.Size(75, 23);
            this.globalButton.TabIndex = 10;
            this.globalButton.Text = "Global Data";
            this.globalButton.UseVisualStyleBackColor = true;
            this.globalButton.Click += new System.EventHandler(this.globalButton_Click);
            // 
            // refButton
            // 
            this.refButton.Location = new System.Drawing.Point(92, 225);
            this.refButton.Name = "refButton";
            this.refButton.Size = new System.Drawing.Size(111, 23);
            this.refButton.TabIndex = 11;
            this.refButton.Text = "Pass-By-Reference";
            this.refButton.UseVisualStyleBackColor = true;
            this.refButton.Click += new System.EventHandler(this.refButton_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(73, 19);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(156, 13);
            this.titleLbl.TabIndex = 12;
            this.titleLbl.Text = "Find the Maximum of 3 numbers";
            // 
            // PassingData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.refButton);
            this.Controls.Add(this.globalButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.answerText);
            this.Controls.Add(this.num3Text);
            this.Controls.Add(this.num2Text);
            this.Controls.Add(this.num1Text);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.num1Lbl);
            this.Controls.Add(this.num3Lbl);
            this.Controls.Add(this.num2Lbl);
            this.Name = "PassingData";
            this.Text = "PassingData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label num2Lbl;
        private System.Windows.Forms.Label num3Lbl;
        private System.Windows.Forms.Label num1Lbl;
        private System.Windows.Forms.Label answerLbl;
        private System.Windows.Forms.TextBox num1Text;
        private System.Windows.Forms.TextBox num2Text;
        private System.Windows.Forms.TextBox num3Text;
        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button globalButton;
        private System.Windows.Forms.Button refButton;
        private System.Windows.Forms.Label titleLbl;
    }
}

