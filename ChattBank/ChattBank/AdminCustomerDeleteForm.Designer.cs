namespace ChattBank
{
    partial class AdminCustomerDeleteForm
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.custIDLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goBackBtn
            // 
            this.goBackBtn.Location = new System.Drawing.Point(104, 226);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(75, 23);
            this.goBackBtn.TabIndex = 10;
            this.goBackBtn.Text = "< &Back";
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(104, 144);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 23;
            this.deleteBtn.Text = "&DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(73, 118);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(134, 20);
            this.idTxt.TabIndex = 24;
            // 
            // custIDLbl
            // 
            this.custIDLbl.AutoSize = true;
            this.custIDLbl.Location = new System.Drawing.Point(2, 121);
            this.custIDLbl.Name = "custIDLbl";
            this.custIDLbl.Size = new System.Drawing.Size(65, 13);
            this.custIDLbl.TabIndex = 25;
            this.custIDLbl.Text = "Customer ID";
            // 
            // AdminCustomerDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.custIDLbl);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.goBackBtn);
            this.Name = "AdminCustomerDeleteForm";
            this.Text = "Customer  Deletion  Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label custIDLbl;
    }
}