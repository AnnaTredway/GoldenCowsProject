///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         EndGame.cs
//	Description:       Displays the winner of the game
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Treadway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Wednesday, November 29, 2021
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
    /// <summary>
    /// Displays the winner of the game
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class EndGame : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndGame"/> class.
        /// </summary>
        public EndGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Quits the game
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void EndGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Prevents the window form instantly closing
            GameController.quitGame();
        }

        /// <summary>
        /// Returns the player back to the main menu
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            GameController.quitToMainMenu();
            this.Dispose();
        }

        /// <summary>
        /// Exits the game
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            GameController.quitGame();
        }
    }
}
