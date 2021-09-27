///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         MainForm.Designer.cs
//	Description:       Main Form window gui designer file for Information Age Project
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Treadway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Wednesday, September 15, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace InformationAgeProject
{
    partial class MainForm
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
            this.backlogLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.mediumLabel = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.backlogUpDown = new System.Windows.Forms.NumericUpDown();
            this.highUpDown = new System.Windows.Forms.NumericUpDown();
            this.mediumUpDow = new System.Windows.Forms.NumericUpDown();
            this.lowUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.backlogUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumUpDow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // backlogLabel
            // 
            this.backlogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlogLabel.ForeColor = System.Drawing.Color.Blue;
            this.backlogLabel.Location = new System.Drawing.Point(752, 9);
            this.backlogLabel.Name = "backlogLabel";
            this.backlogLabel.Size = new System.Drawing.Size(107, 35);
            this.backlogLabel.TabIndex = 8;
            this.backlogLabel.Text = "Backlog Tasks";
            // 
            // lowLabel
            // 
            this.lowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowLabel.ForeColor = System.Drawing.Color.Green;
            this.lowLabel.Location = new System.Drawing.Point(878, 9);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(120, 35);
            this.lowLabel.TabIndex = 9;
            this.lowLabel.Text = "Low-Priority Tasks";
            // 
            // mediumLabel
            // 
            this.mediumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumLabel.ForeColor = System.Drawing.Color.Gold;
            this.mediumLabel.Location = new System.Drawing.Point(1004, 9);
            this.mediumLabel.Name = "mediumLabel";
            this.mediumLabel.Size = new System.Drawing.Size(120, 35);
            this.mediumLabel.TabIndex = 10;
            this.mediumLabel.Text = "Medium-Priority Tasks";
            // 
            // highLabel
            // 
            this.highLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLabel.ForeColor = System.Drawing.Color.Red;
            this.highLabel.Location = new System.Drawing.Point(1130, 9);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(120, 35);
            this.highLabel.TabIndex = 11;
            this.highLabel.Text = "High-Priority Tasks";
            // 
            // backlogUpDown
            // 
            this.backlogUpDown.Location = new System.Drawing.Point(755, 47);
            this.backlogUpDown.Name = "backlogUpDown";
            this.backlogUpDown.Size = new System.Drawing.Size(50, 22);
            this.backlogUpDown.TabIndex = 12;
            // 
            // highUpDown
            // 
            this.highUpDown.Location = new System.Drawing.Point(1133, 47);
            this.highUpDown.Name = "highUpDown";
            this.highUpDown.Size = new System.Drawing.Size(50, 22);
            this.highUpDown.TabIndex = 13;
            // 
            // mediumUpDow
            // 
            this.mediumUpDow.Location = new System.Drawing.Point(1007, 47);
            this.mediumUpDow.Name = "mediumUpDow";
            this.mediumUpDow.Size = new System.Drawing.Size(50, 22);
            this.mediumUpDow.TabIndex = 14;
            // 
            // lowUpDown
            // 
            this.lowUpDown.Location = new System.Drawing.Point(881, 47);
            this.lowUpDown.Name = "lowUpDown";
            this.lowUpDown.Size = new System.Drawing.Size(50, 22);
            this.lowUpDown.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.lowUpDown);
            this.Controls.Add(this.mediumUpDow);
            this.Controls.Add(this.highUpDown);
            this.Controls.Add(this.backlogUpDown);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.mediumLabel);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.backlogLabel);
            this.Name = "MainForm";
            this.Text = "Information Age";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backlogUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumUpDow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label backlogLabel;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label mediumLabel;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.NumericUpDown backlogUpDown;
        private System.Windows.Forms.NumericUpDown highUpDown;
        private System.Windows.Forms.NumericUpDown mediumUpDow;
        private System.Windows.Forms.NumericUpDown lowUpDown;
    }
}

