
namespace InformationAgeProject
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.btnGraphics = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.btnResetSound = new System.Windows.Forms.Button();
            this.btnResetGraphics = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnButtonColor = new System.Windows.Forms.Button();
            this.lblGraphics = new System.Windows.Forms.Label();
            this.lblSound = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnChangeButtonTextColor = new System.Windows.Forms.Button();
            this.btnChangeTextColor = new System.Windows.Forms.Button();
            this.musicVolumeScrollBar = new System.Windows.Forms.TrackBar();
            this.effectsVolumeScrollBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolumeScrollBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectsVolumeScrollBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGraphics
            // 
            this.btnGraphics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGraphics.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnGraphics.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnGraphics.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraphics.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnGraphics.Location = new System.Drawing.Point(197, 205);
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.Size = new System.Drawing.Size(200, 40);
            this.btnGraphics.TabIndex = 1;
            this.btnGraphics.Text = "\"Graphics\"";
            this.btnGraphics.UseVisualStyleBackColor = false;
            this.btnGraphics.Click += new System.EventHandler(this.btnGraphics_Click);
            // 
            // btnSound
            // 
            this.btnSound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSound.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnSound.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSound.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSound.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnSound.Location = new System.Drawing.Point(403, 205);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(200, 40);
            this.btnSound.TabIndex = 2;
            this.btnSound.Text = "Sound";
            this.btnSound.UseVisualStyleBackColor = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOptions.AutoSize = true;
            this.lblOptions.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.lblOptions.Location = new System.Drawing.Point(315, 120);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(171, 51);
            this.lblOptions.TabIndex = 3;
            this.lblOptions.Text = "Options";
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackToMainMenu.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnBackToMainMenu.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBackToMainMenu.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainMenu.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnBackToMainMenu.Location = new System.Drawing.Point(300, 398);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(200, 40);
            this.btnBackToMainMenu.TabIndex = 9;
            this.btnBackToMainMenu.Text = "Back";
            this.btnBackToMainMenu.UseVisualStyleBackColor = false;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // btnResetSound
            // 
            this.btnResetSound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetSound.BackColor = System.Drawing.Color.IndianRed;
            this.btnResetSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSound.ForeColor = System.Drawing.Color.Black;
            this.btnResetSound.Location = new System.Drawing.Point(638, 408);
            this.btnResetSound.Name = "btnResetSound";
            this.btnResetSound.Size = new System.Drawing.Size(150, 30);
            this.btnResetSound.TabIndex = 10;
            this.btnResetSound.Text = "Reset Sound";
            this.btnResetSound.UseVisualStyleBackColor = false;
            this.btnResetSound.Click += new System.EventHandler(this.btnResetSound_Click);
            // 
            // btnResetGraphics
            // 
            this.btnResetGraphics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetGraphics.BackColor = System.Drawing.Color.IndianRed;
            this.btnResetGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGraphics.ForeColor = System.Drawing.Color.Black;
            this.btnResetGraphics.Location = new System.Drawing.Point(638, 372);
            this.btnResetGraphics.Name = "btnResetGraphics";
            this.btnResetGraphics.Size = new System.Drawing.Size(150, 30);
            this.btnResetGraphics.TabIndex = 11;
            this.btnResetGraphics.Text = "Reset \"Graphics\"";
            this.btnResetGraphics.UseVisualStyleBackColor = false;
            this.btnResetGraphics.Click += new System.EventHandler(this.btnResetGraphics_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackColor.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnBackColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBackColor.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackColor.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnBackColor.Location = new System.Drawing.Point(295, 205);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(210, 40);
            this.btnBackColor.TabIndex = 12;
            this.btnBackColor.Text = "Change Background Color";
            this.btnBackColor.UseVisualStyleBackColor = false;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // btnButtonColor
            // 
            this.btnButtonColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnButtonColor.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnButtonColor.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnButtonColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnButtonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButtonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButtonColor.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnButtonColor.Location = new System.Drawing.Point(295, 297);
            this.btnButtonColor.Name = "btnButtonColor";
            this.btnButtonColor.Size = new System.Drawing.Size(210, 40);
            this.btnButtonColor.TabIndex = 13;
            this.btnButtonColor.Text = "Change Button Color";
            this.btnButtonColor.UseVisualStyleBackColor = false;
            this.btnButtonColor.Click += new System.EventHandler(this.btnButtonColor_Click);
            // 
            // lblGraphics
            // 
            this.lblGraphics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGraphics.AutoSize = true;
            this.lblGraphics.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraphics.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.lblGraphics.Location = new System.Drawing.Point(223, 120);
            this.lblGraphics.Name = "lblGraphics";
            this.lblGraphics.Size = new System.Drawing.Size(355, 51);
            this.lblGraphics.TabIndex = 14;
            this.lblGraphics.Text = "Graphics Options";
            // 
            // lblSound
            // 
            this.lblSound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSound.AutoSize = true;
            this.lblSound.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSound.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.lblSound.Location = new System.Drawing.Point(247, 120);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(307, 51);
            this.lblSound.TabIndex = 15;
            this.lblSound.Text = "Sound Options";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnBack.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBack.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnBack.Location = new System.Drawing.Point(300, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 40);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChangeButtonTextColor
            // 
            this.btnChangeButtonTextColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeButtonTextColor.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnChangeButtonTextColor.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnChangeButtonTextColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnChangeButtonTextColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeButtonTextColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeButtonTextColor.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnChangeButtonTextColor.Location = new System.Drawing.Point(295, 343);
            this.btnChangeButtonTextColor.Name = "btnChangeButtonTextColor";
            this.btnChangeButtonTextColor.Size = new System.Drawing.Size(210, 40);
            this.btnChangeButtonTextColor.TabIndex = 17;
            this.btnChangeButtonTextColor.Text = "Change Button Text Color";
            this.btnChangeButtonTextColor.UseVisualStyleBackColor = false;
            this.btnChangeButtonTextColor.Click += new System.EventHandler(this.btnChangeButtonTextColor_Click);
            // 
            // btnChangeTextColor
            // 
            this.btnChangeTextColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeTextColor.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnChangeTextColor.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnChangeTextColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnChangeTextColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeTextColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTextColor.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnChangeTextColor.Location = new System.Drawing.Point(295, 251);
            this.btnChangeTextColor.Name = "btnChangeTextColor";
            this.btnChangeTextColor.Size = new System.Drawing.Size(210, 40);
            this.btnChangeTextColor.TabIndex = 18;
            this.btnChangeTextColor.Text = "Change Text Color";
            this.btnChangeTextColor.UseVisualStyleBackColor = false;
            this.btnChangeTextColor.Click += new System.EventHandler(this.btnChangeTextColor_Click);
            // 
            // musicVolumeScrollBar
            // 
            this.musicVolumeScrollBar.Location = new System.Drawing.Point(200, 256);
            this.musicVolumeScrollBar.Maximum = 100;
            this.musicVolumeScrollBar.Name = "musicVolumeScrollBar";
            this.musicVolumeScrollBar.Size = new System.Drawing.Size(400, 45);
            this.musicVolumeScrollBar.TabIndex = 19;
            this.musicVolumeScrollBar.Scroll += new System.EventHandler(this.musicVolumeScrollBar_Scroll);
            // 
            // effectsVolumeScrollBar
            // 
            this.effectsVolumeScrollBar.Location = new System.Drawing.Point(200, 205);
            this.effectsVolumeScrollBar.Maximum = 100;
            this.effectsVolumeScrollBar.Name = "effectsVolumeScrollBar";
            this.effectsVolumeScrollBar.Size = new System.Drawing.Size(400, 45);
            this.effectsVolumeScrollBar.TabIndex = 20;
            this.effectsVolumeScrollBar.Scroll += new System.EventHandler(this.effectsVolumeScrollBar_Scroll);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::InformationAgeProject.Properties.Settings.Default.FormsBackgroundColor;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.effectsVolumeScrollBar);
            this.Controls.Add(this.musicVolumeScrollBar);
            this.Controls.Add(this.btnChangeTextColor);
            this.Controls.Add(this.btnChangeButtonTextColor);
            this.Controls.Add(this.btnResetGraphics);
            this.Controls.Add(this.btnResetSound);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnGraphics);
            this.Controls.Add(this.btnButtonColor);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.lblGraphics);
            this.Controls.Add(this.btnBack);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "FormsBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicVolumeScrollBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectsVolumeScrollBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Button btnResetSound;
        private System.Windows.Forms.Button btnResetGraphics;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Button btnButtonColor;
        private System.Windows.Forms.Label lblGraphics;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnChangeButtonTextColor;
        private System.Windows.Forms.Button btnChangeTextColor;
        private System.Windows.Forms.TrackBar musicVolumeScrollBar;
        private System.Windows.Forms.TrackBar effectsVolumeScrollBar;
    }
}