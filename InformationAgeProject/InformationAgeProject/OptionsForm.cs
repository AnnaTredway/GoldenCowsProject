/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         OptionsForm.cs
//	Description:       OptionsForm form for options menu GUI
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Monday, November 1, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationAgeProject
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Event Handler for handling when OptionsForm loads
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void OptionsForm_Load(object sender, EventArgs e)
        {
            //Sets every control on the form to invisible
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            //Sets every control on main options screen to visible
            lblOptions.Visible = true;
            btnGraphics.Visible = true;
            btnSound.Visible = true;
            btnBackToMainMenu.Visible = true;
            btnResetGraphics.Visible = true;
            btnResetSound.Visible = true;
        }

        #region Main Options Screen Buttons
        /// <summary>
        /// Event Handler for button to go to graphics options screen
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnGraphics_Click(object sender, EventArgs e)
        {
            //Sets every control on the form to invisible
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            //Sets every control on graphics options screen to visible
            lblGraphics.Visible = true;
            btnBackColor.Visible = true;
            btnChangeTextColor.Visible = true;
            btnButtonColor.Visible = true;
            btnChangeButtonTextColor.Visible = true;
            btnBack.Visible = true;
            btnResetGraphics.Visible = true;
            btnResetSound.Visible = true;
            this.Text = "Graphics Options";
        }

        /// <summary>
        /// Event Handler for button to go to sound options screen
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnSound_Click(object sender, EventArgs e)
        {
            //Sets every control on the form to invisible
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            //Sets every control on sound options screen to visible
            lblSound.Visible = true;
            effectsVolumeScrollBar.Visible = true;
            musicVolumeScrollBar.Visible = true;
            btnBack.Visible = true;
            btnResetGraphics.Visible = true;
            btnResetSound.Visible = true;
            this.Text = "Sound Options";
        }
        #endregion

        #region Graphics Options Controls
        /// <summary>
        /// Event Handler for button to change background color in program
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FormsBackgroundColor = colorDlg.Color;
                Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// Event Handler for button to change text not in buttons color in program
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnChangeTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FormsTextColor = colorDlg.Color;
                Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// Event Handler for button to change button color in program
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnButtonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ButtonBackgroundColor = colorDlg.Color;
                Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// Event Handler for button to change button text color in program
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnChangeButtonTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ButtonTextColor = colorDlg.Color;
                Properties.Settings.Default.Save();
            }
        }
        #endregion

        #region Sound Options Controls
        /// <summary>
        /// Event Handler for scroll bar to change sound effects volume within game
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void effectsVolumeScrollBar_Scroll(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event Handler for scroll bar to change music volume within game
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void musicVolumeScrollBar_Scroll(object sender, EventArgs e)
        {

        }
        #endregion

        #region Reset Buttons
        /// <summary>
        /// Event Handler for button to reset graphics options back to default
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnResetGraphics_Click(object sender, EventArgs e)
        {
            //Resets all colors back to default values
            Properties.Settings.Default.FormsBackgroundColor = Color.LightSkyBlue;
            Properties.Settings.Default.FormsTextColor = Color.Black;
            Properties.Settings.Default.ButtonBackgroundColor = Color.IndianRed;
            Properties.Settings.Default.ButtonTextColor = Color.Black;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Event Handler for button to reset sound options back to default
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnResetSound_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Back Buttons
        /// <summary>
        /// Event Handler for button to go back to main menu
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Event Handler for button to go back to main options screen
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            //Sets every control on the form to invisible
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            //Sets every control on main options screen to visible
            lblOptions.Visible = true;
            btnGraphics.Visible = true;
            btnSound.Visible = true;
            btnBackToMainMenu.Visible = true;
            btnResetGraphics.Visible = true;
            btnResetSound.Visible = true;
            this.Text = "Options";
        }

        #endregion

    }
}
