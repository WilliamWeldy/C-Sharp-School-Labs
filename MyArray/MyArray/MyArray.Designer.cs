namespace MyArray
{
    partial class myArray
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
            this.addButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.arrayTextBox = new System.Windows.Forms.TextBox();
            this.confirmLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 226);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Value";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(95, 225);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(96, 23);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "Display Values";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(197, 225);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // arrayTextBox
            // 
            this.arrayTextBox.Location = new System.Drawing.Point(13, 39);
            this.arrayTextBox.Name = "arrayTextBox";
            this.arrayTextBox.Size = new System.Drawing.Size(259, 20);
            this.arrayTextBox.TabIndex = 3;
            this.arrayTextBox.Text = "Enter Numeric Value Here";
            this.arrayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirmLbl
            // 
            this.confirmLbl.AutoSize = true;
            this.confirmLbl.Location = new System.Drawing.Point(108, 62);
            this.confirmLbl.Name = "confirmLbl";
            this.confirmLbl.Size = new System.Drawing.Size(10, 13);
            this.confirmLbl.TabIndex = 4;
            this.confirmLbl.Text = " ";
            // 
            // myArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.confirmLbl);
            this.Controls.Add(this.arrayTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.addButton);
            this.Name = "myArray";
            this.Text = "My Array";
            this.Load += new System.EventHandler(this.myArray_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox arrayTextBox;
        private System.Windows.Forms.Label confirmLbl;
    }
}

