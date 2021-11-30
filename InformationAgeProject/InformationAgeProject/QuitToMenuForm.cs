///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         QuitToMenuForm.cs
//	Description:       QuitToMenuForm for prompting user whether or not they want to quit the game to go back to the main menu
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Tuesday, November 2, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows.Forms;

namespace InformationAgeProject
{
    public partial class QuitToMenuForm : Form
    {
        public QuitToMenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event Handler for Yes button to close main forms and reopen main menu
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnYes_Click(object sender, EventArgs e)
        {
            SoundController.playButtonClick();
            GameController.quitToMainMenu();
            Dispose();
        }

        /// <summary>
        /// Event Handler for No button to close quit window form and go back to main form
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            SoundController.playButtonClick();
            Dispose();
        }
    }
}
