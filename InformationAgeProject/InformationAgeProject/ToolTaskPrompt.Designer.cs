namespace InformationAgeProject
{
    partial class ToolTaskPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolTaskPrompt));
            this.toolsPictureBox = new System.Windows.Forms.PictureBox();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblBacklog = new System.Windows.Forms.Label();
            this.backlogListBox = new System.Windows.Forms.ListBox();
            this.toolListBox = new System.Windows.Forms.ListBox();
            this.lowListBox = new System.Windows.Forms.ListBox();
            this.medListBox = new System.Windows.Forms.ListBox();
            this.highListBox = new System.Windows.Forms.ListBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.backlogTextBox = new System.Windows.Forms.TextBox();
            this.lowTextBox = new System.Windows.Forms.TextBox();
            this.medTextBox = new System.Windows.Forms.TextBox();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.diceImage1 = new System.Windows.Forms.PictureBox();
            this.diceImage2 = new System.Windows.Forms.PictureBox();
            this.diceImage3 = new System.Windows.Forms.PictureBox();
            this.diceImage4 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toolsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceImage4)).BeginInit();
            this.SuspendLayout();
            // 
            // toolsPictureBox
            // 
            this.toolsPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("toolsPictureBox.Image")));
            this.toolsPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("toolsPictureBox.InitialImage")));
            this.toolsPictureBox.Location = new System.Drawing.Point(182, 166);
            this.toolsPictureBox.Name = "toolsPictureBox";
            this.toolsPictureBox.Size = new System.Drawing.Size(51, 48);
            this.toolsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toolsPictureBox.TabIndex = 62;
            this.toolsPictureBox.TabStop = false;
            // 
            // lblHigh
            // 
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.ForeColor = System.Drawing.Color.Red;
            this.lblHigh.Location = new System.Drawing.Point(409, 9);
            this.lblHigh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(100, 28);
            this.lblHigh.TabIndex = 66;
            this.lblHigh.Text = "High-Priority Tasks";
            // 
            // lblMedium
            // 
            this.lblMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedium.ForeColor = System.Drawing.Color.Gold;
            this.lblMedium.Location = new System.Drawing.Point(294, 9);
            this.lblMedium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(100, 28);
            this.lblMedium.TabIndex = 65;
            this.lblMedium.Text = "Medium-Priority Tasks";
            // 
            // lblLow
            // 
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.ForeColor = System.Drawing.Color.Green;
            this.lblLow.Location = new System.Drawing.Point(179, 9);
            this.lblLow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(100, 28);
            this.lblLow.TabIndex = 64;
            this.lblLow.Text = "Low-Priority Tasks";
            // 
            // lblBacklog
            // 
            this.lblBacklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacklog.ForeColor = System.Drawing.Color.Blue;
            this.lblBacklog.Location = new System.Drawing.Point(66, 9);
            this.lblBacklog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBacklog.Name = "lblBacklog";
            this.lblBacklog.Size = new System.Drawing.Size(80, 28);
            this.lblBacklog.TabIndex = 63;
            this.lblBacklog.Text = "Backlog Tasks";
            // 
            // backlogListBox
            // 
            this.backlogListBox.AllowDrop = true;
            this.backlogListBox.BackColor = System.Drawing.Color.White;
            this.backlogListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlogListBox.FormattingEnabled = true;
            this.backlogListBox.ItemHeight = 20;
            this.backlogListBox.Location = new System.Drawing.Point(67, 69);
            this.backlogListBox.Name = "backlogListBox";
            this.backlogListBox.Size = new System.Drawing.Size(109, 84);
            this.backlogListBox.TabIndex = 67;
            this.backlogListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.universalListBox_DragEnter);
            this.backlogListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.universalListBox_DragOver);
            this.backlogListBox.DragLeave += new System.EventHandler(this.universalListBox_DragLeave);
            this.backlogListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.universalListBox_MouseDown);
            // 
            // toolListBox
            // 
            this.toolListBox.AllowDrop = true;
            this.toolListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolListBox.BackColor = System.Drawing.Color.White;
            this.toolListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolListBox.FormattingEnabled = true;
            this.toolListBox.ItemHeight = 20;
            this.toolListBox.Location = new System.Drawing.Point(239, 166);
            this.toolListBox.Name = "toolListBox";
            this.toolListBox.Size = new System.Drawing.Size(111, 64);
            this.toolListBox.TabIndex = 68;
            this.toolListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.universalListBox_DragEnter);
            this.toolListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.universalListBox_DragOver);
            this.toolListBox.DragLeave += new System.EventHandler(this.universalListBox_DragLeave);
            this.toolListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.universalListBox_MouseDown);
            // 
            // lowListBox
            // 
            this.lowListBox.AllowDrop = true;
            this.lowListBox.BackColor = System.Drawing.Color.White;
            this.lowListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowListBox.FormattingEnabled = true;
            this.lowListBox.ItemHeight = 20;
            this.lowListBox.Location = new System.Drawing.Point(182, 69);
            this.lowListBox.Name = "lowListBox";
            this.lowListBox.Size = new System.Drawing.Size(109, 84);
            this.lowListBox.TabIndex = 69;
            this.lowListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.universalListBox_DragEnter);
            this.lowListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.universalListBox_DragOver);
            this.lowListBox.DragLeave += new System.EventHandler(this.universalListBox_DragLeave);
            this.lowListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.universalListBox_MouseDown);
            // 
            // medListBox
            // 
            this.medListBox.AllowDrop = true;
            this.medListBox.BackColor = System.Drawing.Color.White;
            this.medListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medListBox.FormattingEnabled = true;
            this.medListBox.ItemHeight = 20;
            this.medListBox.Location = new System.Drawing.Point(297, 69);
            this.medListBox.Name = "medListBox";
            this.medListBox.Size = new System.Drawing.Size(109, 84);
            this.medListBox.TabIndex = 70;
            this.medListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.universalListBox_DragEnter);
            this.medListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.universalListBox_DragOver);
            this.medListBox.DragLeave += new System.EventHandler(this.universalListBox_DragLeave);
            this.medListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.universalListBox_MouseDown);
            // 
            // highListBox
            // 
            this.highListBox.AllowDrop = true;
            this.highListBox.BackColor = System.Drawing.Color.White;
            this.highListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highListBox.FormattingEnabled = true;
            this.highListBox.ItemHeight = 20;
            this.highListBox.Location = new System.Drawing.Point(412, 69);
            this.highListBox.Name = "highListBox";
            this.highListBox.Size = new System.Drawing.Size(109, 84);
            this.highListBox.TabIndex = 71;
            this.highListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.universalListBox_DragEnter);
            this.highListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.universalListBox_DragOver);
            this.highListBox.DragLeave += new System.EventHandler(this.universalListBox_DragLeave);
            this.highListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.universalListBox_MouseDown);
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.BackColor = System.Drawing.Color.IndianRed;
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(498, 236);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(114, 33);
            this.btnDone.TabIndex = 73;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // backlogTextBox
            // 
            this.backlogTextBox.BackColor = System.Drawing.Color.White;
            this.backlogTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlogTextBox.Location = new System.Drawing.Point(67, 40);
            this.backlogTextBox.Name = "backlogTextBox";
            this.backlogTextBox.ReadOnly = true;
            this.backlogTextBox.Size = new System.Drawing.Size(51, 23);
            this.backlogTextBox.TabIndex = 74;
            this.backlogTextBox.Text = "0";
            this.backlogTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.backlogTextBox.WordWrap = false;
            // 
            // lowTextBox
            // 
            this.lowTextBox.BackColor = System.Drawing.Color.White;
            this.lowTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowTextBox.Location = new System.Drawing.Point(182, 40);
            this.lowTextBox.Name = "lowTextBox";
            this.lowTextBox.ReadOnly = true;
            this.lowTextBox.Size = new System.Drawing.Size(51, 23);
            this.lowTextBox.TabIndex = 75;
            this.lowTextBox.Text = "0";
            this.lowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lowTextBox.WordWrap = false;
            // 
            // medTextBox
            // 
            this.medTextBox.BackColor = System.Drawing.Color.White;
            this.medTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medTextBox.Location = new System.Drawing.Point(297, 40);
            this.medTextBox.Name = "medTextBox";
            this.medTextBox.ReadOnly = true;
            this.medTextBox.Size = new System.Drawing.Size(51, 23);
            this.medTextBox.TabIndex = 76;
            this.medTextBox.Text = "0";
            this.medTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.medTextBox.WordWrap = false;
            // 
            // highTextBox
            // 
            this.highTextBox.BackColor = System.Drawing.Color.White;
            this.highTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highTextBox.Location = new System.Drawing.Point(412, 40);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.ReadOnly = true;
            this.highTextBox.Size = new System.Drawing.Size(51, 23);
            this.highTextBox.TabIndex = 77;
            this.highTextBox.Text = "0";
            this.highTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.highTextBox.WordWrap = false;
            // 
            // diceImage1
            // 
            this.diceImage1.Image = ((System.Drawing.Image)(resources.GetObject("diceImage1.Image")));
            this.diceImage1.InitialImage = ((System.Drawing.Image)(resources.GetObject("diceImage1.InitialImage")));
            this.diceImage1.Location = new System.Drawing.Point(124, 31);
            this.diceImage1.Name = "diceImage1";
            this.diceImage1.Size = new System.Drawing.Size(32, 32);
            this.diceImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diceImage1.TabIndex = 78;
            this.diceImage1.TabStop = false;
            // 
            // diceImage2
            // 
            this.diceImage2.Image = ((System.Drawing.Image)(resources.GetObject("diceImage2.Image")));
            this.diceImage2.InitialImage = ((System.Drawing.Image)(resources.GetObject("diceImage2.InitialImage")));
            this.diceImage2.Location = new System.Drawing.Point(239, 31);
            this.diceImage2.Name = "diceImage2";
            this.diceImage2.Size = new System.Drawing.Size(32, 32);
            this.diceImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diceImage2.TabIndex = 79;
            this.diceImage2.TabStop = false;
            // 
            // diceImage3
            // 
            this.diceImage3.Image = ((System.Drawing.Image)(resources.GetObject("diceImage3.Image")));
            this.diceImage3.InitialImage = ((System.Drawing.Image)(resources.GetObject("diceImage3.InitialImage")));
            this.diceImage3.Location = new System.Drawing.Point(354, 31);
            this.diceImage3.Name = "diceImage3";
            this.diceImage3.Size = new System.Drawing.Size(32, 32);
            this.diceImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diceImage3.TabIndex = 80;
            this.diceImage3.TabStop = false;
            // 
            // diceImage4
            // 
            this.diceImage4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.diceImage4.Image = ((System.Drawing.Image)(resources.GetObject("diceImage4.Image")));
            this.diceImage4.InitialImage = ((System.Drawing.Image)(resources.GetObject("diceImage4.InitialImage")));
            this.diceImage4.Location = new System.Drawing.Point(469, 31);
            this.diceImage4.Name = "diceImage4";
            this.diceImage4.Size = new System.Drawing.Size(32, 32);
            this.diceImage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diceImage4.TabIndex = 81;
            this.diceImage4.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(239, 236);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 33);
            this.btnReset.TabIndex = 82;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ToolTaskPrompt
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(624, 281);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.diceImage4);
            this.Controls.Add(this.diceImage3);
            this.Controls.Add(this.diceImage2);
            this.Controls.Add(this.diceImage1);
            this.Controls.Add(this.highTextBox);
            this.Controls.Add(this.medTextBox);
            this.Controls.Add(this.lowTextBox);
            this.Controls.Add(this.backlogTextBox);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.highListBox);
            this.Controls.Add(this.medListBox);
            this.Controls.Add(this.lowListBox);
            this.Controls.Add(this.toolListBox);
            this.Controls.Add(this.backlogListBox);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.lblBacklog);
            this.Controls.Add(this.toolsPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolTaskPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Would you like to use any tools?";
            ((System.ComponentModel.ISupportInitialize)(this.toolsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceImage4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox toolsPictureBox;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblBacklog;
        private System.Windows.Forms.ListBox backlogListBox;
        private System.Windows.Forms.ListBox toolListBox;
        private System.Windows.Forms.ListBox lowListBox;
        private System.Windows.Forms.ListBox medListBox;
        private System.Windows.Forms.ListBox highListBox;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox backlogTextBox;
        private System.Windows.Forms.TextBox lowTextBox;
        private System.Windows.Forms.TextBox medTextBox;
        private System.Windows.Forms.TextBox highTextBox;
        private System.Windows.Forms.PictureBox diceImage1;
        private System.Windows.Forms.PictureBox diceImage2;
        private System.Windows.Forms.PictureBox diceImage3;
        private System.Windows.Forms.PictureBox diceImage4;
        private System.Windows.Forms.Button btnReset;
    }
}