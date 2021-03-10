namespace Convert
{
    partial class convertForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.fahrLbl = new System.Windows.Forms.Label();
            this.celciusLbl = new System.Windows.Forms.Label();
            this.fahrText = new System.Windows.Forms.TextBox();
            this.celciusText = new System.Windows.Forms.TextBox();
            this.fahrToCelciusBtn = new System.Windows.Forms.RadioButton();
            this.celciusToFahrBtn = new System.Windows.Forms.RadioButton();
            this.convertBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(111, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(44, 13);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Convert";
            // 
            // fahrLbl
            // 
            this.fahrLbl.AutoSize = true;
            this.fahrLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fahrLbl.Location = new System.Drawing.Point(51, 66);
            this.fahrLbl.Name = "fahrLbl";
            this.fahrLbl.Size = new System.Drawing.Size(57, 13);
            this.fahrLbl.TabIndex = 1;
            this.fahrLbl.Text = "Fahrenheit";
            // 
            // celciusLbl
            // 
            this.celciusLbl.AutoSize = true;
            this.celciusLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.celciusLbl.Location = new System.Drawing.Point(67, 94);
            this.celciusLbl.Name = "celciusLbl";
            this.celciusLbl.Size = new System.Drawing.Size(41, 13);
            this.celciusLbl.TabIndex = 2;
            this.celciusLbl.Text = "Celcius";
            // 
            // fahrText
            // 
            this.fahrText.Location = new System.Drawing.Point(114, 63);
            this.fahrText.Name = "fahrText";
            this.fahrText.Size = new System.Drawing.Size(100, 20);
            this.fahrText.TabIndex = 3;
            // 
            // celciusText
            // 
            this.celciusText.Location = new System.Drawing.Point(114, 94);
            this.celciusText.Name = "celciusText";
            this.celciusText.Size = new System.Drawing.Size(100, 20);
            this.celciusText.TabIndex = 4;
            // 
            // fahrToCelciusBtn
            // 
            this.fahrToCelciusBtn.AutoSize = true;
            this.fahrToCelciusBtn.Location = new System.Drawing.Point(70, 139);
            this.fahrToCelciusBtn.Name = "fahrToCelciusBtn";
            this.fahrToCelciusBtn.Size = new System.Drawing.Size(128, 17);
            this.fahrToCelciusBtn.TabIndex = 5;
            this.fahrToCelciusBtn.TabStop = true;
            this.fahrToCelciusBtn.Text = "Fahrenheit To Celcius";
            this.fahrToCelciusBtn.UseVisualStyleBackColor = true;
            this.fahrToCelciusBtn.CheckedChanged += new System.EventHandler(this.fahrToCelciusBtn_CheckedChanged);
            // 
            // celciusToFahrBtn
            // 
            this.celciusToFahrBtn.AutoSize = true;
            this.celciusToFahrBtn.Location = new System.Drawing.Point(70, 163);
            this.celciusToFahrBtn.Name = "celciusToFahrBtn";
            this.celciusToFahrBtn.Size = new System.Drawing.Size(128, 17);
            this.celciusToFahrBtn.TabIndex = 6;
            this.celciusToFahrBtn.TabStop = true;
            this.celciusToFahrBtn.Text = "Celcius To Fahrenheit";
            this.celciusToFahrBtn.UseVisualStyleBackColor = true;
            this.celciusToFahrBtn.CheckedChanged += new System.EventHandler(this.celciusToFahrBtn_CheckedChanged);
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(13, 226);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(75, 23);
            this.convertBtn.TabIndex = 7;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(104, 226);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(197, 226);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // convertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.celciusToFahrBtn);
            this.Controls.Add(this.fahrToCelciusBtn);
            this.Controls.Add(this.celciusText);
            this.Controls.Add(this.fahrText);
            this.Controls.Add(this.celciusLbl);
            this.Controls.Add(this.fahrLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "convertForm";
            this.Text = "Convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label fahrLbl;
        private System.Windows.Forms.Label celciusLbl;
        private System.Windows.Forms.TextBox fahrText;
        private System.Windows.Forms.TextBox celciusText;
        private System.Windows.Forms.RadioButton fahrToCelciusBtn;
        private System.Windows.Forms.RadioButton celciusToFahrBtn;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

