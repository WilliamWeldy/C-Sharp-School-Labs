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
            this.addressButton = new System.Windows.Forms.Button();
            this.courseButton = new System.Windows.Forms.Button();
            this.sectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addressButton
            // 
            this.addressButton.Location = new System.Drawing.Point(39, 52);
            this.addressButton.Name = "addressButton";
            this.addressButton.Size = new System.Drawing.Size(77, 23);
            this.addressButton.TabIndex = 0;
            this.addressButton.Text = "Test Address";
            this.addressButton.UseVisualStyleBackColor = true;
            this.addressButton.Click += new System.EventHandler(this.addressButton_Click);
            // 
            // courseButton
            // 
            this.courseButton.Location = new System.Drawing.Point(39, 97);
            this.courseButton.Name = "courseButton";
            this.courseButton.Size = new System.Drawing.Size(75, 23);
            this.courseButton.TabIndex = 1;
            this.courseButton.Text = "Test Course";
            this.courseButton.UseVisualStyleBackColor = true;
            this.courseButton.Click += new System.EventHandler(this.courseButton_Click);
            // 
            // sectionButton
            // 
            this.sectionButton.Location = new System.Drawing.Point(39, 145);
            this.sectionButton.Name = "sectionButton";
            this.sectionButton.Size = new System.Drawing.Size(75, 23);
            this.sectionButton.TabIndex = 2;
            this.sectionButton.Text = "Test Section";
            this.sectionButton.UseVisualStyleBackColor = true;
            this.sectionButton.Click += new System.EventHandler(this.sectionButton_Click);
            // 
            // Lab02Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sectionButton);
            this.Controls.Add(this.courseButton);
            this.Controls.Add(this.addressButton);
            this.Name = "Lab02Form";
            this.Text = "Lab 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addressButton;
        private System.Windows.Forms.Button courseButton;
        private System.Windows.Forms.Button sectionButton;
    }
}

