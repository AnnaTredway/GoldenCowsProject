
namespace InformationAgeProject
{
    partial class AdditionalProjectFeaturesSelector
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
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalProjectFeaturesSelector));
            this.TitleLable = new System.Windows.Forms.Label();
            this.BacklogCheckList = new System.Windows.Forms.CheckedListBox();
            this.LowPriorityCheckList = new System.Windows.Forms.CheckedListBox();
            this.MedPriorityCheckList = new System.Windows.Forms.CheckedListBox();
            this.HighPrioroityCheckList = new System.Windows.Forms.CheckedListBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.APFSCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "FormsTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLable.ForeColor = global::InformationAgeProject.Properties.Settings.Default.FormsTextColor;
            this.TitleLable.Location = new System.Drawing.Point(12, 9);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(70, 25);
            this.TitleLable.TabIndex = 0;
            this.TitleLable.Text = "label1";
            // 
            // BacklogCheckList
            // 
            this.BacklogCheckList.FormattingEnabled = true;
            this.BacklogCheckList.Location = new System.Drawing.Point(10, 43);
            this.BacklogCheckList.Name = "BacklogCheckList";
            this.BacklogCheckList.Size = new System.Drawing.Size(120, 139);
            this.BacklogCheckList.TabIndex = 1;
            // 
            // LowPriorityCheckList
            // 
            this.LowPriorityCheckList.FormattingEnabled = true;
            this.LowPriorityCheckList.Location = new System.Drawing.Point(150, 43);
            this.LowPriorityCheckList.Name = "LowPriorityCheckList";
            this.LowPriorityCheckList.Size = new System.Drawing.Size(120, 139);
            this.LowPriorityCheckList.TabIndex = 2;
            // 
            // MedPriorityCheckList
            // 
            this.MedPriorityCheckList.FormattingEnabled = true;
            this.MedPriorityCheckList.Location = new System.Drawing.Point(290, 43);
            this.MedPriorityCheckList.Name = "MedPriorityCheckList";
            this.MedPriorityCheckList.Size = new System.Drawing.Size(120, 139);
            this.MedPriorityCheckList.TabIndex = 3;
            // 
            // HighPrioroityCheckList
            // 
            this.HighPrioroityCheckList.FormattingEnabled = true;
            this.HighPrioroityCheckList.Location = new System.Drawing.Point(430, 43);
            this.HighPrioroityCheckList.Name = "HighPrioroityCheckList";
            this.HighPrioroityCheckList.Size = new System.Drawing.Size(120, 139);
            this.HighPrioroityCheckList.TabIndex = 4;
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.SelectButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SelectButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.SelectButton.Location = new System.Drawing.Point(447, 188);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(103, 23);
            this.SelectButton.TabIndex = 5;
            this.SelectButton.Text = "Select Resources";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // APFSCancelButton
            // 
            this.APFSCancelButton.BackColor = global::InformationAgeProject.Properties.Settings.Default.ButtonBackgroundColor;
            this.APFSCancelButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.APFSCancelButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::InformationAgeProject.Properties.Settings.Default, "ButtonTextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.APFSCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.APFSCancelButton.ForeColor = global::InformationAgeProject.Properties.Settings.Default.ButtonTextColor;
            this.APFSCancelButton.Location = new System.Drawing.Point(10, 188);
            this.APFSCancelButton.Name = "APFSCancelButton";
            this.APFSCancelButton.Size = new System.Drawing.Size(103, 23);
            this.APFSCancelButton.TabIndex = 6;
            this.APFSCancelButton.Text = "Cancel Selection";
            this.APFSCancelButton.UseVisualStyleBackColor = false;
            this.APFSCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AdditionalProjectFeaturesSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::InformationAgeProject.Properties.Settings.Default.FormsBackgroundColor;
            this.ClientSize = new System.Drawing.Size(559, 222);
            this.ControlBox = false;
            this.Controls.Add(this.APFSCancelButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.HighPrioroityCheckList);
            this.Controls.Add(this.MedPriorityCheckList);
            this.Controls.Add(this.LowPriorityCheckList);
            this.Controls.Add(this.BacklogCheckList);
            this.Controls.Add(this.TitleLable);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::InformationAgeProject.Properties.Settings.Default, "FormsBackgroundColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdditionalProjectFeaturesSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Additional Project Features Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.CheckedListBox BacklogCheckList;
        private System.Windows.Forms.CheckedListBox LowPriorityCheckList;
        private System.Windows.Forms.CheckedListBox MedPriorityCheckList;
        private System.Windows.Forms.CheckedListBox HighPrioroityCheckList;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button APFSCancelButton;
    }
}