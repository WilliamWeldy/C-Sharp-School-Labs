namespace Student
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.majorLbl = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.majorText = new System.Windows.Forms.TextBox();
            this.displayBtn = new System.Windows.Forms.Button();
            this.fillBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.gpaText = new System.Windows.Forms.TextBox();
            this.gpaLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(51, 45);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(35, 13);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(68, 70);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(18, 13);
            this.idLbl.TabIndex = 1;
            this.idLbl.Text = "ID";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(8, 93);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(78, 13);
            this.phoneLbl.TabIndex = 2;
            this.phoneLbl.Text = "Phone Number";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(15, 119);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(71, 13);
            this.emailLbl.TabIndex = 3;
            this.emailLbl.Text = "E-Mail Adress";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(41, 145);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(45, 13);
            this.addressLbl.TabIndex = 4;
            this.addressLbl.Text = "Address";
            // 
            // majorLbl
            // 
            this.majorLbl.AutoSize = true;
            this.majorLbl.Location = new System.Drawing.Point(53, 171);
            this.majorLbl.Name = "majorLbl";
            this.majorLbl.Size = new System.Drawing.Size(33, 13);
            this.majorLbl.TabIndex = 5;
            this.majorLbl.Text = "Major";
            this.majorLbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(92, 42);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 6;
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(92, 67);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 20);
            this.idText.TabIndex = 7;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(92, 90);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(100, 20);
            this.phoneText.TabIndex = 8;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(92, 142);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(100, 20);
            this.addressText.TabIndex = 9;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(92, 116);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(100, 20);
            this.emailText.TabIndex = 10;
            // 
            // majorText
            // 
            this.majorText.Location = new System.Drawing.Point(92, 168);
            this.majorText.Name = "majorText";
            this.majorText.Size = new System.Drawing.Size(100, 20);
            this.majorText.TabIndex = 11;
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(12, 226);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(75, 23);
            this.displayBtn.TabIndex = 12;
            this.displayBtn.Tag = "";
            this.displayBtn.Text = "&Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // fillBtn
            // 
            this.fillBtn.Location = new System.Drawing.Point(103, 226);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(75, 23);
            this.fillBtn.TabIndex = 13;
            this.fillBtn.Text = "&Fill";
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(197, 226);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 14;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // gpaText
            // 
            this.gpaText.Location = new System.Drawing.Point(92, 194);
            this.gpaText.Name = "gpaText";
            this.gpaText.Size = new System.Drawing.Size(100, 20);
            this.gpaText.TabIndex = 16;
            // 
            // gpaLbl
            // 
            this.gpaLbl.AutoSize = true;
            this.gpaLbl.Location = new System.Drawing.Point(53, 197);
            this.gpaLbl.Name = "gpaLbl";
            this.gpaLbl.Size = new System.Drawing.Size(29, 13);
            this.gpaLbl.TabIndex = 15;
            this.gpaLbl.Text = "GPA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gpaText);
            this.Controls.Add(this.gpaLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.fillBtn);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.majorText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.majorLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label majorLbl;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox majorText;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox gpaText;
        private System.Windows.Forms.Label gpaLbl;
    }
}

