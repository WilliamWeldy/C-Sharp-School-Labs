namespace ChattBank
{
    partial class CustomerWithdrawForm
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
            this.withdrawTxt = new System.Windows.Forms.TextBox();
            this.successLbl = new System.Windows.Forms.Label();
            this.withdrawLbl = new System.Windows.Forms.Label();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goBackBtn
            // 
            this.goBackBtn.Location = new System.Drawing.Point(105, 226);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(75, 23);
            this.goBackBtn.TabIndex = 8;
            this.goBackBtn.Text = "< &Back";
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // withdrawTxt
            // 
            this.withdrawTxt.Location = new System.Drawing.Point(95, 109);
            this.withdrawTxt.Name = "withdrawTxt";
            this.withdrawTxt.Size = new System.Drawing.Size(100, 20);
            this.withdrawTxt.TabIndex = 15;
            this.withdrawTxt.TextChanged += new System.EventHandler(this.withdrawTxt_TextChanged);
            // 
            // successLbl
            // 
            this.successLbl.AutoSize = true;
            this.successLbl.Location = new System.Drawing.Point(12, 135);
            this.successLbl.Name = "successLbl";
            this.successLbl.Size = new System.Drawing.Size(269, 13);
            this.successLbl.TabIndex = 14;
            this.successLbl.Text = "(Ammount) was withdrawn from your (account) account.";
            this.successLbl.Visible = false;
            // 
            // withdrawLbl
            // 
            this.withdrawLbl.AutoSize = true;
            this.withdrawLbl.Location = new System.Drawing.Point(37, 112);
            this.withdrawLbl.Name = "withdrawLbl";
            this.withdrawLbl.Size = new System.Drawing.Size(52, 13);
            this.withdrawLbl.TabIndex = 13;
            this.withdrawLbl.Text = "Withdraw";
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(105, 165);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(75, 23);
            this.withdrawBtn.TabIndex = 16;
            this.withdrawBtn.Text = "&Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // CustomerWithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.withdrawTxt);
            this.Controls.Add(this.successLbl);
            this.Controls.Add(this.withdrawLbl);
            this.Controls.Add(this.goBackBtn);
            this.Name = "CustomerWithdrawForm";
            this.Text = "Withdraw from account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.TextBox withdrawTxt;
        private System.Windows.Forms.Label successLbl;
        private System.Windows.Forms.Label withdrawLbl;
        private System.Windows.Forms.Button withdrawBtn;
    }
}