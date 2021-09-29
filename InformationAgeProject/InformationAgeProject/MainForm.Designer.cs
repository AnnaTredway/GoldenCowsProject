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
            this.components = new System.ComponentModel.Container();
            this.backlogLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.mediumLabel = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.backlogAddButton = new System.Windows.Forms.Button();
            this.backlogSubtButton = new System.Windows.Forms.Button();
            this.lowAddButton = new System.Windows.Forms.Button();
            this.lowSubtButton = new System.Windows.Forms.Button();
            this.medAddButton = new System.Windows.Forms.Button();
            this.medSubtButton = new System.Windows.Forms.Button();
            this.highAddButton = new System.Windows.Forms.Button();
            this.highSubtButton = new System.Windows.Forms.Button();
            this.taskLabel = new System.Windows.Forms.Label();
            this.devLabel = new System.Windows.Forms.Label();
            this.doTasksButton = new System.Windows.Forms.Button();
            this.notFinalLabel = new System.Windows.Forms.Label();
            this.backlogTextBox = new System.Windows.Forms.TextBox();
            this.lowTextBox = new System.Windows.Forms.TextBox();
            this.medTextBox = new System.Windows.Forms.TextBox();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.devTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backlogLabel
            // 
            this.backlogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlogLabel.ForeColor = System.Drawing.Color.Blue;
            this.backlogLabel.Location = new System.Drawing.Point(564, 7);
            this.backlogLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backlogLabel.Name = "backlogLabel";
            this.backlogLabel.Size = new System.Drawing.Size(80, 28);
            this.backlogLabel.TabIndex = 8;
            this.backlogLabel.Text = "Backlog Tasks";
            // 
            // lowLabel
            // 
            this.lowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowLabel.ForeColor = System.Drawing.Color.Green;
            this.lowLabel.Location = new System.Drawing.Point(658, 7);
            this.lowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(100, 28);
            this.lowLabel.TabIndex = 9;
            this.lowLabel.Text = "Low-Priority Tasks";
            // 
            // mediumLabel
            // 
            this.mediumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumLabel.ForeColor = System.Drawing.Color.Gold;
            this.mediumLabel.Location = new System.Drawing.Point(753, 7);
            this.mediumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mediumLabel.Name = "mediumLabel";
            this.mediumLabel.Size = new System.Drawing.Size(100, 28);
            this.mediumLabel.TabIndex = 10;
            this.mediumLabel.Text = "Medium-Priority Tasks";
            // 
            // highLabel
            // 
            this.highLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLabel.ForeColor = System.Drawing.Color.Red;
            this.highLabel.Location = new System.Drawing.Point(848, 7);
            this.highLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(100, 28);
            this.highLabel.TabIndex = 11;
            this.highLabel.Text = "High-Priority Tasks";
            // 
            // backlogAddButton
            // 
            this.backlogAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlogAddButton.Location = new System.Drawing.Point(567, 67);
            this.backlogAddButton.Name = "backlogAddButton";
            this.backlogAddButton.Size = new System.Drawing.Size(25, 25);
            this.backlogAddButton.TabIndex = 12;
            this.backlogAddButton.Text = "+";
            this.backlogAddButton.UseVisualStyleBackColor = true;
            this.backlogAddButton.Click += new System.EventHandler(this.backlogAddButton_Click);
            // 
            // backlogSubtButton
            // 
            this.backlogSubtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlogSubtButton.Location = new System.Drawing.Point(598, 67);
            this.backlogSubtButton.Name = "backlogSubtButton";
            this.backlogSubtButton.Size = new System.Drawing.Size(25, 25);
            this.backlogSubtButton.TabIndex = 13;
            this.backlogSubtButton.Text = "-";
            this.backlogSubtButton.UseVisualStyleBackColor = true;
            this.backlogSubtButton.Click += new System.EventHandler(this.backlogSubtButton_Click);
            // 
            // lowAddButton
            // 
            this.lowAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowAddButton.Location = new System.Drawing.Point(661, 67);
            this.lowAddButton.Name = "lowAddButton";
            this.lowAddButton.Size = new System.Drawing.Size(25, 25);
            this.lowAddButton.TabIndex = 14;
            this.lowAddButton.Text = "+";
            this.lowAddButton.UseVisualStyleBackColor = true;
            this.lowAddButton.Click += new System.EventHandler(this.lowAddButton_Click);
            // 
            // lowSubtButton
            // 
            this.lowSubtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowSubtButton.Location = new System.Drawing.Point(692, 67);
            this.lowSubtButton.Name = "lowSubtButton";
            this.lowSubtButton.Size = new System.Drawing.Size(25, 25);
            this.lowSubtButton.TabIndex = 15;
            this.lowSubtButton.Text = "-";
            this.lowSubtButton.UseVisualStyleBackColor = true;
            this.lowSubtButton.Click += new System.EventHandler(this.lowSubtButton_Click);
            // 
            // medAddButton
            // 
            this.medAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medAddButton.Location = new System.Drawing.Point(756, 66);
            this.medAddButton.Name = "medAddButton";
            this.medAddButton.Size = new System.Drawing.Size(25, 25);
            this.medAddButton.TabIndex = 16;
            this.medAddButton.Text = "+";
            this.medAddButton.UseVisualStyleBackColor = true;
            this.medAddButton.Click += new System.EventHandler(this.medAddButton_Click);
            // 
            // medSubtButton
            // 
            this.medSubtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medSubtButton.Location = new System.Drawing.Point(787, 66);
            this.medSubtButton.Name = "medSubtButton";
            this.medSubtButton.Size = new System.Drawing.Size(25, 25);
            this.medSubtButton.TabIndex = 17;
            this.medSubtButton.Text = "-";
            this.medSubtButton.UseVisualStyleBackColor = true;
            this.medSubtButton.Click += new System.EventHandler(this.medSubtButton_Click);
            // 
            // highAddButton
            // 
            this.highAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highAddButton.Location = new System.Drawing.Point(851, 67);
            this.highAddButton.Name = "highAddButton";
            this.highAddButton.Size = new System.Drawing.Size(25, 25);
            this.highAddButton.TabIndex = 18;
            this.highAddButton.Text = "+";
            this.highAddButton.UseVisualStyleBackColor = true;
            this.highAddButton.Click += new System.EventHandler(this.highAddButton_Click);
            // 
            // highSubtButton
            // 
            this.highSubtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highSubtButton.Location = new System.Drawing.Point(882, 67);
            this.highSubtButton.Name = "highSubtButton";
            this.highSubtButton.Size = new System.Drawing.Size(25, 25);
            this.highSubtButton.TabIndex = 19;
            this.highSubtButton.Text = "-";
            this.highSubtButton.UseVisualStyleBackColor = true;
            this.highSubtButton.Click += new System.EventHandler(this.highSubtButton_Click);
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel.Location = new System.Drawing.Point(478, 7);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(81, 26);
            this.taskLabel.TabIndex = 24;
            this.taskLabel.Text = "Tasks:";
            // 
            // devLabel
            // 
            this.devLabel.AutoSize = true;
            this.devLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devLabel.Location = new System.Drawing.Point(757, 503);
            this.devLabel.Name = "devLabel";
            this.devLabel.Size = new System.Drawing.Size(139, 26);
            this.devLabel.TabIndex = 25;
            this.devLabel.Text = "Developers:";
            // 
            // doTasksButton
            // 
            this.doTasksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doTasksButton.Location = new System.Drawing.Point(618, 112);
            this.doTasksButton.Name = "doTasksButton";
            this.doTasksButton.Size = new System.Drawing.Size(246, 33);
            this.doTasksButton.TabIndex = 26;
            this.doTasksButton.Text = "Do Tasks";
            this.doTasksButton.UseVisualStyleBackColor = true;
            this.doTasksButton.Click += new System.EventHandler(this.doTasksButton_Click);
            // 
            // notFinalLabel
            // 
            this.notFinalLabel.AutoSize = true;
            this.notFinalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFinalLabel.Location = new System.Drawing.Point(12, 9);
            this.notFinalLabel.Name = "notFinalLabel";
            this.notFinalLabel.Size = new System.Drawing.Size(376, 31);
            this.notFinalLabel.TabIndex = 27;
            this.notFinalLabel.Text = "GUI INTERFACE NOT FINAL";
            // 
            // backlogTextBox
            // 
            this.backlogTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlogTextBox.Location = new System.Drawing.Point(567, 38);
            this.backlogTextBox.Name = "backlogTextBox";
            this.backlogTextBox.Size = new System.Drawing.Size(25, 23);
            this.backlogTextBox.TabIndex = 28;
            this.backlogTextBox.Text = "0";
            this.backlogTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lowTextBox
            // 
            this.lowTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowTextBox.Location = new System.Drawing.Point(661, 38);
            this.lowTextBox.Name = "lowTextBox";
            this.lowTextBox.Size = new System.Drawing.Size(25, 23);
            this.lowTextBox.TabIndex = 29;
            this.lowTextBox.Text = "0";
            this.lowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // medTextBox
            // 
            this.medTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medTextBox.Location = new System.Drawing.Point(756, 37);
            this.medTextBox.Name = "medTextBox";
            this.medTextBox.Size = new System.Drawing.Size(25, 23);
            this.medTextBox.TabIndex = 30;
            this.medTextBox.Text = "0";
            this.medTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // highTextBox
            // 
            this.highTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highTextBox.Location = new System.Drawing.Point(851, 38);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.Size = new System.Drawing.Size(25, 23);
            this.highTextBox.TabIndex = 31;
            this.highTextBox.Text = "0";
            this.highTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // devTextBox
            // 
            this.devTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devTextBox.Location = new System.Drawing.Point(902, 503);
            this.devTextBox.Name = "devTextBox";
            this.devTextBox.Size = new System.Drawing.Size(32, 32);
            this.devTextBox.TabIndex = 32;
            this.devTextBox.Text = "0";
            this.devTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTextBox.Location = new System.Drawing.Point(12, 512);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(400, 23);
            this.inventoryTextBox.TabIndex = 34;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(13, 483);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(110, 26);
            this.inventoryLabel.TabIndex = 35;
            this.inventoryLabel.Text = "Inventory";
            this.btnInstructions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(12, 415);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(138, 23);
            this.btnInstructions.TabIndex = 0;
            this.btnInstructions.Text = "View Game Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
			this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.devTextBox);
            this.Controls.Add(this.highTextBox);
            this.Controls.Add(this.medTextBox);
            this.Controls.Add(this.lowTextBox);
            this.Controls.Add(this.backlogTextBox);
            this.Controls.Add(this.notFinalLabel);
            this.Controls.Add(this.doTasksButton);
            this.Controls.Add(this.devLabel);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.highSubtButton);
            this.Controls.Add(this.highAddButton);
            this.Controls.Add(this.medSubtButton);
            this.Controls.Add(this.medAddButton);
            this.Controls.Add(this.lowSubtButton);
            this.Controls.Add(this.lowAddButton);
            this.Controls.Add(this.backlogSubtButton);
            this.Controls.Add(this.backlogAddButton);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.mediumLabel);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.backlogLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Information Age";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label backlogLabel;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label mediumLabel;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Button backlogAddButton;
        private System.Windows.Forms.Button backlogSubtButton;
        private System.Windows.Forms.Button lowAddButton;
        private System.Windows.Forms.Button lowSubtButton;
        private System.Windows.Forms.Button medAddButton;
        private System.Windows.Forms.Button medSubtButton;
        private System.Windows.Forms.Button highAddButton;
        private System.Windows.Forms.Button highSubtButton;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label devLabel;
        private System.Windows.Forms.Button doTasksButton;
        private System.Windows.Forms.Label notFinalLabel;
        private System.Windows.Forms.TextBox backlogTextBox;
        private System.Windows.Forms.TextBox lowTextBox;
        private System.Windows.Forms.TextBox medTextBox;
        private System.Windows.Forms.TextBox highTextBox;
        private System.Windows.Forms.TextBox devTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Button btnInstructions;
    }
}

