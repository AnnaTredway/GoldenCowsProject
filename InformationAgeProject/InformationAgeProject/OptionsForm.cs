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
using System.Drawing;
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

            //Sets volume sliders to current global property value
            effectsVolumeScrollBar.Value = Properties.Settings.Default.EffectsVolume;
            musicVolumeScrollBar.Value = Properties.Settings.Default.MusicVolume;

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
            SoundController.playButtonClick();

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
            SoundController.playButtonClick();

            //Sets every control on the form to invisible
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            //Sets every control on sound options screen to visible
            lblSound.Visible = true;
            lblSoundEffects.Visible = true;
            effectsVolumeScrollBar.Visible = true;
            lblMusic.Visible = true;
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
            SoundController.playButtonClick();

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
            SoundController.playButtonClick();

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
            SoundController.playButtonClick();

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
            SoundController.playButtonClick();

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
            SoundController.buttonPlayer.Volume = (double)effectsVolumeScrollBar.Value / 100;
            Properties.Settings.Default.EffectsVolume = effectsVolumeScrollBar.Value;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Event Handler for scroll bar to change music volume within game
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void musicVolumeScrollBar_Scroll(object sender, EventArgs e)
        {
            SoundController.musicPlayer.Volume = (double)musicVolumeScrollBar.Value / 100;
            Properties.Settings.Default.MusicVolume = musicVolumeScrollBar.Value;
            Properties.Settings.Default.Save();
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
            SoundController.playButtonClick();

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
            SoundController.playButtonClick();

            //Resets Volume sliders and global variables back to what they were on first-time startup
            Properties.Settings.Default.EffectsVolume = 50;
            effectsVolumeScrollBar.Value = Properties.Settings.Default.EffectsVolume;
            SoundController.buttonPlayer.Volume = (double)Properties.Settings.Default.EffectsVolume / 100;
            Properties.Settings.Default.Save();

            Properties.Settings.Default.MusicVolume = 25;
            musicVolumeScrollBar.Value = Properties.Settings.Default.MusicVolume;
            SoundController.musicPlayer.Volume = (double)musicVolumeScrollBar.Value / 100;
            Properties.Settings.Default.Save();
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
            SoundController.playButtonClick();

            Dispose();
        }

        /// <summary>
        /// Event Handler for button to go back to main options screen
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            SoundController.playButtonClick();

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
