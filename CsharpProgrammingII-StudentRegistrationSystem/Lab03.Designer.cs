namespace CsharpProgrammingII_StudentRegistrationSystem
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
            this.personButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.InstructorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personButton
            // 
            this.personButton.Location = new System.Drawing.Point(47, 69);
            this.personButton.Name = "personButton";
            this.personButton.Size = new System.Drawing.Size(160, 23);
            this.personButton.TabIndex = 0;
            this.personButton.Text = "Testing Person Superclass";
            this.personButton.UseVisualStyleBackColor = true;
            this.personButton.Click += new System.EventHandler(this.personButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.Location = new System.Drawing.Point(47, 116);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(123, 23);
            this.studentButton.TabIndex = 1;
            this.studentButton.Text = "Testing Student class";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // InstructorButton
            // 
            this.InstructorButton.Location = new System.Drawing.Point(47, 161);
            this.InstructorButton.Name = "InstructorButton";
            this.InstructorButton.Size = new System.Drawing.Size(133, 23);
            this.InstructorButton.TabIndex = 2;
            this.InstructorButton.Text = "Testing Instructor class";
            this.InstructorButton.UseVisualStyleBackColor = true;
            this.InstructorButton.Click += new System.EventHandler(this.InstructorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.InstructorButton);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.personButton);
            this.Name = "Form1";
            this.Text = "Lab 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personButton;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button InstructorButton;
    }
}

