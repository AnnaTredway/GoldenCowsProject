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
            this.btnDoTasks = new System.Windows.Forms.Button();
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
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuitToMenuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuitToDesktopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.ProjectProgressCard1 = new System.Windows.Forms.TextBox();
            this.ClaimProgressCard1 = new System.Windows.Forms.Button();
            this.toolSlot1 = new System.Windows.Forms.TextBox();
            this.toolSlot2 = new System.Windows.Forms.TextBox();
            this.toolSlot3 = new System.Windows.Forms.TextBox();
            this.txtToolMaker = new System.Windows.Forms.TextBox();
            this.btnAddToolMaker = new System.Windows.Forms.Button();
            this.btnSubtToolMaker = new System.Windows.Forms.Button();
            this.toolsPictureBox = new System.Windows.Forms.PictureBox();
            this.toolMakerPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClaimFeaturesCard4 = new System.Windows.Forms.Button();
            this.ClaimFeaturesCard3 = new System.Windows.Forms.Button();
            this.ClaimFeaturesCard2 = new System.Windows.Forms.Button();
            this.ClaimFeaturesCard1 = new System.Windows.Forms.Button();
            this.AdditionalFeaturesTextBox4 = new System.Windows.Forms.TextBox();
            this.AdditionalFeaturesTextBox3 = new System.Windows.Forms.TextBox();
            this.AdditionalFeaturesTextBox2 = new System.Windows.Forms.TextBox();
            this.AdditionalFeaturesTextBox1 = new System.Windows.Forms.TextBox();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.FeatureCardsCostLable = new System.Windows.Forms.Label();
            this.FeatureCardsLabel1 = new System.Windows.Forms.Label();
            this.FeatureCardsLabel2 = new System.Windows.Forms.Label();
            this.FeatureCardsLabel3 = new System.Windows.Forms.Label();
            this.FeatureCardsLabel4 = new System.Windows.Forms.Label();
            this.ProjectFeaturesCardsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProjectProgressCardsGroupBox = new System.Windows.Forms.GroupBox();
            this.btnSendDevs = new System.Windows.Forms.Button();
            this.btnRecallDevs = new System.Windows.Forms.Button();
            this.lblRecruitStatus = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolMakerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ProjectFeaturesCardsGroupBox.SuspendLayout();
            this.ProjectProgressCardsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.btnAddBacklog.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnAddBacklog.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddBacklog.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddBacklog.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddBacklog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBacklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBacklog.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
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
            this.btnSubtBacklog.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnSubtBacklog.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSubtBacklog.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSubtBacklog.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubtBacklog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtBacklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtBacklog.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
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
            this.btnAddLow.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnAddLow.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddLow.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddLow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLow.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
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
            this.btnSubtLow.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnSubtLow.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSubtLow.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSubtLow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubtLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtLow.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
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
            this.btnAddMed.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnAddMed.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddMed.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddMed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMed.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnAddMed.Location = new System.Drawing.Point(1092, 73);
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
            this.btnSubtMed.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnSubtMed.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSubtMed.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSubtMed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubtMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtMed.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnSubtMed.Location = new System.Drawing.Point(1092, 102);
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
            this.btnAddHigh.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnAddHigh.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddHigh.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddHigh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddHigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHigh.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
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
            this.btnSubtHigh.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnSubtHigh.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSubtHigh.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSubtHigh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubtHigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtHigh.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnSubtHigh.Location = new System.Drawing.Point(1187, 102);
            this.btnSubtHigh.Name = "btnSubtHigh";
            this.btnSubtHigh.Size = new System.Drawing.Size(25, 25);
            this.btnSubtHigh.TabIndex = 19;
            this.btnSubtHigh.Text = "-";
            this.btnSubtHigh.UseVisualStyleBackColor = false;
            this.btnSubtHigh.Click += new System.EventHandler(this.btnSubtHigh_Click);
            // 
            // btnDoTasks
            // 
            this.btnDoTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoTasks.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnDoTasks.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnDoTasks.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnDoTasks.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDoTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoTasks.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnDoTasks.Location = new System.Drawing.Point(872, 142);
            this.btnDoTasks.Name = "btnDoTasks";
            this.btnDoTasks.Size = new System.Drawing.Size(381, 33);
            this.btnDoTasks.TabIndex = 26;
            this.btnDoTasks.Text = "Do Tasks";
            this.btnDoTasks.UseVisualStyleBackColor = false;
            this.btnDoTasks.Click += new System.EventHandler(this.btnDoTasks_Click);
            // 
            // txtBacklog
            // 
            this.txtBacklog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBacklog.BackColor = System.Drawing.Color.White;
            this.txtBacklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBacklog.Location = new System.Drawing.Point(872, 75);
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
            this.txtLow.BackColor = System.Drawing.Color.White;
            this.txtLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLow.Location = new System.Drawing.Point(966, 75);
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
            this.txtMed.BackColor = System.Drawing.Color.White;
            this.txtMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMed.Location = new System.Drawing.Point(1061, 75);
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
            this.txtHigh.BackColor = System.Drawing.Color.White;
            this.txtHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHigh.Location = new System.Drawing.Point(1156, 75);
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
            this.txtDevelopers.BackColor = System.Drawing.Color.White;
            this.txtDevelopers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevelopers.Location = new System.Drawing.Point(1146, 637);
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
            this.inventoryBox.BackColor = System.Drawing.Color.White;
            this.inventoryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventoryBox.Location = new System.Drawing.Point(872, 207);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.ReadOnly = true;
            this.inventoryBox.Size = new System.Drawing.Size(381, 105);
            this.inventoryBox.TabIndex = 33;
            this.inventoryBox.Text = "";
            // 
            // scoreBox
            // 
            this.scoreBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreBox.BackColor = System.Drawing.Color.White;
            this.scoreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreBox.Location = new System.Drawing.Point(872, 345);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.ReadOnly = true;
            this.scoreBox.Size = new System.Drawing.Size(381, 106);
            this.scoreBox.TabIndex = 34;
            this.scoreBox.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Firebrick;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.btnQuitToMenuMenuItem,
            this.btnQuitToDesktopMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // btnQuitToMenuMenuItem
            // 
            this.btnQuitToMenuMenuItem.Name = "btnQuitToMenuMenuItem";
            this.btnQuitToMenuMenuItem.Size = new System.Drawing.Size(180, 22);
            this.btnQuitToMenuMenuItem.Text = "Quit to Menu";
            this.btnQuitToMenuMenuItem.Click += new System.EventHandler(this.btnQuitToMenuMenuItem_Click_1);
            // 
            // btnQuitToDesktopMenuItem
            // 
            this.btnQuitToDesktopMenuItem.Name = "btnQuitToDesktopMenuItem";
            this.btnQuitToDesktopMenuItem.Size = new System.Drawing.Size(163, 22);
            this.btnQuitToDesktopMenuItem.Text = "Quit to Desktop";
            this.btnQuitToDesktopMenuItem.Click += new System.EventHandler(this.btnQuitToDesktopMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsToolStripMenuItem1,
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.devToolsToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statisticsToolStripMenuItem1
            // 
            this.statisticsToolStripMenuItem1.Name = "statisticsToolStripMenuItem1";
            this.statisticsToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.statisticsToolStripMenuItem1.Text = "Statistics";
            this.statisticsToolStripMenuItem1.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // devToolsToolStripMenuItem
            // 
            this.devToolsToolStripMenuItem.Name = "devToolsToolStripMenuItem";
            this.devToolsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.devToolsToolStripMenuItem.Text = "Dev Tools";
            this.devToolsToolStripMenuItem.Click += new System.EventHandler(this.devToolsToolStripMenuItem_Click);
            // 
            // lblInventory
            // 
            this.lblInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInventory.BackColor = System.Drawing.Color.SteelBlue;
            this.lblInventory.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.lblInventory.Location = new System.Drawing.Point(872, 178);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(381, 35);
            this.lblInventory.TabIndex = 37;
            this.lblInventory.Text = "Inventory";
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.BackColor = System.Drawing.Color.SteelBlue;
            this.lblScore.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.lblScore.Location = new System.Drawing.Point(872, 315);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(381, 36);
            this.lblScore.TabIndex = 38;
            this.lblScore.Text = "Score";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProjectProgressCard1
            // 
            this.ProjectProgressCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProjectProgressCard1.BackColor = System.Drawing.Color.White;
            this.ProjectProgressCard1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectProgressCard1.Location = new System.Drawing.Point(25, 20);
            this.ProjectProgressCard1.Multiline = true;
            this.ProjectProgressCard1.Name = "ProjectProgressCard1";
            this.ProjectProgressCard1.ReadOnly = true;
            this.ProjectProgressCard1.Size = new System.Drawing.Size(130, 129);
            this.ProjectProgressCard1.TabIndex = 39;
            // 
            // ClaimProgressCard1
            // 
            this.ClaimProgressCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClaimProgressCard1.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.ClaimProgressCard1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClaimProgressCard1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClaimProgressCard1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClaimProgressCard1.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.ClaimProgressCard1.Location = new System.Drawing.Point(52, 158);
            this.ClaimProgressCard1.Name = "ClaimProgressCard1";
            this.ClaimProgressCard1.Size = new System.Drawing.Size(75, 23);
            this.ClaimProgressCard1.TabIndex = 43;
            this.ClaimProgressCard1.Text = "Claim Card";
            this.ClaimProgressCard1.UseVisualStyleBackColor = false;
            this.ClaimProgressCard1.Click += new System.EventHandler(this.ClaimProgressCard1_Click);
            // 
            // toolSlot1
            // 
            this.toolSlot1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toolSlot1.BackColor = System.Drawing.Color.White;
            this.toolSlot1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolSlot1.Location = new System.Drawing.Point(1203, 507);
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
            this.toolSlot2.BackColor = System.Drawing.Color.White;
            this.toolSlot2.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolSlot2.Location = new System.Drawing.Point(1203, 563);
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
            this.toolSlot3.BackColor = System.Drawing.Color.White;
            this.toolSlot3.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolSlot3.Location = new System.Drawing.Point(1203, 619);
            this.toolSlot3.Multiline = true;
            this.toolSlot3.Name = "toolSlot3";
            this.toolSlot3.ReadOnly = true;
            this.toolSlot3.Size = new System.Drawing.Size(50, 50);
            this.toolSlot3.TabIndex = 49;
            this.toolSlot3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToolMaker
            // 
            this.txtToolMaker.BackColor = System.Drawing.Color.White;
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
            // toolsPictureBox
            // 
            this.toolsPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toolsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("toolsPictureBox.Image")));
            this.toolsPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("toolsPictureBox.InitialImage")));
            this.toolsPictureBox.Location = new System.Drawing.Point(1202, 453);
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
            this.pictureBox1.Location = new System.Drawing.Point(1146, 583);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // ClaimFeaturesCard4
            // 
            this.ClaimFeaturesCard4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClaimFeaturesCard4.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.ClaimFeaturesCard4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClaimFeaturesCard4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClaimFeaturesCard4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClaimFeaturesCard4.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.ClaimFeaturesCard4.Location = new System.Drawing.Point(461, 200);
            this.ClaimFeaturesCard4.Name = "ClaimFeaturesCard4";
            this.ClaimFeaturesCard4.Size = new System.Drawing.Size(75, 23);
            this.ClaimFeaturesCard4.TabIndex = 68;
            this.ClaimFeaturesCard4.Text = "Claim Card";
            this.ClaimFeaturesCard4.UseVisualStyleBackColor = false;
            this.ClaimFeaturesCard4.Click += new System.EventHandler(this.ClaimFeaturesCard4_Click);
            // 
            // ClaimFeaturesCard3
            // 
            this.ClaimFeaturesCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClaimFeaturesCard3.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.ClaimFeaturesCard3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClaimFeaturesCard3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClaimFeaturesCard3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClaimFeaturesCard3.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.ClaimFeaturesCard3.Location = new System.Drawing.Point(326, 200);
            this.ClaimFeaturesCard3.Name = "ClaimFeaturesCard3";
            this.ClaimFeaturesCard3.Size = new System.Drawing.Size(75, 23);
            this.ClaimFeaturesCard3.TabIndex = 67;
            this.ClaimFeaturesCard3.Text = "Claim Card";
            this.ClaimFeaturesCard3.UseVisualStyleBackColor = false;
            this.ClaimFeaturesCard3.Click += new System.EventHandler(this.ClaimFeaturesCard3_Click);
            // 
            // ClaimFeaturesCard2
            // 
            this.ClaimFeaturesCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClaimFeaturesCard2.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.ClaimFeaturesCard2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClaimFeaturesCard2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClaimFeaturesCard2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClaimFeaturesCard2.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.ClaimFeaturesCard2.Location = new System.Drawing.Point(192, 200);
            this.ClaimFeaturesCard2.Name = "ClaimFeaturesCard2";
            this.ClaimFeaturesCard2.Size = new System.Drawing.Size(75, 23);
            this.ClaimFeaturesCard2.TabIndex = 66;
            this.ClaimFeaturesCard2.Text = "Claim Card";
            this.ClaimFeaturesCard2.UseVisualStyleBackColor = false;
            this.ClaimFeaturesCard2.Click += new System.EventHandler(this.ClaimFeaturesCard2_Click);
            // 
            // ClaimFeaturesCard1
            // 
            this.ClaimFeaturesCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClaimFeaturesCard1.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.ClaimFeaturesCard1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClaimFeaturesCard1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClaimFeaturesCard1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClaimFeaturesCard1.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.ClaimFeaturesCard1.Location = new System.Drawing.Point(52, 200);
            this.ClaimFeaturesCard1.Name = "ClaimFeaturesCard1";
            this.ClaimFeaturesCard1.Size = new System.Drawing.Size(75, 23);
            this.ClaimFeaturesCard1.TabIndex = 65;
            this.ClaimFeaturesCard1.Text = "Claim Card";
            this.ClaimFeaturesCard1.UseVisualStyleBackColor = false;
            this.ClaimFeaturesCard1.Click += new System.EventHandler(this.ClaimFeaturesCard1_Click);
            // 
            // AdditionalFeaturesTextBox4
            // 
            this.AdditionalFeaturesTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AdditionalFeaturesTextBox4.BackColor = System.Drawing.Color.White;
            this.AdditionalFeaturesTextBox4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalFeaturesTextBox4.Location = new System.Drawing.Point(433, 65);
            this.AdditionalFeaturesTextBox4.Multiline = true;
            this.AdditionalFeaturesTextBox4.Name = "AdditionalFeaturesTextBox4";
            this.AdditionalFeaturesTextBox4.ReadOnly = true;
            this.AdditionalFeaturesTextBox4.Size = new System.Drawing.Size(130, 129);
            this.AdditionalFeaturesTextBox4.TabIndex = 64;
            // 
            // AdditionalFeaturesTextBox3
            // 
            this.AdditionalFeaturesTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AdditionalFeaturesTextBox3.BackColor = System.Drawing.Color.White;
            this.AdditionalFeaturesTextBox3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalFeaturesTextBox3.Location = new System.Drawing.Point(297, 65);
            this.AdditionalFeaturesTextBox3.Multiline = true;
            this.AdditionalFeaturesTextBox3.Name = "AdditionalFeaturesTextBox3";
            this.AdditionalFeaturesTextBox3.ReadOnly = true;
            this.AdditionalFeaturesTextBox3.Size = new System.Drawing.Size(130, 129);
            this.AdditionalFeaturesTextBox3.TabIndex = 63;
            // 
            // AdditionalFeaturesTextBox2
            // 
            this.AdditionalFeaturesTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AdditionalFeaturesTextBox2.BackColor = System.Drawing.Color.White;
            this.AdditionalFeaturesTextBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalFeaturesTextBox2.Location = new System.Drawing.Point(161, 65);
            this.AdditionalFeaturesTextBox2.Multiline = true;
            this.AdditionalFeaturesTextBox2.Name = "AdditionalFeaturesTextBox2";
            this.AdditionalFeaturesTextBox2.ReadOnly = true;
            this.AdditionalFeaturesTextBox2.Size = new System.Drawing.Size(130, 129);
            this.AdditionalFeaturesTextBox2.TabIndex = 62;
            // 
            // AdditionalFeaturesTextBox1
            // 
            this.AdditionalFeaturesTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AdditionalFeaturesTextBox1.BackColor = System.Drawing.Color.White;
            this.AdditionalFeaturesTextBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalFeaturesTextBox1.Location = new System.Drawing.Point(25, 65);
            this.AdditionalFeaturesTextBox1.Multiline = true;
            this.AdditionalFeaturesTextBox1.Name = "AdditionalFeaturesTextBox1";
            this.AdditionalFeaturesTextBox1.ReadOnly = true;
            this.AdditionalFeaturesTextBox1.Size = new System.Drawing.Size(130, 129);
            this.AdditionalFeaturesTextBox1.TabIndex = 61;
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndTurn.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnEndTurn.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnEndTurn.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnEndTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndTurn.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnEndTurn.Location = new System.Drawing.Point(1022, 628);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(117, 41);
            this.btnEndTurn.TabIndex = 69;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = false;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // FeatureCardsCostLable
            // 
            this.FeatureCardsCostLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FeatureCardsCostLable.AutoSize = true;
            this.FeatureCardsCostLable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FeatureCardsCostLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeatureCardsCostLable.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.FeatureCardsCostLable.Location = new System.Drawing.Point(25, 18);
            this.FeatureCardsCostLable.Name = "FeatureCardsCostLable";
            this.FeatureCardsCostLable.Size = new System.Drawing.Size(84, 20);
            this.FeatureCardsCostLable.TabIndex = 70;
            this.FeatureCardsCostLable.Text = "Card Cost:";
            // 
            // FeatureCardsLabel1
            // 
            this.FeatureCardsLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FeatureCardsLabel1.AutoSize = true;
            this.FeatureCardsLabel1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FeatureCardsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeatureCardsLabel1.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.FeatureCardsLabel1.Location = new System.Drawing.Point(25, 44);
            this.FeatureCardsLabel1.Name = "FeatureCardsLabel1";
            this.FeatureCardsLabel1.Size = new System.Drawing.Size(130, 20);
            this.FeatureCardsLabel1.TabIndex = 71;
            this.FeatureCardsLabel1.Text = "Any 4 Resources";
            // 
            // FeatureCardsLabel2
            // 
            this.FeatureCardsLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FeatureCardsLabel2.AutoSize = true;
            this.FeatureCardsLabel2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FeatureCardsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeatureCardsLabel2.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.FeatureCardsLabel2.Location = new System.Drawing.Point(161, 44);
            this.FeatureCardsLabel2.Name = "FeatureCardsLabel2";
            this.FeatureCardsLabel2.Size = new System.Drawing.Size(130, 20);
            this.FeatureCardsLabel2.TabIndex = 72;
            this.FeatureCardsLabel2.Text = "Any 3 Resources";
            // 
            // FeatureCardsLabel3
            // 
            this.FeatureCardsLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FeatureCardsLabel3.AutoSize = true;
            this.FeatureCardsLabel3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FeatureCardsLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeatureCardsLabel3.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.FeatureCardsLabel3.Location = new System.Drawing.Point(297, 44);
            this.FeatureCardsLabel3.Name = "FeatureCardsLabel3";
            this.FeatureCardsLabel3.Size = new System.Drawing.Size(130, 20);
            this.FeatureCardsLabel3.TabIndex = 73;
            this.FeatureCardsLabel3.Text = "Any 2 Resources";
            // 
            // FeatureCardsLabel4
            // 
            this.FeatureCardsLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FeatureCardsLabel4.AutoSize = true;
            this.FeatureCardsLabel4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FeatureCardsLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeatureCardsLabel4.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.FeatureCardsLabel4.Location = new System.Drawing.Point(437, 44);
            this.FeatureCardsLabel4.Name = "FeatureCardsLabel4";
            this.FeatureCardsLabel4.Size = new System.Drawing.Size(122, 20);
            this.FeatureCardsLabel4.TabIndex = 74;
            this.FeatureCardsLabel4.Text = "Any 1 Resource";
            // 
            // ProjectFeaturesCardsGroupBox
            // 
            this.ProjectFeaturesCardsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProjectFeaturesCardsGroupBox.Controls.Add(this.AdditionalFeaturesTextBox4);
            this.ProjectFeaturesCardsGroupBox.Controls.Add(this.AdditionalFeaturesTextBox1);
            this.ProjectFeaturesCardsGroupBox.Controls.Add(this.FeatureCardsLabel4);
            this.ProjectFeaturesCardsGroupBox.Controls.Add(this.AdditionalFeaturesTextBox2);
            this.ProjectFeaturesCardsGroupBox.Controls.Add(this.FeatureCardsLabel3);
            this.ProjectFeaturesCardsGroupBox.Controls.Add(this.AdditionalFeaturesTextBox3);
            this.ProjectFeaturesCardsGroupBox.Controls.Add(this.FeatureCardsLabel2);
            this.ProjectFeaturesCardsGroupBox.Controls.Add(this.ClaimFeaturesCard1);
            this.ProjectFeaturesCardsGroupBox.Controls.Add(this.FeatureCardsLabel1);
            this.ProjectFeaturesCardsGroupBox.Controls.Add(this.ClaimFeaturesCard2);
            this.ProjectFeaturesCardsGroupBox.Controls.Add(this.FeatureCardsCostLable);
            this.ProjectFeaturesCardsGroupBox.Controls.Add(this.ClaimFeaturesCard3);
            this.ProjectFeaturesCardsGroupBox.Controls.Add(this.ClaimFeaturesCard4);
            this.ProjectFeaturesCardsGroupBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProjectFeaturesCardsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectFeaturesCardsGroupBox.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.ProjectFeaturesCardsGroupBox.Location = new System.Drawing.Point(12, 243);
            this.ProjectFeaturesCardsGroupBox.Name = "ProjectFeaturesCardsGroupBox";
            this.ProjectFeaturesCardsGroupBox.Size = new System.Drawing.Size(607, 233);
            this.ProjectFeaturesCardsGroupBox.TabIndex = 75;
            this.ProjectFeaturesCardsGroupBox.TabStop = false;
            this.ProjectFeaturesCardsGroupBox.Text = "Project Features Cards:";
            // 
            // ProjectProgressCardsGroupBox
            // 
            this.ProjectProgressCardsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProjectProgressCardsGroupBox.Controls.Add(this.ProjectProgressCard1);
            this.ProjectProgressCardsGroupBox.Controls.Add(this.ClaimProgressCard1);
            this.ProjectProgressCardsGroupBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProjectProgressCardsGroupBox.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.ProjectProgressCardsGroupBox.Location = new System.Drawing.Point(12, 482);
            this.ProjectProgressCardsGroupBox.Name = "ProjectProgressCardsGroupBox";
            this.ProjectProgressCardsGroupBox.Size = new System.Drawing.Size(217, 187);
            this.ProjectProgressCardsGroupBox.TabIndex = 76;
            this.ProjectProgressCardsGroupBox.TabStop = false;
            this.ProjectProgressCardsGroupBox.Text = "Project Progress Cards:";
            // 
            // btnSendDevs
            // 
            this.btnSendDevs.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSendDevs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendDevs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendDevs.Location = new System.Drawing.Point(172, 170);
            this.btnSendDevs.Name = "btnSendDevs";
            this.btnSendDevs.Size = new System.Drawing.Size(151, 23);
            this.btnSendDevs.TabIndex = 78;
            this.btnSendDevs.Text = "Send 2 Developers";
            this.btnSendDevs.UseVisualStyleBackColor = false;
            this.btnSendDevs.Click += new System.EventHandler(this.btnSendDevs_Click);
            // 
            // btnRecallDevs
            // 
            this.btnRecallDevs.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnRecallDevs.Enabled = false;
            this.btnRecallDevs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecallDevs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecallDevs.Location = new System.Drawing.Point(172, 199);
            this.btnRecallDevs.Name = "btnRecallDevs";
            this.btnRecallDevs.Size = new System.Drawing.Size(151, 23);
            this.btnRecallDevs.TabIndex = 79;
            this.btnRecallDevs.Text = "Recall Developers";
            this.btnRecallDevs.UseVisualStyleBackColor = false;
            this.btnRecallDevs.Click += new System.EventHandler(this.btnRecallDevs_Click);
            // 
            // lblRecruitStatus
            // 
            this.lblRecruitStatus.BackColor = System.Drawing.Color.White;
            this.lblRecruitStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecruitStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecruitStatus.Location = new System.Drawing.Point(127, 111);
            this.lblRecruitStatus.Name = "lblRecruitStatus";
            this.lblRecruitStatus.Size = new System.Drawing.Size(240, 53);
            this.lblRecruitStatus.TabIndex = 80;
            this.lblRecruitStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(204, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::InformationAgeProject.Properties.Settings.Default.FormsBackgroundColor;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblRecruitStatus);
            this.Controls.Add(this.btnRecallDevs);
            this.Controls.Add(this.btnSendDevs);
            this.Controls.Add(this.ProjectProgressCardsGroupBox);
            this.Controls.Add(this.ProjectFeaturesCardsGroupBox);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolMakerPictureBox);
            this.Controls.Add(this.toolsPictureBox);
            this.Controls.Add(this.btnSubtToolMaker);
            this.Controls.Add(this.btnAddToolMaker);
            this.Controls.Add(this.txtToolMaker);
            this.Controls.Add(this.toolSlot3);
            this.Controls.Add(this.toolSlot2);
            this.Controls.Add(this.toolSlot1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.txtDevelopers);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.txtBacklog);
            this.Controls.Add(this.btnDoTasks);
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
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblInventory);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "FormsBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information Age";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolMakerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ProjectFeaturesCardsGroupBox.ResumeLayout(false);
            this.ProjectFeaturesCardsGroupBox.PerformLayout();
            this.ProjectProgressCardsGroupBox.ResumeLayout(false);
            this.ProjectProgressCardsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button btnDoTasks;
        private System.Windows.Forms.TextBox txtBacklog;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtMed;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.TextBox txtDevelopers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.RichTextBox inventoryBox;
        public System.Windows.Forms.RichTextBox scoreBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnQuitToDesktopMenuItem;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblScore;
        public System.Windows.Forms.TextBox ProjectProgressCard1;
        public System.Windows.Forms.Button ClaimProgressCard1;
        public System.Windows.Forms.TextBox toolSlot1;
        public System.Windows.Forms.TextBox toolSlot2;
        public System.Windows.Forms.TextBox toolSlot3;
        private System.Windows.Forms.TextBox txtToolMaker;
        private System.Windows.Forms.Button btnAddToolMaker;
        private System.Windows.Forms.Button btnSubtToolMaker;
        private System.Windows.Forms.PictureBox toolsPictureBox;
        private System.Windows.Forms.PictureBox toolMakerPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button ClaimFeaturesCard4;
        public System.Windows.Forms.Button ClaimFeaturesCard3;
        public System.Windows.Forms.Button ClaimFeaturesCard2;
        public System.Windows.Forms.Button ClaimFeaturesCard1;
        public System.Windows.Forms.TextBox AdditionalFeaturesTextBox4;
        public System.Windows.Forms.TextBox AdditionalFeaturesTextBox3;
        public System.Windows.Forms.TextBox AdditionalFeaturesTextBox2;
        public System.Windows.Forms.TextBox AdditionalFeaturesTextBox1;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.ToolStripMenuItem btnQuitToMenuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label FeatureCardsCostLable;
        private System.Windows.Forms.Label FeatureCardsLabel1;
        private System.Windows.Forms.Label FeatureCardsLabel2;
        private System.Windows.Forms.Label FeatureCardsLabel3;
        private System.Windows.Forms.Label FeatureCardsLabel4;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.GroupBox ProjectFeaturesCardsGroupBox;
        private System.Windows.Forms.GroupBox ProjectProgressCardsGroupBox;
        private System.Windows.Forms.Button btnSendDevs;
        private System.Windows.Forms.Button btnRecallDevs;
        private System.Windows.Forms.Label lblRecruitStatus;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devToolsToolStripMenuItem;
    }
}

