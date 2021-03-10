namespace ChattBank
{
    partial class AdminTestClassesForm
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
            this.goBackBtn = new System.Windows.Forms.Button();
            this.testLbl = new System.Windows.Forms.Label();
            this.personBtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.acctBtn = new System.Windows.Forms.Button();
            this.addressBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goBackBtn
            // 
            this.goBackBtn.Location = new System.Drawing.Point(12, 226);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(75, 23);
            this.goBackBtn.TabIndex = 0;
            this.goBackBtn.Text = "< &Back";
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // testLbl
            // 
            this.testLbl.AutoSize = true;
            this.testLbl.Location = new System.Drawing.Point(209, 9);
            this.testLbl.Name = "testLbl";
            this.testLbl.Size = new System.Drawing.Size(44, 13);
            this.testLbl.TabIndex = 1;
            this.testLbl.Text = "T E S T";
            // 
            // personBtn
            // 
            this.personBtn.Location = new System.Drawing.Point(181, 36);
            this.personBtn.Name = "personBtn";
            this.personBtn.Size = new System.Drawing.Size(81, 23);
            this.personBtn.TabIndex = 2;
            this.personBtn.Text = "Person Class";
            this.personBtn.UseVisualStyleBackColor = true;
            this.personBtn.Click += new System.EventHandler(this.personBtn_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(187, 65);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(75, 23);
            this.adminBtn.TabIndex = 3;
            this.adminBtn.Text = "Admin Class";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.Location = new System.Drawing.Point(174, 94);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(88, 23);
            this.customerBtn.TabIndex = 4;
            this.customerBtn.Text = "Customer Class";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // acctBtn
            // 
            this.acctBtn.Location = new System.Drawing.Point(132, 123);
            this.acctBtn.Name = "acctBtn";
            this.acctBtn.Size = new System.Drawing.Size(130, 23);
            this.acctBtn.TabIndex = 5;
            this.acctBtn.Text = "Customer Account Class";
            this.acctBtn.UseVisualStyleBackColor = true;
            this.acctBtn.Click += new System.EventHandler(this.acctBtn_Click);
            // 
            // addressBtn
            // 
            this.addressBtn.Location = new System.Drawing.Point(132, 152);
            this.addressBtn.Name = "addressBtn";
            this.addressBtn.Size = new System.Drawing.Size(130, 23);
            this.addressBtn.TabIndex = 6;
            this.addressBtn.Text = "Person\'s Address Class";
            this.addressBtn.UseVisualStyleBackColor = true;
            this.addressBtn.Click += new System.EventHandler(this.addressBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(187, 226);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(75, 23);
            this.logOutBtn.TabIndex = 7;
            this.logOutBtn.Text = "&Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // AdminTestClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.addressBtn);
            this.Controls.Add(this.acctBtn);
            this.Controls.Add(this.customerBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.personBtn);
            this.Controls.Add(this.testLbl);
            this.Controls.Add(this.goBackBtn);
            this.Name = "AdminTestClassesForm";
            this.Text = "AdminTestClassesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.Label testLbl;
        private System.Windows.Forms.Button personBtn;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button acctBtn;
        private System.Windows.Forms.Button addressBtn;
        private System.Windows.Forms.Button logOutBtn;
    }
}