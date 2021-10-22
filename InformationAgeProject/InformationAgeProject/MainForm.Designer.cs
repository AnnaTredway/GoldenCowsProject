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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.btnDoTasks = new System.Windows.Forms.Button();
            this.lblNotFinal = new System.Windows.Forms.Label();
            this.txtBacklog = new System.Windows.Forms.TextBox();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtMed = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.txtDevelopers = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inventoryBox = new System.Windows.Forms.RichTextBox();
            this.scoreBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInstructionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.ProjectProgressCard1 = new System.Windows.Forms.TextBox();
            this.ProjectProgressCard2 = new System.Windows.Forms.TextBox();
            this.ProjectProgressCard3 = new System.Windows.Forms.TextBox();
            this.ProjectProgressCard4 = new System.Windows.Forms.TextBox();
            this.ClaimCard1 = new System.Windows.Forms.Button();
            this.ClaimCard2 = new System.Windows.Forms.Button();
            this.ClaimCard3 = new System.Windows.Forms.Button();
            this.ClaimCard4 = new System.Windows.Forms.Button();
            this.toolSlot1 = new System.Windows.Forms.TextBox();
            this.toolSlot2 = new System.Windows.Forms.TextBox();
            this.toolSlot3 = new System.Windows.Forms.TextBox();
            this.txtToolMaker = new System.Windows.Forms.TextBox();
            this.btnAddToolMaker = new System.Windows.Forms.Button();
            this.btnSubtToolMaker = new System.Windows.Forms.Button();
            this.btnAcquireTool = new System.Windows.Forms.Button();
            this.toolsPictureBox = new System.Windows.Forms.PictureBox();
            this.toolMakerPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolMakerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBacklog
            // 
            this.lblBacklog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblLow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblMedium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblHigh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnAddBacklog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBacklog.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddBacklog.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddBacklog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBacklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBacklog.Location = new System.Drawing.Point(903, 73);
            this.btnAddBacklog.Name = "btnAddBacklog";
            this.btnAddBacklog.Size = new System.Drawing.Size(25, 25);
            this.btnAddBacklog.TabIndex = 12;
            this.btnAddBacklog.Text = "+";
            this.btnAddBacklog.UseVisualStyleBackColor = false;
            this.btnAddBacklog.Click += new System.EventHandler(this.btnAddBacklog_Click);
            // 
            // btnSubtBacklog
            // 
            this.btnSubtBacklog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubtBacklog.BackColor = System.Drawing.Color.IndianRed;
            this.btnSubtBacklog.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubtBacklog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtBacklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtBacklog.Location = new System.Drawing.Point(903, 102);
            this.btnSubtBacklog.Name = "btnSubtBacklog";
            this.btnSubtBacklog.Size = new System.Drawing.Size(25, 25);
            this.btnSubtBacklog.TabIndex = 13;
            this.btnSubtBacklog.Text = "-";
            this.btnSubtBacklog.UseVisualStyleBackColor = false;
            this.btnSubtBacklog.Click += new System.EventHandler(this.btnSubtBacklog_Click);
            // 
            // btnAddLow
            // 
            this.btnAddLow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLow.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddLow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLow.Location = new System.Drawing.Point(997, 73);
            this.btnAddLow.Name = "btnAddLow";
            this.btnAddLow.Size = new System.Drawing.Size(25, 25);
            this.btnAddLow.TabIndex = 14;
            this.btnAddLow.Text = "+";
            this.btnAddLow.UseVisualStyleBackColor = false;
            this.btnAddLow.Click += new System.EventHandler(this.btnAddLow_Click);
            // 
            // btnSubtLow
            // 
            this.btnSubtLow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubtLow.BackColor = System.Drawing.Color.IndianRed;
            this.btnSubtLow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubtLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtLow.Location = new System.Drawing.Point(997, 102);
            this.btnSubtLow.Name = "btnSubtLow";
            this.btnSubtLow.Size = new System.Drawing.Size(25, 25);
            this.btnSubtLow.TabIndex = 15;
            this.btnSubtLow.Text = "-";
            this.btnSubtLow.UseVisualStyleBackColor = false;
            this.btnSubtLow.Click += new System.EventHandler(this.btnSubtLow_Click);
            // 
            // btnAddMed
            // 
            this.btnAddMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMed.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddMed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMed.Location = new System.Drawing.Point(1092, 70);
            this.btnAddMed.Name = "btnAddMed";
            this.btnAddMed.Size = new System.Drawing.Size(25, 25);
            this.btnAddMed.TabIndex = 16;
            this.btnAddMed.Text = "+";
            this.btnAddMed.UseVisualStyleBackColor = false;
            this.btnAddMed.Click += new System.EventHandler(this.btnAddMed_Click);
            // 
            // btnSubtMed
            // 
            this.btnSubtMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubtMed.BackColor = System.Drawing.Color.IndianRed;
            this.btnSubtMed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubtMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtMed.Location = new System.Drawing.Point(1092, 101);
            this.btnSubtMed.Name = "btnSubtMed";
            this.btnSubtMed.Size = new System.Drawing.Size(25, 25);
            this.btnSubtMed.TabIndex = 17;
            this.btnSubtMed.Text = "-";
            this.btnSubtMed.UseVisualStyleBackColor = false;
            this.btnSubtMed.Click += new System.EventHandler(this.btnSubtMed_Click);
            // 
            // btnAddHigh
            // 
            this.btnAddHigh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddHigh.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddHigh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddHigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHigh.Location = new System.Drawing.Point(1187, 73);
            this.btnAddHigh.Name = "btnAddHigh";
            this.btnAddHigh.Size = new System.Drawing.Size(25, 25);
            this.btnAddHigh.TabIndex = 18;
            this.btnAddHigh.Text = "+";
            this.btnAddHigh.UseVisualStyleBackColor = false;
            this.btnAddHigh.Click += new System.EventHandler(this.btnAddHigh_Click);
            // 
            // btnSubtHigh
            // 
            this.btnSubtHigh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubtHigh.BackColor = System.Drawing.Color.IndianRed;
            this.btnSubtHigh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubtHigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtHigh.Location = new System.Drawing.Point(1187, 102);
            this.btnSubtHigh.Name = "btnSubtHigh";
            this.btnSubtHigh.Size = new System.Drawing.Size(25, 25);
            this.btnSubtHigh.TabIndex = 19;
            this.btnSubtHigh.Text = "-";
            this.btnSubtHigh.UseVisualStyleBackColor = false;
            this.btnSubtHigh.Click += new System.EventHandler(this.btnSubtHigh_Click);
            // 
            // lblTasks
            // 
            this.lblTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(783, 42);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(81, 26);
            this.lblTasks.TabIndex = 24;
            this.lblTasks.Text = "Tasks:";
            // 
            // btnDoTasks
            // 
            this.btnDoTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoTasks.BackColor = System.Drawing.Color.IndianRed;
            this.btnDoTasks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDoTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoTasks.Location = new System.Drawing.Point(871, 147);
            this.btnDoTasks.Name = "btnDoTasks";
            this.btnDoTasks.Size = new System.Drawing.Size(381, 33);
            this.btnDoTasks.TabIndex = 26;
            this.btnDoTasks.Text = "Do Tasks";
            this.btnDoTasks.UseVisualStyleBackColor = false;
            this.btnDoTasks.Click += new System.EventHandler(this.btnDoTasks_Click);
            // 
            // lblNotFinal
            // 
            this.lblNotFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNotFinal.AutoSize = true;
            this.lblNotFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotFinal.Location = new System.Drawing.Point(12, 634);
            this.lblNotFinal.Name = "lblNotFinal";
            this.lblNotFinal.Size = new System.Drawing.Size(376, 31);
            this.lblNotFinal.TabIndex = 27;
            this.lblNotFinal.Text = "GUI INTERFACE NOT FINAL";
            // 
            // txtBacklog
            // 
            this.txtBacklog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBacklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBacklog.Location = new System.Drawing.Point(872, 73);
            this.txtBacklog.Name = "txtBacklog";
            this.txtBacklog.ReadOnly = true;
            this.txtBacklog.Size = new System.Drawing.Size(25, 23);
            this.txtBacklog.TabIndex = 28;
            this.txtBacklog.Text = "0";
            this.txtBacklog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBacklog.WordWrap = false;
            // 
            // txtLow
            // 
            this.txtLow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLow.Location = new System.Drawing.Point(966, 73);
            this.txtLow.Name = "txtLow";
            this.txtLow.ReadOnly = true;
            this.txtLow.Size = new System.Drawing.Size(25, 23);
            this.txtLow.TabIndex = 29;
            this.txtLow.Text = "0";
            this.txtLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLow.WordWrap = false;
            // 
            // txtMed
            // 
            this.txtMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMed.Location = new System.Drawing.Point(1061, 72);
            this.txtMed.Name = "txtMed";
            this.txtMed.ReadOnly = true;
            this.txtMed.Size = new System.Drawing.Size(25, 23);
            this.txtMed.TabIndex = 30;
            this.txtMed.Text = "0";
            this.txtMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMed.WordWrap = false;
            // 
            // txtHigh
            // 
            this.txtHigh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHigh.Location = new System.Drawing.Point(1156, 73);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.ReadOnly = true;
            this.txtHigh.Size = new System.Drawing.Size(25, 23);
            this.txtHigh.TabIndex = 31;
            this.txtHigh.Text = "0";
            this.txtHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHigh.WordWrap = false;
            // 
            // txtDevelopers
            // 
            this.txtDevelopers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDevelopers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevelopers.Location = new System.Drawing.Point(1145, 637);
            this.txtDevelopers.Name = "txtDevelopers";
            this.txtDevelopers.ReadOnly = true;
            this.txtDevelopers.Size = new System.Drawing.Size(51, 32);
            this.txtDevelopers.TabIndex = 32;
            this.txtDevelopers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDevelopers.WordWrap = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // inventoryBox
            // 
            this.inventoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventoryBox.Location = new System.Drawing.Point(871, 186);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.ReadOnly = true;
            this.inventoryBox.Size = new System.Drawing.Size(381, 96);
            this.inventoryBox.TabIndex = 33;
            this.inventoryBox.Text = "";
            // 
            // scoreBox
            // 
            this.scoreBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreBox.Location = new System.Drawing.Point(871, 288);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.ReadOnly = true;
            this.scoreBox.Size = new System.Drawing.Size(381, 96);
            this.scoreBox.TabIndex = 34;
            this.scoreBox.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Firebrick;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInstructionsMenuItem,
            this.btnAboutMenuItem,
            this.btnQuitMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // btnInstructionsMenuItem
            // 
            this.btnInstructionsMenuItem.Name = "btnInstructionsMenuItem";
            this.btnInstructionsMenuItem.Size = new System.Drawing.Size(140, 22);
            this.btnInstructionsMenuItem.Text = "Instructions";
            this.btnInstructionsMenuItem.Click += new System.EventHandler(this.btnInstructionsMenuItem_Click);
            // 
            // btnAboutMenuItem
            // 
            this.btnAboutMenuItem.Name = "btnAboutMenuItem";
            this.btnAboutMenuItem.Size = new System.Drawing.Size(140, 22);
            this.btnAboutMenuItem.Text = "About";
            this.btnAboutMenuItem.Click += new System.EventHandler(this.btnAboutMenuItem_Click);
            // 
            // btnQuitMenuItem
            // 
            this.btnQuitMenuItem.Name = "btnQuitMenuItem";
            this.btnQuitMenuItem.Size = new System.Drawing.Size(140, 22);
            this.btnQuitMenuItem.Text = "Quit";
            this.btnQuitMenuItem.Click += new System.EventHandler(this.btnQuitMenuItem_Click);
            // 
            // lblInventory
            // 
            this.lblInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(748, 186);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(117, 26);
            this.lblInventory.TabIndex = 37;
            this.lblInventory.Text = "Inventory:";
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(783, 288);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(81, 26);
            this.lblScore.TabIndex = 38;
            this.lblScore.Text = "Score:";
            // 
            // ProjectProgressCard1
            // 
            this.ProjectProgressCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProjectProgressCard1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectProgressCard1.Location = new System.Drawing.Point(18, 438);
            this.ProjectProgressCard1.Multiline = true;
            this.ProjectProgressCard1.Name = "ProjectProgressCard1";
            this.ProjectProgressCard1.ReadOnly = true;
            this.ProjectProgressCard1.Size = new System.Drawing.Size(130, 129);
            this.ProjectProgressCard1.TabIndex = 39;
            // 
            // ProjectProgressCard2
            // 
            this.ProjectProgressCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProjectProgressCard2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectProgressCard2.Location = new System.Drawing.Point(154, 438);
            this.ProjectProgressCard2.Multiline = true;
            this.ProjectProgressCard2.Name = "ProjectProgressCard2";
            this.ProjectProgressCard2.ReadOnly = true;
            this.ProjectProgressCard2.Size = new System.Drawing.Size(130, 129);
            this.ProjectProgressCard2.TabIndex = 40;
            // 
            // ProjectProgressCard3
            // 
            this.ProjectProgressCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProjectProgressCard3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectProgressCard3.Location = new System.Drawing.Point(290, 438);
            this.ProjectProgressCard3.Multiline = true;
            this.ProjectProgressCard3.Name = "ProjectProgressCard3";
            this.ProjectProgressCard3.ReadOnly = true;
            this.ProjectProgressCard3.Size = new System.Drawing.Size(130, 129);
            this.ProjectProgressCard3.TabIndex = 41;
            // 
            // ProjectProgressCard4
            // 
            this.ProjectProgressCard4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProjectProgressCard4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectProgressCard4.Location = new System.Drawing.Point(426, 438);
            this.ProjectProgressCard4.Multiline = true;
            this.ProjectProgressCard4.Name = "ProjectProgressCard4";
            this.ProjectProgressCard4.ReadOnly = true;
            this.ProjectProgressCard4.Size = new System.Drawing.Size(130, 129);
            this.ProjectProgressCard4.TabIndex = 42;
            // 
            // ClaimCard1
            // 
            this.ClaimCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClaimCard1.Location = new System.Drawing.Point(45, 573);
            this.ClaimCard1.Name = "ClaimCard1";
            this.ClaimCard1.Size = new System.Drawing.Size(75, 23);
            this.ClaimCard1.TabIndex = 43;
            this.ClaimCard1.Text = "Claim Card";
            this.ClaimCard1.UseVisualStyleBackColor = true;
            this.ClaimCard1.Click += new System.EventHandler(this.ClaimCard1_Click);
            // 
            // ClaimCard2
            // 
            this.ClaimCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClaimCard2.Location = new System.Drawing.Point(185, 573);
            this.ClaimCard2.Name = "ClaimCard2";
            this.ClaimCard2.Size = new System.Drawing.Size(75, 23);
            this.ClaimCard2.TabIndex = 44;
            this.ClaimCard2.Text = "Claim Card";
            this.ClaimCard2.UseVisualStyleBackColor = true;
            this.ClaimCard2.Click += new System.EventHandler(this.ClaimCard2_Click);
            // 
            // ClaimCard3
            // 
            this.ClaimCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClaimCard3.Location = new System.Drawing.Point(319, 573);
            this.ClaimCard3.Name = "ClaimCard3";
            this.ClaimCard3.Size = new System.Drawing.Size(75, 23);
            this.ClaimCard3.TabIndex = 45;
            this.ClaimCard3.Text = "Claim Card";
            this.ClaimCard3.UseVisualStyleBackColor = true;
            this.ClaimCard3.Click += new System.EventHandler(this.ClaimCard3_Click);
            // 
            // ClaimCard4
            // 
            this.ClaimCard4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClaimCard4.Location = new System.Drawing.Point(454, 573);
            this.ClaimCard4.Name = "ClaimCard4";
            this.ClaimCard4.Size = new System.Drawing.Size(75, 23);
            this.ClaimCard4.TabIndex = 46;
            this.ClaimCard4.Text = "Claim Card";
            this.ClaimCard4.UseVisualStyleBackColor = true;
            this.ClaimCard4.Click += new System.EventHandler(this.ClaimCard4_Click);
            // 
            // toolSlot1
            // 
            this.toolSlot1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toolSlot1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolSlot1.Location = new System.Drawing.Point(1201, 507);
            this.toolSlot1.Multiline = true;
            this.toolSlot1.Name = "toolSlot1";
            this.toolSlot1.ReadOnly = true;
            this.toolSlot1.Size = new System.Drawing.Size(50, 50);
            this.toolSlot1.TabIndex = 47;
            this.toolSlot1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolSlot2
            // 
            this.toolSlot2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toolSlot2.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolSlot2.Location = new System.Drawing.Point(1202, 563);
            this.toolSlot2.Multiline = true;
            this.toolSlot2.Name = "toolSlot2";
            this.toolSlot2.ReadOnly = true;
            this.toolSlot2.Size = new System.Drawing.Size(50, 50);
            this.toolSlot2.TabIndex = 48;
            this.toolSlot2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolSlot3
            // 
            this.toolSlot3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toolSlot3.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolSlot3.Location = new System.Drawing.Point(1202, 619);
            this.toolSlot3.Multiline = true;
            this.toolSlot3.Name = "toolSlot3";
            this.toolSlot3.ReadOnly = true;
            this.toolSlot3.Size = new System.Drawing.Size(50, 50);
            this.toolSlot3.TabIndex = 49;
            this.toolSlot3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToolMaker
            // 
            this.txtToolMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToolMaker.Location = new System.Drawing.Point(43, 111);
            this.txtToolMaker.Name = "txtToolMaker";
            this.txtToolMaker.ReadOnly = true;
            this.txtToolMaker.Size = new System.Drawing.Size(25, 23);
            this.txtToolMaker.TabIndex = 53;
            this.txtToolMaker.Text = "0";
            this.txtToolMaker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToolMaker.WordWrap = false;
            // 
            // btnAddToolMaker
            // 
            this.btnAddToolMaker.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAddToolMaker.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddToolMaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToolMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToolMaker.Location = new System.Drawing.Point(74, 111);
            this.btnAddToolMaker.Name = "btnAddToolMaker";
            this.btnAddToolMaker.Size = new System.Drawing.Size(25, 25);
            this.btnAddToolMaker.TabIndex = 54;
            this.btnAddToolMaker.Text = "+";
            this.btnAddToolMaker.UseVisualStyleBackColor = false;
            this.btnAddToolMaker.Click += new System.EventHandler(this.btnAddToolMaker_Click);
            // 
            // btnSubtToolMaker
            // 
            this.btnSubtToolMaker.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSubtToolMaker.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubtToolMaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtToolMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtToolMaker.Location = new System.Drawing.Point(12, 111);
            this.btnSubtToolMaker.Name = "btnSubtToolMaker";
            this.btnSubtToolMaker.Size = new System.Drawing.Size(25, 25);
            this.btnSubtToolMaker.TabIndex = 55;
            this.btnSubtToolMaker.Text = "-";
            this.btnSubtToolMaker.UseVisualStyleBackColor = false;
            this.btnSubtToolMaker.Click += new System.EventHandler(this.btnSubtToolMaker_Click);
            // 
            // btnAcquireTool
            // 
            this.btnAcquireTool.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAcquireTool.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAcquireTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcquireTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcquireTool.Location = new System.Drawing.Point(12, 140);
            this.btnAcquireTool.Name = "btnAcquireTool";
            this.btnAcquireTool.Size = new System.Drawing.Size(87, 33);
            this.btnAcquireTool.TabIndex = 57;
            this.btnAcquireTool.Text = "Acquire Tool";
            this.btnAcquireTool.UseVisualStyleBackColor = false;
            this.btnAcquireTool.Click += new System.EventHandler(this.btnAcquireTool_Click);
            // 
            // toolsPictureBox
            // 
            this.toolsPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toolsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("toolsPictureBox.Image")));
            this.toolsPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("toolsPictureBox.InitialImage")));
            this.toolsPictureBox.Location = new System.Drawing.Point(1201, 453);
            this.toolsPictureBox.Name = "toolsPictureBox";
            this.toolsPictureBox.Size = new System.Drawing.Size(51, 48);
            this.toolsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toolsPictureBox.TabIndex = 58;
            this.toolsPictureBox.TabStop = false;
            // 
            // toolMakerPictureBox
            // 
            this.toolMakerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("toolMakerPictureBox.Image")));
            this.toolMakerPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("toolMakerPictureBox.InitialImage")));
            this.toolMakerPictureBox.Location = new System.Drawing.Point(12, 27);
            this.toolMakerPictureBox.Name = "toolMakerPictureBox";
            this.toolMakerPictureBox.Size = new System.Drawing.Size(87, 78);
            this.toolMakerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toolMakerPictureBox.TabIndex = 59;
            this.toolMakerPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1145, 583);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolMakerPictureBox);
            this.Controls.Add(this.toolsPictureBox);
            this.Controls.Add(this.btnAcquireTool);
            this.Controls.Add(this.btnSubtToolMaker);
            this.Controls.Add(this.btnAddToolMaker);
            this.Controls.Add(this.txtToolMaker);
            this.Controls.Add(this.toolSlot3);
            this.Controls.Add(this.toolSlot2);
            this.Controls.Add(this.toolSlot1);
            this.Controls.Add(this.ClaimCard4);
            this.Controls.Add(this.ClaimCard3);
            this.Controls.Add(this.ClaimCard2);
            this.Controls.Add(this.ClaimCard1);
            this.Controls.Add(this.ProjectProgressCard4);
            this.Controls.Add(this.ProjectProgressCard3);
            this.Controls.Add(this.ProjectProgressCard2);
            this.Controls.Add(this.ProjectProgressCard1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.txtDevelopers);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.txtBacklog);
            this.Controls.Add(this.lblNotFinal);
            this.Controls.Add(this.btnDoTasks);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information Age";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolMakerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnDoTasks;
        private System.Windows.Forms.Label lblNotFinal;
        private System.Windows.Forms.TextBox txtBacklog;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtMed;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.TextBox txtDevelopers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox inventoryBox;
        private System.Windows.Forms.RichTextBox scoreBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnInstructionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnQuitMenuItem;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox ProjectProgressCard1;
        private System.Windows.Forms.TextBox ProjectProgressCard2;
        private System.Windows.Forms.TextBox ProjectProgressCard3;
        private System.Windows.Forms.TextBox ProjectProgressCard4;
        private System.Windows.Forms.Button ClaimCard1;
        private System.Windows.Forms.Button ClaimCard2;
        private System.Windows.Forms.Button ClaimCard3;
        private System.Windows.Forms.Button ClaimCard4;
        private System.Windows.Forms.TextBox toolSlot1;
        private System.Windows.Forms.TextBox toolSlot2;
        private System.Windows.Forms.TextBox toolSlot3;
        private System.Windows.Forms.TextBox txtToolMaker;
        private System.Windows.Forms.Button btnAddToolMaker;
        private System.Windows.Forms.Button btnSubtToolMaker;
        private System.Windows.Forms.Button btnAcquireTool;
        private System.Windows.Forms.PictureBox toolsPictureBox;
        private System.Windows.Forms.PictureBox toolMakerPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

