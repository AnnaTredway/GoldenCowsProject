namespace InformationAgeProject
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.radio2Players = new System.Windows.Forms.RadioButton();
            this.radio3Players = new System.Windows.Forms.RadioButton();
            this.radio4Players = new System.Windows.Forms.RadioButton();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.rtxtTeamName1 = new System.Windows.Forms.RichTextBox();
            this.rtxtTeamName2 = new System.Windows.Forms.RichTextBox();
            this.rtxtTeamName3 = new System.Windows.Forms.RichTextBox();
            this.rtxtTeamName4 = new System.Windows.Forms.RichTextBox();
            this.lblPlayer1Team = new System.Windows.Forms.Label();
            this.lblPlayer2Team = new System.Windows.Forms.Label();
            this.lblPlayer3Team = new System.Windows.Forms.Label();
            this.lblPlayer4Team = new System.Windows.Forms.Label();
            this.pnlTeamNames = new System.Windows.Forms.Panel();
            this.pnlSelectPlayers = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.lblLoading = new System.Windows.Forms.Label();
            this.btnEasterEgg1 = new System.Windows.Forms.Button();
            this.pnlTeamNames.SuspendLayout();
            this.pnlSelectPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayGame.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnPlayGame.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnPlayGame.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnPlayGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayGame.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnPlayGame.Location = new System.Drawing.Point(300, 177);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(200, 40);
            this.btnPlayGame.TabIndex = 0;
            this.btnPlayGame.Text = "Play";
            this.btnPlayGame.UseVisualStyleBackColor = false;
            this.btnPlayGame.Visible = false;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.lblTitle.Location = new System.Drawing.Point(237, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(326, 51);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Information Age";
            this.lblTitle.Visible = false;
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOptions.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnOptions.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnOptions.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnOptions.Location = new System.Drawing.Point(300, 223);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(200, 40);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Visible = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuit.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnQuit.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnQuit.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnQuit.Location = new System.Drawing.Point(300, 315);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(200, 40);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Visible = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // radio2Players
            // 
            this.radio2Players.AutoSize = true;
            this.radio2Players.BackColor = System.Drawing.Color.Transparent;
            this.radio2Players.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radio2Players.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2Players.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.radio2Players.Location = new System.Drawing.Point(213, 58);
            this.radio2Players.Name = "radio2Players";
            this.radio2Players.Size = new System.Drawing.Size(91, 24);
            this.radio2Players.TabIndex = 4;
            this.radio2Players.TabStop = true;
            this.radio2Players.Text = "2 Players";
            this.radio2Players.UseVisualStyleBackColor = false;
            // 
            // radio3Players
            // 
            this.radio3Players.AutoSize = true;
            this.radio3Players.BackColor = System.Drawing.Color.Transparent;
            this.radio3Players.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radio3Players.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio3Players.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.radio3Players.Location = new System.Drawing.Point(213, 88);
            this.radio3Players.Name = "radio3Players";
            this.radio3Players.Size = new System.Drawing.Size(91, 24);
            this.radio3Players.TabIndex = 5;
            this.radio3Players.TabStop = true;
            this.radio3Players.Text = "3 Players";
            this.radio3Players.UseVisualStyleBackColor = false;
            // 
            // radio4Players
            // 
            this.radio4Players.AutoSize = true;
            this.radio4Players.BackColor = System.Drawing.Color.Transparent;
            this.radio4Players.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radio4Players.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio4Players.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.radio4Players.Location = new System.Drawing.Point(213, 118);
            this.radio4Players.Name = "radio4Players";
            this.radio4Players.Size = new System.Drawing.Size(91, 24);
            this.radio4Players.TabIndex = 6;
            this.radio4Players.TabStop = true;
            this.radio4Players.Text = "4 Players";
            this.radio4Players.UseVisualStyleBackColor = false;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartGame.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnStartGame.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnStartGame.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnStartGame.Location = new System.Drawing.Point(588, 398);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(200, 40);
            this.btnStartGame.TabIndex = 7;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Visible = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack1.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnBack1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBack1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack1.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnBack1.Location = new System.Drawing.Point(12, 398);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(200, 40);
            this.btnBack1.TabIndex = 8;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Visible = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.lblPlayers.Location = new System.Drawing.Point(3, 4);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(510, 51);
            this.lblPlayers.TabIndex = 9;
            this.lblPlayers.Text = "Select Number of Players";
            // 
            // rtxtTeamName1
            // 
            this.rtxtTeamName1.BackColor = System.Drawing.Color.White;
            this.rtxtTeamName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTeamName1.Location = new System.Drawing.Point(3, 19);
            this.rtxtTeamName1.Name = "rtxtTeamName1";
            this.rtxtTeamName1.Size = new System.Drawing.Size(200, 25);
            this.rtxtTeamName1.TabIndex = 10;
            this.rtxtTeamName1.Text = "";
            // 
            // rtxtTeamName2
            // 
            this.rtxtTeamName2.BackColor = System.Drawing.Color.White;
            this.rtxtTeamName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTeamName2.Location = new System.Drawing.Point(3, 63);
            this.rtxtTeamName2.Name = "rtxtTeamName2";
            this.rtxtTeamName2.Size = new System.Drawing.Size(200, 25);
            this.rtxtTeamName2.TabIndex = 11;
            this.rtxtTeamName2.Text = "";
            // 
            // rtxtTeamName3
            // 
            this.rtxtTeamName3.BackColor = System.Drawing.Color.White;
            this.rtxtTeamName3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTeamName3.Location = new System.Drawing.Point(3, 107);
            this.rtxtTeamName3.Name = "rtxtTeamName3";
            this.rtxtTeamName3.Size = new System.Drawing.Size(200, 25);
            this.rtxtTeamName3.TabIndex = 12;
            this.rtxtTeamName3.Text = "";
            // 
            // rtxtTeamName4
            // 
            this.rtxtTeamName4.BackColor = System.Drawing.Color.White;
            this.rtxtTeamName4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTeamName4.Location = new System.Drawing.Point(3, 151);
            this.rtxtTeamName4.Name = "rtxtTeamName4";
            this.rtxtTeamName4.Size = new System.Drawing.Size(200, 25);
            this.rtxtTeamName4.TabIndex = 13;
            this.rtxtTeamName4.Text = "";
            // 
            // lblPlayer1Team
            // 
            this.lblPlayer1Team.AutoSize = true;
            this.lblPlayer1Team.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPlayer1Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Team.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.lblPlayer1Team.Location = new System.Drawing.Point(41, 4);
            this.lblPlayer1Team.Name = "lblPlayer1Team";
            this.lblPlayer1Team.Size = new System.Drawing.Size(124, 13);
            this.lblPlayer1Team.TabIndex = 14;
            this.lblPlayer1Team.Text = "Player 1 Team Name";
            // 
            // lblPlayer2Team
            // 
            this.lblPlayer2Team.AutoSize = true;
            this.lblPlayer2Team.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPlayer2Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Team.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.lblPlayer2Team.Location = new System.Drawing.Point(41, 47);
            this.lblPlayer2Team.Name = "lblPlayer2Team";
            this.lblPlayer2Team.Size = new System.Drawing.Size(124, 13);
            this.lblPlayer2Team.TabIndex = 15;
            this.lblPlayer2Team.Text = "Player 2 Team Name";
            // 
            // lblPlayer3Team
            // 
            this.lblPlayer3Team.AutoSize = true;
            this.lblPlayer3Team.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPlayer3Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer3Team.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.lblPlayer3Team.Location = new System.Drawing.Point(41, 91);
            this.lblPlayer3Team.Name = "lblPlayer3Team";
            this.lblPlayer3Team.Size = new System.Drawing.Size(124, 13);
            this.lblPlayer3Team.TabIndex = 16;
            this.lblPlayer3Team.Text = "Player 3 Team Name";
            // 
            // lblPlayer4Team
            // 
            this.lblPlayer4Team.AutoSize = true;
            this.lblPlayer4Team.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPlayer4Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer4Team.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.lblPlayer4Team.Location = new System.Drawing.Point(41, 135);
            this.lblPlayer4Team.Name = "lblPlayer4Team";
            this.lblPlayer4Team.Size = new System.Drawing.Size(124, 13);
            this.lblPlayer4Team.TabIndex = 17;
            this.lblPlayer4Team.Text = "Player 4 Team Name";
            // 
            // pnlTeamNames
            // 
            this.pnlTeamNames.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTeamNames.Controls.Add(this.lblPlayer4Team);
            this.pnlTeamNames.Controls.Add(this.lblPlayer1Team);
            this.pnlTeamNames.Controls.Add(this.rtxtTeamName2);
            this.pnlTeamNames.Controls.Add(this.rtxtTeamName1);
            this.pnlTeamNames.Controls.Add(this.lblPlayer2Team);
            this.pnlTeamNames.Controls.Add(this.rtxtTeamName4);
            this.pnlTeamNames.Controls.Add(this.lblPlayer3Team);
            this.pnlTeamNames.Controls.Add(this.rtxtTeamName3);
            this.pnlTeamNames.Location = new System.Drawing.Point(297, 177);
            this.pnlTeamNames.Name = "pnlTeamNames";
            this.pnlTeamNames.Size = new System.Drawing.Size(206, 180);
            this.pnlTeamNames.TabIndex = 19;
            this.pnlTeamNames.Visible = false;
            // 
            // pnlSelectPlayers
            // 
            this.pnlSelectPlayers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlSelectPlayers.Controls.Add(this.lblPlayers);
            this.pnlSelectPlayers.Controls.Add(this.radio2Players);
            this.pnlSelectPlayers.Controls.Add(this.radio3Players);
            this.pnlSelectPlayers.Controls.Add(this.radio4Players);
            this.pnlSelectPlayers.Location = new System.Drawing.Point(142, 5);
            this.pnlSelectPlayers.Name = "pnlSelectPlayers";
            this.pnlSelectPlayers.Size = new System.Drawing.Size(517, 139);
            this.pnlSelectPlayers.TabIndex = 20;
            this.pnlSelectPlayers.Visible = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewGame.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnNewGame.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnNewGame.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnNewGame.Location = new System.Drawing.Point(197, 205);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(200, 40);
            this.btnNewGame.TabIndex = 21;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Visible = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadGame.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnLoadGame.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnLoadGame.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGame.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnLoadGame.Location = new System.Drawing.Point(403, 205);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(200, 40);
            this.btnLoadGame.TabIndex = 22;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = false;
            this.btnLoadGame.Visible = false;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackToMainMenu.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnBackToMainMenu.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBackToMainMenu.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainMenu.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnBackToMainMenu.Location = new System.Drawing.Point(300, 363);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(200, 40);
            this.btnBackToMainMenu.TabIndex = 23;
            this.btnBackToMainMenu.Text = "Back";
            this.btnBackToMainMenu.UseVisualStyleBackColor = false;
            this.btnBackToMainMenu.Visible = false;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInstructions.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnInstructions.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnInstructions.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnInstructions.Location = new System.Drawing.Point(300, 269);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(200, 40);
            this.btnInstructions.TabIndex = 2;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Visible = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoading.AutoSize = true;
            this.lblLoading.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.lblLoading.Location = new System.Drawing.Point(237, 187);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(326, 76);
            this.lblLoading.TabIndex = 25;
            this.lblLoading.Text = "Loading...";
            // 
            // btnEasterEgg1
            // 
            this.btnEasterEgg1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEasterEgg1.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnEasterEgg1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnEasterEgg1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnEasterEgg1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasterEgg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasterEgg1.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnEasterEgg1.Location = new System.Drawing.Point(12, 433);
            this.btnEasterEgg1.Name = "btnEasterEgg1";
            this.btnEasterEgg1.Size = new System.Drawing.Size(5, 5);
            this.btnEasterEgg1.TabIndex = 26;
            this.btnEasterEgg1.Text = "Back";
            this.btnEasterEgg1.UseVisualStyleBackColor = false;
            this.btnEasterEgg1.Visible = false;
            this.btnEasterEgg1.Click += new System.EventHandler(this.btnEasterEgg1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::InformationAgeProject.Properties.Settings.Default.FormsBackgroundColor;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEasterEgg1);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pnlSelectPlayers);
            this.Controls.Add(this.pnlTeamNames);
            this.Controls.Add(this.lblLoading);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "FormsBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information Age - Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.pnlTeamNames.ResumeLayout(false);
            this.pnlTeamNames.PerformLayout();
            this.pnlSelectPlayers.ResumeLayout(false);
            this.pnlSelectPlayers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.RadioButton radio2Players;
        private System.Windows.Forms.RadioButton radio3Players;
        private System.Windows.Forms.RadioButton radio4Players;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.RichTextBox rtxtTeamName1;
        private System.Windows.Forms.RichTextBox rtxtTeamName2;
        private System.Windows.Forms.RichTextBox rtxtTeamName3;
        private System.Windows.Forms.RichTextBox rtxtTeamName4;
        private System.Windows.Forms.Label lblPlayer1Team;
        private System.Windows.Forms.Label lblPlayer2Team;
        private System.Windows.Forms.Label lblPlayer3Team;
        private System.Windows.Forms.Label lblPlayer4Team;
        private System.Windows.Forms.Panel pnlTeamNames;
        private System.Windows.Forms.Panel pnlSelectPlayers;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Button btnEasterEgg1;
    }
}