///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         MainMenu.cs
//	Description:       MainMenu form for menu system of Information Age
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Saturday, October 23, 2021
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
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true); //Allows radio buttons to have transparent background without border
        }

        /// <summary>
        /// Event Handler for handling when MainMenu loads
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void MainMenu_Load(object sender, EventArgs e)
        {
            //Sets every control on the form to invisible
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            //Sets loading text to visible
            lblLoading.Visible = true;
        }

        #region showMainMenuScreenControls() Method
        /// <summary>
        /// Method for only showing controls on the main menu screen
        /// </summary>
        public void showMainMenuScreenControls()
        {
            //Sets every control on the form to invisible
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            //Sets every control on the main menu screen to visible
            lblTitle.Visible = true;
            btnPlayGame.Visible = true;
            btnOptions.Visible = true;
            btnInstructions.Visible = true;
            btnQuit.Visible = true;
        }
        #endregion

        #region MainMenu Buttons
        /// <summary>
        /// Event Handler for button to go to New Game or Load Game Screen
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            SoundController.playButtonClick();

            //Sets every control on the form to invisible
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            //Sets title, btnNewGame, btnLoadGame, and btnBackToMainMenu to visible
            lblTitle.Visible = true;
            btnNewGame.Visible = true;
            btnLoadGame.Visible = true;
            btnBackToMainMenu.Visible = true;

            //Sets window text to signify New Game or Load Game screen
            this.Text = "Information Age - New Game or Load Game";
        }

        /// <summary>
        /// Event Handler for button to go to options menu from main menu
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnOptions_Click(object sender, EventArgs e)
        {
            SoundController.playButtonClick();

            new OptionsForm().Show();
        }

        /// <summary>
        /// Event Handler for button to open game instructions
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            SoundController.playButtonClick();

            GameController.openInstructions();
        }

        /// <summary>
        /// Event Handler for button to exit game from main menu
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            SoundController.playButtonClick();

            //Opens QuitForm to prompt user to quit game or not
            GameController.quitGame();
        }
        #endregion

        #region New Game or Load Game Screen
        /// <summary>
        /// Event Handler for button to go to player selection and team naming screen
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            SoundController.playButtonClick();

            //Sets every control on the form to invisible
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            //Sets all items on screen for selecting player count and naming teams to visible
            pnlSelectPlayers.Visible = true;
            pnlTeamNames.Visible = true;
            btnBack1.Visible = true;
            btnStartGame.Visible = true;

            //Sets window text to signify New Game Setup screen
            this.Text = "Information Age - New Game Setup";
        }

        /// <summary>
        /// Event Handler for button to load game
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            SoundController.playButtonClick();

            GameController.loadGame();
        }

        /// <summary>
        /// Event Handler for button to go back to main menu from New Game or Load Game screen
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            SoundController.playButtonClick();

            //Sets every control on the form to invisible
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            //Sets all items on main menu to visible
            lblTitle.Visible = true;
            btnPlayGame.Visible = true;
            btnOptions.Visible = true;
            btnInstructions.Visible = true;
            btnQuit.Visible = true;

            //Sets window text to signify main menu screen
            this.Text = "Information Age - Main Menu";
        }
        #endregion

        #region Select Player Screen Buttons
        /// <summary>
        /// Event Handler for bac to go back to main menu screen
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnBack1_Click(object sender, EventArgs e)
        {
            SoundController.playButtonClick();

            //Sets every control on the form to invisible
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            //Sets title, btnNewGame, btnLoadGame, and btnBackToMainMenu to visible
            lblTitle.Visible = true;
            btnNewGame.Visible = true;
            btnLoadGame.Visible = true;
            btnBackToMainMenu.Visible = true;

            //Sets window text to signify New Game or Load Game screen
            this.Text = "Information Age - New Game or Load Game";
        }

        /// <summary>
        /// Event Handler for start game button to start game with selected number of players
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            SoundController.playButtonClick();

            //Array of team names to pass to startGame method for simplicity
            string[] teamNames;

            //Stores team names in array even if some or all are null or whitespace
            teamNames = new string[4];
            teamNames[0] = rtxtTeamName1.Text;
            teamNames[1] = rtxtTeamName2.Text;
            teamNames[2] = rtxtTeamName3.Text;
            teamNames[3] = rtxtTeamName4.Text;

            if (radio2Players.Checked == true)
            {
                //Will only start game with 2 players and make main menu invisible if team names for number of players selected are not input
                this.Visible = !GameController.startGame(2, teamNames);
            }
            else if (radio3Players.Checked == true)
            {

                //Will only start game with 3 players and make main menu invisible if team names for number of players selected are not input
                this.Visible = !GameController.startGame(3, teamNames);
            }
            else if (radio4Players.Checked == true)
            {

                //Will only start game with 4 players and make main menu invisible if team names for number of players selected are not input
                this.Visible = !GameController.startGame(4, teamNames);
            }
            //Shows "Player Number Not Selected" error if no radio button is selected when StartGame button is pressed
            else
            {
                MessageBox.Show("You cannot start the game without selecting the number of players."
                    , "Player Number Not Selected"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }
        #endregion


    }
}
