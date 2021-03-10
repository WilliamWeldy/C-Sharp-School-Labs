namespace ChattBank
{
    partial class LoginForm
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
            this.logInBtn = new System.Windows.Forms.Button();
            this.idLbl = new System.Windows.Forms.Label();
            this.pwLbl = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.pwText = new System.Windows.Forms.TextBox();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logInBtn
            // 
            this.logInBtn.Location = new System.Drawing.Point(106, 226);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(75, 23);
            this.logInBtn.TabIndex = 0;
            this.logInBtn.Text = "&Enter";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(57, 119);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(43, 13);
            this.idLbl.TabIndex = 1;
            this.idLbl.Text = "User ID";
            // 
            // pwLbl
            // 
            this.pwLbl.AutoSize = true;
            this.pwLbl.Location = new System.Drawing.Point(47, 155);
            this.pwLbl.Name = "pwLbl";
            this.pwLbl.Size = new System.Drawing.Size(53, 13);
            this.pwLbl.TabIndex = 2;
            this.pwLbl.Text = "Password";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(106, 112);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 20);
            this.idText.TabIndex = 3;
            // 
            // pwText
            // 
            this.pwText.Location = new System.Drawing.Point(106, 152);
            this.pwText.Name = "pwText";
            this.pwText.Size = new System.Drawing.Size(100, 20);
            this.pwText.TabIndex = 4;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.welcomeLbl.Location = new System.Drawing.Point(12, 38);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(257, 26);
            this.welcomeLbl.TabIndex = 5;
            this.welcomeLbl.Text = "Welcome to the Chat Bank Application Login screen!\r\n           Please enter in yo" +
    "ur login credentials.";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.pwText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.pwLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.logInBtn);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label pwLbl;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox pwText;
        private System.Windows.Forms.Label welcomeLbl;
    }
}

