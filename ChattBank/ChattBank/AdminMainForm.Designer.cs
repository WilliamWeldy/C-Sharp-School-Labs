namespace ChattBank
{
    partial class AdminMainForm
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
            this.mainToTestformBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainToTestformBtn
            // 
            this.mainToTestformBtn.Location = new System.Drawing.Point(80, 109);
            this.mainToTestformBtn.Name = "mainToTestformBtn";
            this.mainToTestformBtn.Size = new System.Drawing.Size(134, 23);
            this.mainToTestformBtn.TabIndex = 9;
            this.mainToTestformBtn.Text = "&TestNameSpace Classes";
            this.mainToTestformBtn.UseVisualStyleBackColor = true;
            this.mainToTestformBtn.Click += new System.EventHandler(this.mainToTestformBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(90, 226);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(109, 23);
            this.logOutBtn.TabIndex = 10;
            this.logOutBtn.Text = "&Log  Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(75, 63);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(139, 23);
            this.createBtn.TabIndex = 11;
            this.createBtn.Text = "&Create Customer account";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(75, 158);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(139, 23);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "&Delete Customer account";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Location = new System.Drawing.Point(77, 24);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(117, 13);
            this.welcomeLbl.TabIndex = 13;
            this.welcomeLbl.Text = "Welcome Back  admin!";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.mainToTestformBtn);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mainToTestformBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label welcomeLbl;
    }
}