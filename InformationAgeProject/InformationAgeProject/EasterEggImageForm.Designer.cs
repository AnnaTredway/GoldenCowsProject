
namespace InformationAgeProject
{
    partial class EasterEggImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasterEggImageForm));
            this.easterEggPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.easterEggPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // easterEggPictureBox
            // 
            this.easterEggPictureBox.InitialImage = null;
            this.easterEggPictureBox.Location = new System.Drawing.Point(12, 12);
            this.easterEggPictureBox.Name = "easterEggPictureBox";
            this.easterEggPictureBox.Size = new System.Drawing.Size(1240, 657);
            this.easterEggPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.easterEggPictureBox.TabIndex = 82;
            this.easterEggPictureBox.TabStop = false;
            // 
            // EasterEggImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::InformationAgeProject.Properties.Settings.Default.FormsBackgroundColor;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.easterEggPictureBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "FormsBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EasterEggImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasterEggImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.easterEggPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox easterEggPictureBox;
    }
}