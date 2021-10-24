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
            this.pnlTeamNames.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Location = new System.Drawing.Point(296, 177);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(200, 40);
            this.btnPlayGame.TabIndex = 0;
            this.btnPlayGame.Text = "Play";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(241, 123);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(326, 51);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Information Age";
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(296, 223);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(200, 40);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(296, 269);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(200, 40);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // radio2Players
            // 
            this.radio2Players.AutoSize = true;
            this.radio2Players.Location = new System.Drawing.Point(361, 59);
            this.radio2Players.Name = "radio2Players";
            this.radio2Players.Size = new System.Drawing.Size(68, 17);
            this.radio2Players.TabIndex = 4;
            this.radio2Players.TabStop = true;
            this.radio2Players.Text = "2 Players";
            this.radio2Players.UseVisualStyleBackColor = true;
            this.radio2Players.Visible = false;
            // 
            // radio3Players
            // 
            this.radio3Players.AutoSize = true;
            this.radio3Players.Location = new System.Drawing.Point(361, 82);
            this.radio3Players.Name = "radio3Players";
            this.radio3Players.Size = new System.Drawing.Size(68, 17);
            this.radio3Players.TabIndex = 5;
            this.radio3Players.TabStop = true;
            this.radio3Players.Text = "3 Players";
            this.radio3Players.UseVisualStyleBackColor = true;
            this.radio3Players.Visible = false;
            // 
            // radio4Players
            // 
            this.radio4Players.AutoSize = true;
            this.radio4Players.Location = new System.Drawing.Point(361, 105);
            this.radio4Players.Name = "radio4Players";
            this.radio4Players.Size = new System.Drawing.Size(68, 17);
            this.radio4Players.TabIndex = 6;
            this.radio4Players.TabStop = true;
            this.radio4Players.Text = "4 Players";
            this.radio4Players.UseVisualStyleBackColor = true;
            this.radio4Players.Visible = false;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(588, 398);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(200, 40);
            this.btnStartGame.TabIndex = 7;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Visible = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.Location = new System.Drawing.Point(12, 398);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(200, 40);
            this.btnBack1.TabIndex = 8;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Visible = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.Location = new System.Drawing.Point(168, 5);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(510, 51);
            this.lblPlayers.TabIndex = 9;
            this.lblPlayers.Text = "Select Number of Players";
            this.lblPlayers.Visible = false;
            // 
            // rtxtTeamName1
            // 
            this.rtxtTeamName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTeamName1.Location = new System.Drawing.Point(3, 16);
            this.rtxtTeamName1.Name = "rtxtTeamName1";
            this.rtxtTeamName1.Size = new System.Drawing.Size(121, 25);
            this.rtxtTeamName1.TabIndex = 10;
            this.rtxtTeamName1.Text = "";
            // 
            // rtxtTeamName2
            // 
            this.rtxtTeamName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTeamName2.Location = new System.Drawing.Point(3, 60);
            this.rtxtTeamName2.Name = "rtxtTeamName2";
            this.rtxtTeamName2.Size = new System.Drawing.Size(121, 25);
            this.rtxtTeamName2.TabIndex = 11;
            this.rtxtTeamName2.Text = "";
            // 
            // rtxtTeamName3
            // 
            this.rtxtTeamName3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTeamName3.Location = new System.Drawing.Point(3, 104);
            this.rtxtTeamName3.Name = "rtxtTeamName3";
            this.rtxtTeamName3.Size = new System.Drawing.Size(121, 25);
            this.rtxtTeamName3.TabIndex = 12;
            this.rtxtTeamName3.Text = "";
            // 
            // rtxtTeamName4
            // 
            this.rtxtTeamName4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTeamName4.Location = new System.Drawing.Point(3, 148);
            this.rtxtTeamName4.Name = "rtxtTeamName4";
            this.rtxtTeamName4.Size = new System.Drawing.Size(121, 25);
            this.rtxtTeamName4.TabIndex = 13;
            this.rtxtTeamName4.Text = "";
            // 
            // lblPlayer1Team
            // 
            this.lblPlayer1Team.AutoSize = true;
            this.lblPlayer1Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Team.Location = new System.Drawing.Point(3, 0);
            this.lblPlayer1Team.Name = "lblPlayer1Team";
            this.lblPlayer1Team.Size = new System.Drawing.Size(124, 13);
            this.lblPlayer1Team.TabIndex = 14;
            this.lblPlayer1Team.Text = "Player 1 Team Name";
            // 
            // lblPlayer2Team
            // 
            this.lblPlayer2Team.AutoSize = true;
            this.lblPlayer2Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Team.Location = new System.Drawing.Point(0, 44);
            this.lblPlayer2Team.Name = "lblPlayer2Team";
            this.lblPlayer2Team.Size = new System.Drawing.Size(124, 13);
            this.lblPlayer2Team.TabIndex = 15;
            this.lblPlayer2Team.Text = "Player 2 Team Name";
            // 
            // lblPlayer3Team
            // 
            this.lblPlayer3Team.AutoSize = true;
            this.lblPlayer3Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer3Team.Location = new System.Drawing.Point(0, 88);
            this.lblPlayer3Team.Name = "lblPlayer3Team";
            this.lblPlayer3Team.Size = new System.Drawing.Size(124, 13);
            this.lblPlayer3Team.TabIndex = 16;
            this.lblPlayer3Team.Text = "Player 3 Team Name";
            // 
            // lblPlayer4Team
            // 
            this.lblPlayer4Team.AutoSize = true;
            this.lblPlayer4Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer4Team.Location = new System.Drawing.Point(0, 132);
            this.lblPlayer4Team.Name = "lblPlayer4Team";
            this.lblPlayer4Team.Size = new System.Drawing.Size(124, 13);
            this.lblPlayer4Team.TabIndex = 17;
            this.lblPlayer4Team.Text = "Player 4 Team Name";
            // 
            // pnlTeamNames
            // 
            this.pnlTeamNames.Controls.Add(this.lblPlayer4Team);
            this.pnlTeamNames.Controls.Add(this.lblPlayer1Team);
            this.pnlTeamNames.Controls.Add(this.rtxtTeamName2);
            this.pnlTeamNames.Controls.Add(this.rtxtTeamName1);
            this.pnlTeamNames.Controls.Add(this.lblPlayer2Team);
            this.pnlTeamNames.Controls.Add(this.rtxtTeamName4);
            this.pnlTeamNames.Controls.Add(this.lblPlayer3Team);
            this.pnlTeamNames.Controls.Add(this.rtxtTeamName3);
            this.pnlTeamNames.Location = new System.Drawing.Point(660, 59);
            this.pnlTeamNames.Name = "pnlTeamNames";
            this.pnlTeamNames.Size = new System.Drawing.Size(128, 181);
            this.pnlTeamNames.TabIndex = 19;
            this.pnlTeamNames.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlTeamNames);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.radio4Players);
            this.Controls.Add(this.radio3Players);
            this.Controls.Add(this.radio2Players);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPlayGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information Age - Main Menu";
            this.pnlTeamNames.ResumeLayout(false);
            this.pnlTeamNames.PerformLayout();
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
    }
}