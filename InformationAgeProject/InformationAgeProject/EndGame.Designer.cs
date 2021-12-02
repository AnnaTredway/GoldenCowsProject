
namespace InformationAgeProject
{
    partial class EndGame
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
            this.txtWinningPlayer = new System.Windows.Forms.TextBox();
            this.txtHighestScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.ExitGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWinningPlayer
            // 
            this.txtWinningPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinningPlayer.Location = new System.Drawing.Point(90, 68);
            this.txtWinningPlayer.Multiline = true;
            this.txtWinningPlayer.Name = "txtWinningPlayer";
            this.txtWinningPlayer.ReadOnly = true;
            this.txtWinningPlayer.Size = new System.Drawing.Size(400, 50);
            this.txtWinningPlayer.TabIndex = 0;
            this.txtWinningPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHighestScore
            // 
            this.txtHighestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighestScore.Location = new System.Drawing.Point(180, 185);
            this.txtHighestScore.Multiline = true;
            this.txtHighestScore.Name = "txtHighestScore";
            this.txtHighestScore.ReadOnly = true;
            this.txtHighestScore.Size = new System.Drawing.Size(200, 50);
            this.txtHighestScore.TabIndex = 1;
            this.txtHighestScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.label1.Location = new System.Drawing.Point(202, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Winning Player:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.label2.Location = new System.Drawing.Point(223, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "-- Score --";
            // 
            // ReturnToMenuButton
            // 
            this.ReturnToMenuButton.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.ReturnToMenuButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ReturnToMenuButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ReturnToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnToMenuButton.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.ReturnToMenuButton.Location = new System.Drawing.Point(12, 257);
            this.ReturnToMenuButton.Name = "ReturnToMenuButton";
            this.ReturnToMenuButton.Size = new System.Drawing.Size(96, 23);
            this.ReturnToMenuButton.TabIndex = 4;
            this.ReturnToMenuButton.Text = "Return to Menu";
            this.ReturnToMenuButton.UseVisualStyleBackColor = false;
            this.ReturnToMenuButton.Click += new System.EventHandler(this.ReturnToMenuButton_Click);
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.ExitGameButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ExitGameButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ExitGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitGameButton.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.ExitGameButton.Location = new System.Drawing.Point(508, 257);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(75, 23);
            this.ExitGameButton.TabIndex = 5;
            this.ExitGameButton.Text = "Exit Game";
            this.ExitGameButton.UseVisualStyleBackColor = false;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitGameButton_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::InformationAgeProject.Properties.Settings.Default.FormsBackgroundColor;
            this.ClientSize = new System.Drawing.Size(595, 292);
            this.Controls.Add(this.ExitGameButton);
            this.Controls.Add(this.ReturnToMenuButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHighestScore);
            this.Controls.Add(this.txtWinningPlayer);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "FormsBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "EndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winning Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EndGame_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtWinningPlayer;
        public System.Windows.Forms.TextBox txtHighestScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ReturnToMenuButton;
        private System.Windows.Forms.Button ExitGameButton;
    }
}