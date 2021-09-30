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
            this.lblBacklog = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.btnAddBacklog = new System.Windows.Forms.Button();
            this.btnSubtBacklog = new System.Windows.Forms.Button();
            this.btnAddLow = new System.Windows.Forms.Button();
            this.btnSubtLow = new System.Windows.Forms.Button();
            this.btnAddMed = new System.Windows.Forms.Button();
            this.btnSubtMed = new System.Windows.Forms.Button();
            this.btnAddHigh = new System.Windows.Forms.Button();
            this.btnSubtHigh = new System.Windows.Forms.Button();
            this.lblTasks = new System.Windows.Forms.Label();
            this.lblDevelopers = new System.Windows.Forms.Label();
            this.btnDoTasks = new System.Windows.Forms.Button();
            this.lblNotFinal = new System.Windows.Forms.Label();
            this.txtBacklog = new System.Windows.Forms.TextBox();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtMed = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.txtDevelopers = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnInstructions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBacklog
            // 
            this.lblBacklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacklog.ForeColor = System.Drawing.Color.Blue;
            this.lblBacklog.Location = new System.Drawing.Point(869, 42);
            this.lblBacklog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBacklog.Name = "lblBacklog";
            this.lblBacklog.Size = new System.Drawing.Size(80, 28);
            this.lblBacklog.TabIndex = 8;
            this.lblBacklog.Text = "Backlog Tasks";
            // 
            // lblLow
            // 
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.ForeColor = System.Drawing.Color.Green;
            this.lblLow.Location = new System.Drawing.Point(963, 42);
            this.lblLow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(100, 28);
            this.lblLow.TabIndex = 9;
            this.lblLow.Text = "Low-Priority Tasks";
            // 
            // lblMedium
            // 
            this.lblMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedium.ForeColor = System.Drawing.Color.Gold;
            this.lblMedium.Location = new System.Drawing.Point(1058, 42);
            this.lblMedium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(100, 28);
            this.lblMedium.TabIndex = 10;
            this.lblMedium.Text = "Medium-Priority Tasks";
            // 
            // lblHigh
            // 
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.ForeColor = System.Drawing.Color.Red;
            this.lblHigh.Location = new System.Drawing.Point(1153, 42);
            this.lblHigh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(100, 28);
            this.lblHigh.TabIndex = 11;
            this.lblHigh.Text = "High-Priority Tasks";
            // 
            // btnAddBacklog
            // 
            this.btnAddBacklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBacklog.Location = new System.Drawing.Point(903, 73);
            this.btnAddBacklog.Name = "btnAddBacklog";
            this.btnAddBacklog.Size = new System.Drawing.Size(25, 25);
            this.btnAddBacklog.TabIndex = 12;
            this.btnAddBacklog.Text = "+";
            this.btnAddBacklog.UseVisualStyleBackColor = true;
            this.btnAddBacklog.Click += new System.EventHandler(this.btnAddBacklog_Click);
            // 
            // btnSubtBacklog
            // 
            this.btnSubtBacklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtBacklog.Location = new System.Drawing.Point(903, 102);
            this.btnSubtBacklog.Name = "btnSubtBacklog";
            this.btnSubtBacklog.Size = new System.Drawing.Size(25, 25);
            this.btnSubtBacklog.TabIndex = 13;
            this.btnSubtBacklog.Text = "-";
            this.btnSubtBacklog.UseVisualStyleBackColor = true;
            this.btnSubtBacklog.Click += new System.EventHandler(this.btnSubtBacklog_Click);
            // 
            // btnAddLow
            // 
            this.btnAddLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLow.Location = new System.Drawing.Point(997, 73);
            this.btnAddLow.Name = "btnAddLow";
            this.btnAddLow.Size = new System.Drawing.Size(25, 25);
            this.btnAddLow.TabIndex = 14;
            this.btnAddLow.Text = "+";
            this.btnAddLow.UseVisualStyleBackColor = true;
            this.btnAddLow.Click += new System.EventHandler(this.btnAddLow_Click);
            // 
            // btnSubtLow
            // 
            this.btnSubtLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtLow.Location = new System.Drawing.Point(997, 102);
            this.btnSubtLow.Name = "btnSubtLow";
            this.btnSubtLow.Size = new System.Drawing.Size(25, 25);
            this.btnSubtLow.TabIndex = 15;
            this.btnSubtLow.Text = "-";
            this.btnSubtLow.UseVisualStyleBackColor = true;
            this.btnSubtLow.Click += new System.EventHandler(this.btnSubtLow_Click);
            // 
            // btnAddMed
            // 
            this.btnAddMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMed.Location = new System.Drawing.Point(1092, 70);
            this.btnAddMed.Name = "btnAddMed";
            this.btnAddMed.Size = new System.Drawing.Size(25, 25);
            this.btnAddMed.TabIndex = 16;
            this.btnAddMed.Text = "+";
            this.btnAddMed.UseVisualStyleBackColor = true;
            this.btnAddMed.Click += new System.EventHandler(this.btnAddMed_Click);
            // 
            // btnSubtMed
            // 
            this.btnSubtMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtMed.Location = new System.Drawing.Point(1092, 101);
            this.btnSubtMed.Name = "btnSubtMed";
            this.btnSubtMed.Size = new System.Drawing.Size(25, 25);
            this.btnSubtMed.TabIndex = 17;
            this.btnSubtMed.Text = "-";
            this.btnSubtMed.UseVisualStyleBackColor = true;
            this.btnSubtMed.Click += new System.EventHandler(this.btnSubtMed_Click);
            // 
            // btnAddHigh
            // 
            this.btnAddHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHigh.Location = new System.Drawing.Point(1187, 73);
            this.btnAddHigh.Name = "btnAddHigh";
            this.btnAddHigh.Size = new System.Drawing.Size(25, 25);
            this.btnAddHigh.TabIndex = 18;
            this.btnAddHigh.Text = "+";
            this.btnAddHigh.UseVisualStyleBackColor = true;
            this.btnAddHigh.Click += new System.EventHandler(this.btnAddHigh_Click);
            // 
            // btnSubtHigh
            // 
            this.btnSubtHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtHigh.Location = new System.Drawing.Point(1187, 102);
            this.btnSubtHigh.Name = "btnSubtHigh";
            this.btnSubtHigh.Size = new System.Drawing.Size(25, 25);
            this.btnSubtHigh.TabIndex = 19;
            this.btnSubtHigh.Text = "-";
            this.btnSubtHigh.UseVisualStyleBackColor = true;
            this.btnSubtHigh.Click += new System.EventHandler(this.btnSubtHigh_Click);
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(783, 42);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(81, 26);
            this.lblTasks.TabIndex = 24;
            this.lblTasks.Text = "Tasks:";
            // 
            // lblDevelopers
            // 
            this.lblDevelopers.AutoSize = true;
            this.lblDevelopers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevelopers.Location = new System.Drawing.Point(1075, 640);
            this.lblDevelopers.Name = "lblDevelopers";
            this.lblDevelopers.Size = new System.Drawing.Size(139, 26);
            this.lblDevelopers.TabIndex = 25;
            this.lblDevelopers.Text = "Developers:";
            // 
            // btnDoTasks
            // 
            this.btnDoTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoTasks.Location = new System.Drawing.Point(923, 147);
            this.btnDoTasks.Name = "btnDoTasks";
            this.btnDoTasks.Size = new System.Drawing.Size(246, 33);
            this.btnDoTasks.TabIndex = 26;
            this.btnDoTasks.Text = "Do Tasks";
            this.btnDoTasks.UseVisualStyleBackColor = true;
            this.btnDoTasks.Click += new System.EventHandler(this.btnDoTasks_Click);
            // 
            // lblNotFinal
            // 
            this.lblNotFinal.AutoSize = true;
            this.lblNotFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotFinal.Location = new System.Drawing.Point(12, 39);
            this.lblNotFinal.Name = "lblNotFinal";
            this.lblNotFinal.Size = new System.Drawing.Size(376, 31);
            this.lblNotFinal.TabIndex = 27;
            this.lblNotFinal.Text = "GUI INTERFACE NOT FINAL";
            // 
            // txtBacklog
            // 
            this.txtBacklog.Enabled = false;
            this.txtBacklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBacklog.Location = new System.Drawing.Point(872, 73);
            this.txtBacklog.Name = "txtBacklog";
            this.txtBacklog.Size = new System.Drawing.Size(25, 23);
            this.txtBacklog.TabIndex = 28;
            this.txtBacklog.Text = "0";
            this.txtBacklog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBacklog.WordWrap = false;
            // 
            // txtLow
            // 
            this.txtLow.Enabled = false;
            this.txtLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLow.Location = new System.Drawing.Point(966, 73);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(25, 23);
            this.txtLow.TabIndex = 29;
            this.txtLow.Text = "0";
            this.txtLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLow.WordWrap = false;
            // 
            // txtMed
            // 
            this.txtMed.Enabled = false;
            this.txtMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMed.Location = new System.Drawing.Point(1061, 72);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(25, 23);
            this.txtMed.TabIndex = 30;
            this.txtMed.Text = "0";
            this.txtMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMed.WordWrap = false;
            // 
            // txtHigh
            // 
            this.txtHigh.Enabled = false;
            this.txtHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHigh.Location = new System.Drawing.Point(1156, 73);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(25, 23);
            this.txtHigh.TabIndex = 31;
            this.txtHigh.Text = "0";
            this.txtHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHigh.WordWrap = false;
            // 
            // txtDevelopers
            // 
            this.txtDevelopers.Enabled = false;
            this.txtDevelopers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevelopers.Location = new System.Drawing.Point(1220, 637);
            this.txtDevelopers.Name = "txtDevelopers";
            this.txtDevelopers.Size = new System.Drawing.Size(32, 32);
            this.txtDevelopers.TabIndex = 32;
            this.txtDevelopers.Text = "20";
            this.txtDevelopers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDevelopers.WordWrap = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(12, 644);
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
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.txtDevelopers);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.txtBacklog);
            this.Controls.Add(this.lblNotFinal);
            this.Controls.Add(this.btnDoTasks);
            this.Controls.Add(this.lblDevelopers);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.btnSubtHigh);
            this.Controls.Add(this.btnAddHigh);
            this.Controls.Add(this.btnSubtMed);
            this.Controls.Add(this.btnAddMed);
            this.Controls.Add(this.btnSubtLow);
            this.Controls.Add(this.btnAddLow);
            this.Controls.Add(this.btnSubtBacklog);
            this.Controls.Add(this.btnAddBacklog);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.lblBacklog);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information Age";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBacklog;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Button btnAddBacklog;
        private System.Windows.Forms.Button btnSubtBacklog;
        private System.Windows.Forms.Button btnAddLow;
        private System.Windows.Forms.Button btnSubtLow;
        private System.Windows.Forms.Button btnAddMed;
        private System.Windows.Forms.Button btnSubtMed;
        private System.Windows.Forms.Button btnAddHigh;
        private System.Windows.Forms.Button btnSubtHigh;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.Label lblDevelopers;
        private System.Windows.Forms.Button btnDoTasks;
        private System.Windows.Forms.Label lblNotFinal;
        private System.Windows.Forms.TextBox txtBacklog;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtMed;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.TextBox txtDevelopers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnInstructions;
    }
}

