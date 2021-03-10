namespace ChattBank
{
    partial class CustomerViewAccountsForm
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
            this.accountListBox = new System.Windows.Forms.ListBox();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.depositBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.checkingBtn = new System.Windows.Forms.RadioButton();
            this.savingsBtn = new System.Windows.Forms.RadioButton();
            this.mmaBtn = new System.Windows.Forms.RadioButton();
            this.plsSelectLbl = new System.Windows.Forms.Label();
            this.selectAcctLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accountListBox
            // 
            this.accountListBox.FormattingEnabled = true;
            this.accountListBox.Items.AddRange(new object[] {
            "         <<Your accounts are displayed here>>"});
            this.accountListBox.Location = new System.Drawing.Point(12, 63);
            this.accountListBox.Name = "accountListBox";
            this.accountListBox.Size = new System.Drawing.Size(260, 95);
            this.accountListBox.TabIndex = 0;
            this.accountListBox.SelectedIndexChanged += new System.EventHandler(this.accountListBox_SelectedIndexChanged);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(87, 226);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(109, 23);
            this.logOutBtn.TabIndex = 9;
            this.logOutBtn.Text = "&Log  Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Location = new System.Drawing.Point(12, 13);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(211, 13);
            this.welcomeLbl.TabIndex = 10;
            this.welcomeLbl.Text = "Welcome back to your Chattbank account!\r\n";
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(6, 226);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(75, 23);
            this.depositBtn.TabIndex = 11;
            this.depositBtn.Text = "&Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(202, 226);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(75, 23);
            this.withdrawBtn.TabIndex = 12;
            this.withdrawBtn.Text = "&Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(15, 185);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(134, 23);
            this.createBtn.TabIndex = 13;
            this.createBtn.Text = "&Create a new account";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // checkingBtn
            // 
            this.checkingBtn.AutoSize = true;
            this.checkingBtn.Location = new System.Drawing.Point(157, 168);
            this.checkingBtn.Name = "checkingBtn";
            this.checkingBtn.Size = new System.Drawing.Size(70, 17);
            this.checkingBtn.TabIndex = 14;
            this.checkingBtn.TabStop = true;
            this.checkingBtn.Text = "Checking";
            this.checkingBtn.UseVisualStyleBackColor = true;
            this.checkingBtn.Visible = false;
            this.checkingBtn.CheckedChanged += new System.EventHandler(this.checkingBtn_CheckedChanged);
            // 
            // savingsBtn
            // 
            this.savingsBtn.AutoSize = true;
            this.savingsBtn.Location = new System.Drawing.Point(157, 185);
            this.savingsBtn.Name = "savingsBtn";
            this.savingsBtn.Size = new System.Drawing.Size(63, 17);
            this.savingsBtn.TabIndex = 15;
            this.savingsBtn.TabStop = true;
            this.savingsBtn.Text = "Savings";
            this.savingsBtn.UseVisualStyleBackColor = true;
            this.savingsBtn.Visible = false;
            this.savingsBtn.CheckedChanged += new System.EventHandler(this.savingsBtn_CheckedChanged);
            // 
            // mmaBtn
            // 
            this.mmaBtn.AutoSize = true;
            this.mmaBtn.Location = new System.Drawing.Point(157, 203);
            this.mmaBtn.Name = "mmaBtn";
            this.mmaBtn.Size = new System.Drawing.Size(56, 17);
            this.mmaBtn.TabIndex = 16;
            this.mmaBtn.TabStop = true;
            this.mmaBtn.Text = "M M A";
            this.mmaBtn.UseVisualStyleBackColor = true;
            this.mmaBtn.Visible = false;
            this.mmaBtn.CheckedChanged += new System.EventHandler(this.mmaBtn_CheckedChanged);
            // 
            // plsSelectLbl
            // 
            this.plsSelectLbl.AutoSize = true;
            this.plsSelectLbl.Location = new System.Drawing.Point(12, 26);
            this.plsSelectLbl.Name = "plsSelectLbl";
            this.plsSelectLbl.Size = new System.Drawing.Size(273, 13);
            this.plsSelectLbl.TabIndex = 17;
            this.plsSelectLbl.Text = "Please Select an account to withdraw from or deposit to.";
            // 
            // selectAcctLbl
            // 
            this.selectAcctLbl.AutoSize = true;
            this.selectAcctLbl.Location = new System.Drawing.Point(15, 166);
            this.selectAcctLbl.Name = "selectAcctLbl";
            this.selectAcctLbl.Size = new System.Drawing.Size(140, 26);
            this.selectAcctLbl.TabIndex = 18;
            this.selectAcctLbl.Text = "Select what kind of account\r\nyou want to create\r\n";
            this.selectAcctLbl.Visible = false;
            // 
            // CustomerViewAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.selectAcctLbl);
            this.Controls.Add(this.plsSelectLbl);
            this.Controls.Add(this.mmaBtn);
            this.Controls.Add(this.savingsBtn);
            this.Controls.Add(this.checkingBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.accountListBox);
            this.Name = "CustomerViewAccountsForm";
            this.Text = "Welcome!";
            this.Load += new System.EventHandler(this.CustomerViewAccountsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox accountListBox;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.RadioButton checkingBtn;
        private System.Windows.Forms.RadioButton savingsBtn;
        private System.Windows.Forms.RadioButton mmaBtn;
        private System.Windows.Forms.Label plsSelectLbl;
        private System.Windows.Forms.Label selectAcctLbl;
    }
}