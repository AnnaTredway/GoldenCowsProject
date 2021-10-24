///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         MainMenu.cs
//	Description:       MainMenu form for main menu of Information Age
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
		public static int turnCounter = 0;
		public static Player[] playerList;
		public static MainForm[] playerForms;

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
			radio2Players.Visible = true;
			radio3Players.Visible = true;
			radio4Players.Visible = true;
			btnBack1.Visible = true;
			btnStartGame.Visible = true;
			lblPlayers.Visible = true;
			pnlTeamNames.Visible = true;
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
			Application.Exit();
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
			radio2Players.Visible = false;
			radio3Players.Visible = false;
			radio4Players.Visible = false;
			btnBack1.Visible = false;
			btnStartGame.Visible = false;
			lblPlayers.Visible = false;
			pnlTeamNames.Visible = false;

			//Sets all main menu items to visible
			lblTitle.Visible = true;
			btnPlayGame.Visible = true;
			btnOptions.Visible = true;
			btnQuit.Visible = true;
		}

		/// <summary>
		/// Event Handler for start game button to start game with selected number of players
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnStartGame_Click(object sender, EventArgs e)
		{
			//Starts game with 2 players
			if (radio2Players.Checked == true)
			{
				playerList = new Player[2];
				playerForms = new MainForm[2];

				//Activates 2 players
				playerList[0] = new Player();
				playerList[1] = new Player();

				//Sets team names for 2 players
				playerList[0].TeamName = rtxtTeamName1.Text;
				playerList[1].TeamName = rtxtTeamName2.Text;

				//Activates game boards for 2 players
				playerForms[0] = new MainForm(playerList[0]);
				playerForms[1] = new MainForm(playerList[1]);

				//Makes menu form invisible so it isnt open when main game boards are open
				this.Visible = false;

				//Shows first player form for first turn within first round
				playerForms[0].Show();

			}

			//Starts game with 3 players
			if (radio3Players.Checked == true)
			{
				playerList = new Player[3];
				playerForms = new MainForm[3];

				//Activates 3 players
				playerList[0] = new Player();
				playerList[1] = new Player();
				playerList[2] = new Player();

				//Sets team names for 3 players
				playerList[0].TeamName = rtxtTeamName1.Text;
				playerList[1].TeamName = rtxtTeamName2.Text;
				playerList[2].TeamName = rtxtTeamName3.Text;

				//Activates game boards for 3 players
				playerForms[0] = new MainForm(playerList[0]);
				playerForms[1] = new MainForm(playerList[1]);
				playerForms[2] = new MainForm(playerList[2]);

				//Makes menu form invisible so it isnt open when main game boards are open
				this.Visible = false;

				//Shows first player form for first turn within first round
				playerForms[0].Show();

			}

			//Starts game with 4 players
			if (radio4Players.Checked == true)
			{
				playerList = new Player[4];
				playerForms = new MainForm[4];

				//Activates 4 players
				playerList[0] = new Player();
				playerList[1] = new Player();
				playerList[2] = new Player();
				playerList[3] = new Player();

				//Sets team names for 4 players
				playerList[0].TeamName = rtxtTeamName1.Text;
				playerList[1].TeamName = rtxtTeamName2.Text;
				playerList[2].TeamName = rtxtTeamName3.Text;
				playerList[3].TeamName = rtxtTeamName4.Text;

				//Activates game boards for 4 players
				playerForms[0] = new MainForm(playerList[0]);
				playerForms[1] = new MainForm(playerList[1]);
				playerForms[2] = new MainForm(playerList[2]);
				playerForms[3] = new MainForm(playerList[3]);

				//Makes menu form invisible so it isnt open when main game boards are open
				this.Visible = false;

				//Shows first player form for first turn within first round
				playerForms[0].Show();

			}
		}
		#endregion
	}
}
