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
		}

		#region MainMenu Buttons
		/// <summary>
		/// Event Handler for button to play the game itself from the main menu
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnPlayGame_Click(object sender, EventArgs e)
		{
			//Sets all main menu items to false to go to 
			lblTitle.Visible = false;
			btnPlayGame.Visible = false;
			btnOptions.Visible = false;
			btnQuit.Visible = false;

			//Sets all buttons on screen for selecting player count to true
			pnlSelectPlayers.Visible = true;
			pnlTeamNames.Visible = true;
			btnBack1.Visible = true;
			btnStartGame.Visible = true;

			//Sets window text to signify player selection screen
			this.Text = "Information Age - Select Players";
		}

		/// <summary>
		/// Event Handler for button to go to options menu from main menu
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnOptions_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Event Handler for button to exit game from main menu
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnQuit_Click(object sender, EventArgs e)
		{
			//Opens QuitForm to prompt user to quit game or not
			GameController.quitGame();
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
			//Sets all buttons on screen for selecting player count to invisible
			pnlSelectPlayers.Visible = false;
			pnlTeamNames.Visible = false;
			btnBack1.Visible = false;
			btnStartGame.Visible = false;

			//Sets all main menu items to visible
			lblTitle.Visible = true;
			btnPlayGame.Visible = true;
			btnOptions.Visible = true;
			btnQuit.Visible = true;
			 
			//Sets window text to signify main menu screen
			this.Text = "Information Age - Main Menu";
		}

		/// <summary>
		/// Event Handler for start game button to start game with selected number of players
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnStartGame_Click(object sender, EventArgs e)
		{
			//Array of team names to pass to startGame method for simplicity
			string[] teamNames;
			bool showError = true;

			//Stores team names in array even if some or all are null or whitespace
			teamNames = new string[4];
			teamNames[0] = rtxtTeamName1.Text;
			teamNames[1] = rtxtTeamName2.Text;
			teamNames[2] = rtxtTeamName3.Text;
			teamNames[3] = rtxtTeamName4.Text;

			if (radio2Players.Checked == true)
			{
				//Sets "Player Number Not Selected" error to not show
				showError = false;

				//Will only start game with 2 players and make main menu invisible if team names for number of players selected are not input
				this.Visible = GameController.startGame(2, teamNames);
			}

			if (radio3Players.Checked == true)
			{
				//Sets "Player Number Not Selected" error to not show
				showError = false;

				//Will only start game with 3 players and make main menu invisible if team names for number of players selected are not input
				this.Visible = GameController.startGame(3, teamNames);
			}

			if (radio4Players.Checked == true)
			{
				//Sets "Player Number Not Selected" error to not show
				showError = false;

				//Will only start game with 4 players and make main menu invisible if team names for number of players selected are not input
				this.Visible = GameController.startGame(4, teamNames);
			}

			//Shows "Player Number Not Selected" error if no radio button is selected when StartGame button is pressed
			if (showError == true)
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
