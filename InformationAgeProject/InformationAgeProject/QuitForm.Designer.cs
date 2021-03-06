namespace InformationAgeProject
{
    partial class QuitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuitForm));
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblQuit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnYes.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnYes.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnYes.Location = new System.Drawing.Point(49, 69);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 30);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.btnNo.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnNo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.btnNo.Location = new System.Drawing.Point(155, 69);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(100, 30);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblQuit
            // 
            this.lblQuit.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuit.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.lblQuit.Location = new System.Drawing.Point(12, 9);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(280, 57);
            this.lblQuit.TabIndex = 2;
            this.lblQuit.Text = "Are you sure you want to quit the entire application?";
            this.lblQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuit.UseMnemonic = false;
            // 
            // QuitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::InformationAgeProject.Properties.Settings.Default.FormsBackgroundColor;
            this.ClientSize = new System.Drawing.Size(304, 111);
            this.Controls.Add(this.lblQuit);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "FormsBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quit Game Entirely?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblQuit;
    }
}