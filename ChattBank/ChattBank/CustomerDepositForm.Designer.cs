namespace ChattBank
{
    partial class CustomerDepositForm
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
            this.depositLbl = new System.Windows.Forms.Label();
            this.successLbl = new System.Windows.Forms.Label();
            this.depositTxt = new System.Windows.Forms.TextBox();
            this.depositBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goBackBtn
            // 
            this.goBackBtn.Location = new System.Drawing.Point(106, 226);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(75, 23);
            this.goBackBtn.TabIndex = 8;
            this.goBackBtn.Text = "< &Back";
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // depositLbl
            // 
            this.depositLbl.AutoSize = true;
            this.depositLbl.Location = new System.Drawing.Point(45, 110);
            this.depositLbl.Name = "depositLbl";
            this.depositLbl.Size = new System.Drawing.Size(43, 13);
            this.depositLbl.TabIndex = 10;
            this.depositLbl.Text = "Deposit";
            // 
            // successLbl
            // 
            this.successLbl.AutoSize = true;
            this.successLbl.Location = new System.Drawing.Point(34, 133);
            this.successLbl.Name = "successLbl";
            this.successLbl.Size = new System.Drawing.Size(211, 13);
            this.successLbl.TabIndex = 11;
            this.successLbl.Text = "(Ammount) was deposited to your (account)";
            this.successLbl.Visible = false;
            // 
            // depositTxt
            // 
            this.depositTxt.Location = new System.Drawing.Point(94, 107);
            this.depositTxt.Name = "depositTxt";
            this.depositTxt.Size = new System.Drawing.Size(100, 20);
            this.depositTxt.TabIndex = 12;
            this.depositTxt.TextChanged += new System.EventHandler(this.depositTxt_TextChanged);
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(106, 160);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(75, 23);
            this.depositBtn.TabIndex = 13;
            this.depositBtn.Text = "&Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // CustomerDepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.depositTxt);
            this.Controls.Add(this.successLbl);
            this.Controls.Add(this.depositLbl);
            this.Controls.Add(this.goBackBtn);
            this.Name = "CustomerDepositForm";
            this.Text = "Deposit to account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.Label depositLbl;
        private System.Windows.Forms.Label successLbl;
        private System.Windows.Forms.TextBox depositTxt;
        private System.Windows.Forms.Button depositBtn;
    }
}