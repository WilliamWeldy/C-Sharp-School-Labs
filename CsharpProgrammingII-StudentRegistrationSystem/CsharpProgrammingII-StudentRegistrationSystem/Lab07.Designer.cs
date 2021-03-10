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
            this.courseButton = new System.Windows.Forms.Button();
            this.sectionButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.instructorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseButton
            // 
            this.courseButton.Location = new System.Drawing.Point(40, 38);
            this.courseButton.Name = "courseButton";
            this.courseButton.Size = new System.Drawing.Size(75, 23);
            this.courseButton.TabIndex = 0;
            this.courseButton.Text = "Course";
            this.courseButton.UseVisualStyleBackColor = true;
            this.courseButton.Click += new System.EventHandler(this.courseButton_Click);
            // 
            // sectionButton
            // 
            this.sectionButton.Location = new System.Drawing.Point(40, 78);
            this.sectionButton.Name = "sectionButton";
            this.sectionButton.Size = new System.Drawing.Size(75, 23);
            this.sectionButton.TabIndex = 1;
            this.sectionButton.Text = "Section";
            this.sectionButton.UseVisualStyleBackColor = true;
            this.sectionButton.Click += new System.EventHandler(this.sectionButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.Location = new System.Drawing.Point(40, 137);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(75, 23);
            this.studentButton.TabIndex = 2;
            this.studentButton.Text = "Student";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // instructorButton
            // 
            this.instructorButton.Location = new System.Drawing.Point(40, 175);
            this.instructorButton.Name = "instructorButton";
            this.instructorButton.Size = new System.Drawing.Size(75, 23);
            this.instructorButton.TabIndex = 3;
            this.instructorButton.Text = "Instructor";
            this.instructorButton.UseVisualStyleBackColor = true;
            this.instructorButton.Click += new System.EventHandler(this.instructorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.instructorButton);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.sectionButton);
            this.Controls.Add(this.courseButton);
            this.Name = "Form1";
            this.Text = "Lab 5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button courseButton;
        private System.Windows.Forms.Button sectionButton;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button instructorButton;
    }
}

