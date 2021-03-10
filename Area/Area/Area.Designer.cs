namespace Area
{
    partial class areaForm
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
            this.radiusLbl = new System.Windows.Forms.Label();
            this.widthLbl = new System.Windows.Forms.Label();
            this.areaLbl = new System.Windows.Forms.Label();
            this.circButton = new System.Windows.Forms.RadioButton();
            this.squareButton = new System.Windows.Forms.RadioButton();
            this.rectButton = new System.Windows.Forms.RadioButton();
            this.calcBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.mainText = new System.Windows.Forms.TextBox();
            this.widthText = new System.Windows.Forms.TextBox();
            this.areaText = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(126, 27);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(29, 13);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Area";
            this.titleLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // radiusLbl
            // 
            this.radiusLbl.AutoSize = true;
            this.radiusLbl.Location = new System.Drawing.Point(48, 47);
            this.radiusLbl.Name = "radiusLbl";
            this.radiusLbl.Size = new System.Drawing.Size(46, 13);
            this.radiusLbl.TabIndex = 1;
            this.radiusLbl.Text = "Radius: ";
            this.radiusLbl.Click += new System.EventHandler(this.radiusLbl_Click);
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(48, 77);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(41, 13);
            this.widthLbl.TabIndex = 2;
            this.widthLbl.Text = "Width: ";
            // 
            // areaLbl
            // 
            this.areaLbl.AutoSize = true;
            this.areaLbl.Location = new System.Drawing.Point(48, 103);
            this.areaLbl.Name = "areaLbl";
            this.areaLbl.Size = new System.Drawing.Size(35, 13);
            this.areaLbl.TabIndex = 3;
            this.areaLbl.Text = "Area: ";
            // 
            // circButton
            // 
            this.circButton.AutoSize = true;
            this.circButton.Location = new System.Drawing.Point(54, 20);
            this.circButton.Name = "circButton";
            this.circButton.Size = new System.Drawing.Size(51, 17);
            this.circButton.TabIndex = 4;
            this.circButton.TabStop = true;
            this.circButton.Text = "Circle";
            this.circButton.UseVisualStyleBackColor = true;
            this.circButton.CheckedChanged += new System.EventHandler(this.circButton_CheckedChanged);
            // 
            // squareButton
            // 
            this.squareButton.AutoSize = true;
            this.squareButton.Location = new System.Drawing.Point(54, 43);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(59, 17);
            this.squareButton.TabIndex = 5;
            this.squareButton.TabStop = true;
            this.squareButton.Text = "Square";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.CheckedChanged += new System.EventHandler(this.squareButton_CheckedChanged);
            // 
            // rectButton
            // 
            this.rectButton.AutoSize = true;
            this.rectButton.Location = new System.Drawing.Point(54, 66);
            this.rectButton.Name = "rectButton";
            this.rectButton.Size = new System.Drawing.Size(74, 17);
            this.rectButton.TabIndex = 6;
            this.rectButton.TabStop = true;
            this.rectButton.Text = "Rectangle";
            this.rectButton.UseVisualStyleBackColor = true;
            this.rectButton.CheckedChanged += new System.EventHandler(this.rectButton_CheckedChanged);
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(22, 226);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 7;
            this.calcBtn.Text = "Calc Area";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click_1);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(104, 226);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click_1);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(186, 226);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // mainText
            // 
            this.mainText.Location = new System.Drawing.Point(95, 44);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(100, 20);
            this.mainText.TabIndex = 10;
            // 
            // widthText
            // 
            this.widthText.Location = new System.Drawing.Point(95, 74);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(100, 20);
            this.widthText.TabIndex = 11;
            // 
            // areaText
            // 
            this.areaText.Location = new System.Drawing.Point(95, 100);
            this.areaText.Name = "areaText";
            this.areaText.Size = new System.Drawing.Size(100, 20);
            this.areaText.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.choiceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // choiceToolStripMenuItem
            // 
            this.choiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circleToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.rectangleToolStripMenuItem});
            this.choiceToolStripMenuItem.Name = "choiceToolStripMenuItem";
            this.choiceToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.choiceToolStripMenuItem.Text = "Choice";
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.squareButton);
            this.groupBox.Controls.Add(this.circButton);
            this.groupBox.Controls.Add(this.rectButton);
            this.groupBox.Location = new System.Drawing.Point(42, 126);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 100);
            this.groupBox.TabIndex = 14;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Selection Of Shapes";
            // 
            // areaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.areaText);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.areaLbl);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.radiusLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "areaForm";
            this.Text = "Area";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label radiusLbl;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label areaLbl;
        private System.Windows.Forms.RadioButton circButton;
        private System.Windows.Forms.RadioButton squareButton;
        private System.Windows.Forms.RadioButton rectButton;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox mainText;
        private System.Windows.Forms.TextBox widthText;
        private System.Windows.Forms.TextBox areaText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox;
    }
}

