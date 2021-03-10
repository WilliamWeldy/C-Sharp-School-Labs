namespace SimpleCalculator
{
    partial class SimpleCalculator
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
            this.resultText = new System.Windows.Forms.TextBox();
            this.operandLbl = new System.Windows.Forms.Label();
            this.rightText = new System.Windows.Forms.TextBox();
            this.leftText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.RadioButton();
            this.divideButton = new System.Windows.Forms.RadioButton();
            this.multiplyButton = new System.Windows.Forms.RadioButton();
            this.subtractButton = new System.Windows.Forms.RadioButton();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.modulusButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // resultText
            // 
            this.resultText.BackColor = System.Drawing.Color.Black;
            this.resultText.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.resultText.Location = new System.Drawing.Point(13, 38);
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(373, 20);
            this.resultText.TabIndex = 0;
            this.resultText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resultText.TextChanged += new System.EventHandler(this.resultText_TextChanged);
            // 
            // operandLbl
            // 
            this.operandLbl.AutoSize = true;
            this.operandLbl.ForeColor = System.Drawing.Color.Turquoise;
            this.operandLbl.Location = new System.Drawing.Point(193, 15);
            this.operandLbl.Name = "operandLbl";
            this.operandLbl.Size = new System.Drawing.Size(0, 13);
            this.operandLbl.TabIndex = 5;
            this.operandLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightText
            // 
            this.rightText.BackColor = System.Drawing.Color.Black;
            this.rightText.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.rightText.Location = new System.Drawing.Point(219, 12);
            this.rightText.Name = "rightText";
            this.rightText.Size = new System.Drawing.Size(167, 20);
            this.rightText.TabIndex = 4;
            this.rightText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rightText.TextChanged += new System.EventHandler(this.rightText_TextChanged);
            // 
            // leftText
            // 
            this.leftText.BackColor = System.Drawing.Color.Black;
            this.leftText.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.leftText.Location = new System.Drawing.Point(13, 12);
            this.leftText.Name = "leftText";
            this.leftText.Size = new System.Drawing.Size(167, 20);
            this.leftText.TabIndex = 3;
            this.leftText.TextChanged += new System.EventHandler(this.leftText_TextChanged);
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.ForeColor = System.Drawing.Color.Turquoise;
            this.addButton.Location = new System.Drawing.Point(24, 77);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 17);
            this.addButton.TabIndex = 6;
            this.addButton.TabStop = true;
            this.addButton.Text = "Addition";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.CheckedChanged += new System.EventHandler(this.addButton_CheckedChanged);
            // 
            // divideButton
            // 
            this.divideButton.AutoSize = true;
            this.divideButton.ForeColor = System.Drawing.Color.Turquoise;
            this.divideButton.Location = new System.Drawing.Point(24, 146);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(62, 17);
            this.divideButton.TabIndex = 7;
            this.divideButton.TabStop = true;
            this.divideButton.Text = "Division";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.CheckedChanged += new System.EventHandler(this.divideButton_CheckedChanged);
            // 
            // multiplyButton
            // 
            this.multiplyButton.AutoSize = true;
            this.multiplyButton.ForeColor = System.Drawing.Color.Turquoise;
            this.multiplyButton.Location = new System.Drawing.Point(24, 123);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(86, 17);
            this.multiplyButton.TabIndex = 8;
            this.multiplyButton.TabStop = true;
            this.multiplyButton.Text = "Multiplication";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.CheckedChanged += new System.EventHandler(this.multiplyButton_CheckedChanged);
            // 
            // subtractButton
            // 
            this.subtractButton.AutoSize = true;
            this.subtractButton.ForeColor = System.Drawing.Color.Turquoise;
            this.subtractButton.Location = new System.Drawing.Point(24, 100);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(79, 17);
            this.subtractButton.TabIndex = 9;
            this.subtractButton.TabStop = true;
            this.subtractButton.Text = "Subtraction";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.CheckedChanged += new System.EventHandler(this.subtractButton_CheckedChanged);
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.Color.Black;
            this.calcButton.ForeColor = System.Drawing.Color.Aquamarine;
            this.calcButton.Location = new System.Drawing.Point(153, 215);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 40);
            this.calcButton.TabIndex = 10;
            this.calcButton.Text = "&Calculate!";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(12, 286);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Black;
            this.helpButton.Location = new System.Drawing.Point(165, 286);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 13;
            this.helpButton.Text = "&Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(311, 286);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // modulusButton
            // 
            this.modulusButton.AutoSize = true;
            this.modulusButton.ForeColor = System.Drawing.Color.Turquoise;
            this.modulusButton.Location = new System.Drawing.Point(24, 169);
            this.modulusButton.Name = "modulusButton";
            this.modulusButton.Size = new System.Drawing.Size(65, 17);
            this.modulusButton.TabIndex = 15;
            this.modulusButton.TabStop = true;
            this.modulusButton.Text = "Modulus";
            this.modulusButton.UseVisualStyleBackColor = true;
            this.modulusButton.CheckedChanged += new System.EventHandler(this.modulusButton_CheckedChanged);
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(398, 321);
            this.Controls.Add(this.modulusButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.operandLbl);
            this.Controls.Add(this.rightText);
            this.Controls.Add(this.leftText);
            this.Controls.Add(this.resultText);
            this.ForeColor = System.Drawing.Color.Turquoise;
            this.Name = "SimpleCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Label operandLbl;
        private System.Windows.Forms.TextBox rightText;
        private System.Windows.Forms.TextBox leftText;
        private System.Windows.Forms.RadioButton addButton;
        private System.Windows.Forms.RadioButton divideButton;
        private System.Windows.Forms.RadioButton multiplyButton;
        private System.Windows.Forms.RadioButton subtractButton;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton modulusButton;
    }
}

