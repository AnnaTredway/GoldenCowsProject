
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnResetSound = new System.Windows.Forms.Button();
            this.btnResetGraphics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGraphics
            // 
            this.btnGraphics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGraphics.BackColor = System.Drawing.Color.IndianRed;
            this.btnGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSound.BackColor = System.Drawing.Color.IndianRed;
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSound.Location = new System.Drawing.Point(403, 205);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(200, 40);
            this.btnSound.TabIndex = 2;
            this.btnSound.Text = "Sound";
            this.btnSound.UseVisualStyleBackColor = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(315, 151);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 51);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Options";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.IndianRed;
            this.btnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 398);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(200, 40);
            this.btnBackToMenu.TabIndex = 9;
            this.btnBackToMenu.Text = "Back";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Visible = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnResetSound
            // 
            this.btnResetSound.BackColor = System.Drawing.Color.IndianRed;
            this.btnResetSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSound.Location = new System.Drawing.Point(588, 398);
            this.btnResetSound.Name = "btnResetSound";
            this.btnResetSound.Size = new System.Drawing.Size(200, 40);
            this.btnResetSound.TabIndex = 10;
            this.btnResetSound.Text = "Reset Sound";
            this.btnResetSound.UseVisualStyleBackColor = false;
            this.btnResetSound.Visible = false;
            this.btnResetSound.Click += new System.EventHandler(this.btnResetSound_Click);
            // 
            // btnResetGraphics
            // 
            this.btnResetGraphics.BackColor = System.Drawing.Color.IndianRed;
            this.btnResetGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGraphics.Location = new System.Drawing.Point(588, 352);
            this.btnResetGraphics.Name = "btnResetGraphics";
            this.btnResetGraphics.Size = new System.Drawing.Size(200, 40);
            this.btnResetGraphics.TabIndex = 11;
            this.btnResetGraphics.Text = "Reset \"Graphics\"";
            this.btnResetGraphics.UseVisualStyleBackColor = false;
            this.btnResetGraphics.Visible = false;
            this.btnResetGraphics.Click += new System.EventHandler(this.btnResetGraphics_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResetGraphics);
            this.Controls.Add(this.btnResetSound);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnGraphics);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnResetSound;
        private System.Windows.Forms.Button btnResetGraphics;
    }
}