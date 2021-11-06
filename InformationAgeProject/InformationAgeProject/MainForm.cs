///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         MainForm.cs
//	Description:       Main Form window gui for Information Age Project
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Wednesday, September 15, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationAgeProject
{
	public partial class MainForm : Form
	{
		//Player to be used in this MainForm instance
		Player player;

		public MainForm(Player player)
		{
			InitializeComponent();

			//Assigns player and corresponding team name to this MainForm instance
			this.player = player;
			this.Text = "Information Age: " + player.TeamName;
		}

		#region MainForm_Load()
		/// <summary>
		/// Event Handler for handling when MainForm loads
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void MainForm_Load(object sender, EventArgs e)
		{
			//Loads initial developer count into txtDevelopers
			this.txtDevelopers.Text = player.Developers.ToString();

			//Loads initial progress cards into ProjectProgressCard textboxes
			ProjectProgressCard1.Text = GameController.ProjProgDeck[GameController.turnCounter].Deck[0].displayCard();
			ProjectProgressCard2.Text = GameController.ProjProgDeck[GameController.turnCounter].Deck[1].displayCard();
			ProjectProgressCard3.Text = GameController.ProjProgDeck[GameController.turnCounter].Deck[2].displayCard();
			ProjectProgressCard4.Text = GameController.ProjProgDeck[GameController.turnCounter].Deck[3].displayCard();
			ProjectProgressCardsGroupBox.Text = "Project Progress Cards: " + GameController.ProjProgDeck[GameController.turnCounter].Deck.Count + " cards remain";

			//Loads initial feature cards into AdditionalFeatures textboxes
			AdditionalFeaturesTextBox1.Text = GameController.ProjFeatDeck.Deck[0].displayCard();
			AdditionalFeaturesTextBox2.Text = GameController.ProjFeatDeck.Deck[1].displayCard();
			AdditionalFeaturesTextBox3.Text = GameController.ProjFeatDeck.Deck[2].displayCard();
			AdditionalFeaturesTextBox4.Text = GameController.ProjFeatDeck.Deck[3].displayCard();
			ProjectFeaturesCardsGroupBox.Text = "Project Features Cards: " + GameController.ProjFeatDeck.Deck.Count + " cards remain"; ;

			//Loads initial tool levels into toolSlot textboxes
			int[] toolLevelList = player.Inventory.getToolLevelList();
			toolSlot1.Text = toolLevelList[0].ToString();
			toolSlot2.Text = toolLevelList[1].ToString();
			toolSlot3.Text = toolLevelList[2].ToString();
		}
		#endregion

		#region Task Adding/Subtracting Buttons
		/// <summary>
		/// Event Handler for button to add developer to backlog task/resource category if any are available
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnAddBacklog_Click(object sender, EventArgs e)
		{
			//If the number of developers is larger than 0 and backlog count is less than 7, then subtract 1 from developer count and add 1 to backlog count
			//Else, do nothing
			if (Int32.Parse(txtDevelopers.Text) > 0 && Int32.Parse(txtBacklog.Text) < 7)
			{
				//Subtract 1 developer from developer count
				txtDevelopers.Text = Convert.ToString(Int32.Parse(txtDevelopers.Text) - 1);

				//Add 1 developer to backlog count
				txtBacklog.Text = Convert.ToString(Int32.Parse(txtBacklog.Text) + 1);

			}
			else
			{
				//Do nothing
			}
		}

		/// <summary>
		/// Event Handler for button to remove developer from backlog task/resource category if any are there
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnSubtBacklog_Click(object sender, EventArgs e)
		{
			//If the number of backlog developers is larger than 0, then subtract 1 from backlog count and add 1 to developer count
			//Else, do nothing
			if (Int32.Parse(txtBacklog.Text) > 0)
			{
				//Subtract 1 developer from backlog count
				txtBacklog.Text = Convert.ToString(Int32.Parse(txtBacklog.Text) - 1);

				//Add 1 developer to developer count
				txtDevelopers.Text = Convert.ToString(Int32.Parse(txtDevelopers.Text) + 1);

			}
			else
			{
				//Do nothing
			}
		}

		/// <summary>
		/// Event Handler for button to add developer to low-priority task/resource category if any are available
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnAddLow_Click(object sender, EventArgs e)
		{
			//If the number of developers is larger than 0 and low-priority count is less than 7, then subtract 1 from developer count and add 1 to low-priority count
			//Else, do nothing
			if (Int32.Parse(txtDevelopers.Text) > 0 && Int32.Parse(txtLow.Text) < 7)
			{
				//Subtract 1 developer from developer count
				txtDevelopers.Text = Convert.ToString(Int32.Parse(txtDevelopers.Text) - 1);

				//Add 1 developer to low-priority count
				txtLow.Text = Convert.ToString(Int32.Parse(txtLow.Text) + 1);

			}
			else
			{
				//Do nothing
			}
		}

		/// <summary>
		/// Event Handler for button to remove developer from low-priority task/resource category if any there
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnSubtLow_Click(object sender, EventArgs e)
		{
			//If the number of low-priority developers is larger than 0, then subtract 1 from low-priority count and add 1 to developer count
			//Else, do nothing
			if (Int32.Parse(txtLow.Text) > 0)
			{
				//Subtract 1 developer from low-priority count
				txtLow.Text = Convert.ToString(Int32.Parse(txtLow.Text) - 1);

				//Add 1 developer to developer count
				txtDevelopers.Text = Convert.ToString(Int32.Parse(txtDevelopers.Text) + 1);

			}
			else
			{
				//Do nothing
			}
		}

		/// <summary>
		/// Event Handler for button to add developer to medium-priority task/resource category if any are available
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnAddMed_Click(object sender, EventArgs e)
		{
			//If the number of developers is larger than 0 and medium-priority count is less than 7, then subtract 1 from developer count and add 1 to medium-priority count
			//Else, do nothing
			if (Int32.Parse(txtDevelopers.Text) > 0 && Int32.Parse(txtMed.Text) < 7)
			{
				//Subtract 1 developer from developer count
				txtDevelopers.Text = Convert.ToString(Int32.Parse(txtDevelopers.Text) - 1);

				//Add 1 developer to medium-priority count
				txtMed.Text = Convert.ToString(Int32.Parse(txtMed.Text) + 1);

			}
			else
			{
				//Do nothing
			}
		}

		/// <summary>
		/// Event Handler for button to remove developer from medium-priority task/resource category if any there
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnSubtMed_Click(object sender, EventArgs e)
		{
			//If the number of medium-priority developers is larger than 0, then subtract 1 from medium-priority count and add 1 to developer count
			//Else, do nothing
			if (Int32.Parse(txtMed.Text) > 0)
			{
				//Subtract 1 developer from medium-priority count
				txtMed.Text = Convert.ToString(Int32.Parse(txtMed.Text) - 1);

				//Add 1 developer to developer count
				txtDevelopers.Text = Convert.ToString(Int32.Parse(txtDevelopers.Text) + 1);

			}
			else
			{
				//Do nothing
			}
		}

		/// <summary>
		/// Event Handler for button to add developer to high-priority task/resource category if any are available
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnAddHigh_Click(object sender, EventArgs e)
		{
			//If the number of developers is larger than 0 and high-priority count is less than 7, then subtract 1 from developer count and add 1 to high-priority count
			//Else, do nothing
			if (Int32.Parse(txtDevelopers.Text) > 0 && Int32.Parse(txtHigh.Text) < 7)
			{
				//Subtract 1 developer from developer count
				txtDevelopers.Text = Convert.ToString(Int32.Parse(txtDevelopers.Text) - 1);

				//Add 1 developer to medium-priority count
				txtHigh.Text = Convert.ToString(Int32.Parse(txtHigh.Text) + 1);

			}
			else
			{
				//Do nothing
			}
		}

		/// <summary>
		/// Event Handler for button to remove developer from high-priority task/resource category if any there
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnSubtHigh_Click(object sender, EventArgs e)
		{
			//If the number of high-priority developers is larger than 0, then subtract 1 from high-priority count and add 1 to developer count
			//Else, do nothing
			if (Int32.Parse(txtHigh.Text) > 0)
			{
				//Subtract 1 developer from high-priority count
				txtHigh.Text = Convert.ToString(Int32.Parse(txtHigh.Text) - 1);

				//Add 1 developer to developer count
				txtDevelopers.Text = Convert.ToString(Int32.Parse(txtDevelopers.Text) + 1);

			}
			else
			{
				//Do nothing
			}
		}
		#endregion

		#region DoTasks Button
		/// <summary>
		/// Event Handler for button to tell developers to do tasks and then roll dice to calculate how many tasks/resources are completed/acquired
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnDoTasks_Click(object sender, EventArgs e)
		{
			//Stores counts of developers at each task/resource
			int[] devCounts = new int[4];
			devCounts[0] = int.Parse(txtBacklog.Text);
			devCounts[1] = int.Parse(txtLow.Text);
			devCounts[2] = int.Parse(txtMed.Text);
			devCounts[3] = int.Parse(txtHigh.Text);

			//Calculates number of tasks that player should acquire based on random dice rolls and tool usage and stores them in player's inventory
			//Returns developers to developer pool and disables "DoTasks" button if task calculation was successful
			if (GameController.calcTasks(player, devCounts) == true)
			{
				//Adds developers back to player's free developer pool
				int leftoverDevelopers = Int32.Parse(txtDevelopers.Text);
				txtDevelopers.Text = Convert.ToString(leftoverDevelopers
													+ int.Parse(txtBacklog.Text)
													+ int.Parse(txtLow.Text)
													+ int.Parse(txtMed.Text)
													+ int.Parse(txtHigh.Text));

				//Resets developer counts on each task/resource
				txtBacklog.Text = "0";
				txtLow.Text = "0";
				txtMed.Text = "0";
				txtHigh.Text = "0";

				//Print out current inventory text to inventoryBox
				inventoryBox.Text = player.Inventory.printResources();

				//Recalculate the score and update the score text box
				Scoring score = new Scoring(player.Inventory);
				scoreBox.Text = score.calculateScore();

				//Sets btnDoTasks to disabled so player cant do tasks again in same turn
				btnDoTasks.Enabled = false;
			}
		}
		#endregion

		#region Tool Buttons and Textboxes
		/// <summary>
		/// Event Handler for button to add developer to tool maker if any are available and if there isnt a developer there already
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnAddToolMaker_Click(object sender, EventArgs e)
		{
			//If the number of developers is larger than 0 and any player has not put a developer at the tool maker, add 1 to tool maker
			//Else, do nothing
			if (Int32.Parse(txtDevelopers.Text) > 0 && Int32.Parse(txtToolMaker.Text) < 1)
			{
				//Subtract 1 developer from developer count
				txtDevelopers.Text = Convert.ToString(Int32.Parse(txtDevelopers.Text) - 1);

				//Add 1 developer to tool maker count
				txtToolMaker.Text = Convert.ToString(Int32.Parse(txtToolMaker.Text) + 1);

			}
			else
			{
				//Do nothing
			}
		}

		/// <summary>
		/// Event Handler for button to remove developer from tool maker i a developer is already there and is the current player's developer
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnSubtToolMaker_Click(object sender, EventArgs e)
		{
			//If there is a developer from the current player at the tool maker, then subtract 1 from tool maker count and add 1 to developer count
			//Else, do nothing
			if (Int32.Parse(txtToolMaker.Text) > 0)
			{
				//Subtract 1 developer from tool maker count
				txtToolMaker.Text = Convert.ToString(Int32.Parse(txtToolMaker.Text) - 1);

				//Add 1 developer to developer count
				txtDevelopers.Text = Convert.ToString(Int32.Parse(txtDevelopers.Text) + 1);

			}
			else
			{
				//Do nothing
			}
		}

		/// <summary>
		/// PLACEHOLDER Event Handler for button to acquire tool for current player 
		/// (In the finished game, tools are only acquired after a round ends and a player has a developer at the tool maker, not when a button is pressed)
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnAcquireTool_Click(object sender, EventArgs e)
		{
			//If there is atleast one developer at the tool maker for the current player, add one tool to inventory if able to
			//Else, do nothing
			if (Int32.Parse(txtToolMaker.Text) == 1)
			{
				//Adds a tool to the players inventory if there are not 3 tools that equal level 4
				player.Inventory.addTool();

				//Stores developer that is currently in tool maker
				int toolMakerNum = Int32.Parse(txtToolMaker.Text);

				//Resets developer count at tool maker
				txtToolMaker.Text = "0";

				//Returns developer that was at the tool maker back to developer pool
				int leftoverDevelopers = Int32.Parse(txtDevelopers.Text);
				txtDevelopers.Text = Convert.ToString(leftoverDevelopers + toolMakerNum);

				//Reloads current tool levels after acquiring new tool
				int[] toolLevelList = player.Inventory.getToolLevelList();
				toolSlot1.Text = Convert.ToString(toolLevelList[0]);
				toolSlot2.Text = Convert.ToString(toolLevelList[1]);
				toolSlot3.Text = Convert.ToString(toolLevelList[2]);

			}
			else
			{
				//Do nothing
			}
		}
		#endregion

		#region Project Progress Cards
		/// <summary>
		/// Claims the first project progress card
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void ClaimProgressCard1_Click(object sender, EventArgs e)
		{
			int points = GameController.ClaimProgressCard();

			//Removes the card from the deck and updates the text fields to show the new card
            if (points > 0)
            {
				// if the deck is empty stop the player from pressing the button and display an empty message
				if (GameController.ProjProgDeck[GameController.turnCounter].Deck.Count == 0)
				{
					ClaimProgressCard1.Enabled = false;
					ProjectProgressCard1.Text = "You have purchased all available cards.";
				}
				else
				{
					ProjectProgressCard1.Text = GameController.ProjProgDeck[GameController.turnCounter].Deck[0].displayCard( );
				}
				ProjectProgressCardsGroupBox.Text = "Project Progress Cards: " + GameController.ProjProgDeck[GameController.turnCounter].Deck.Count + " cards remain";
			}
		}

		/// <summary>
		/// Claims the second project progress card
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void ClaimProgressCard2_Click(object sender, EventArgs e)
		{
			int points = GameController.ClaimProgressCard();

			if (points > 0)
			{
				//Syncs the purchased card ඞmong all the players 
				for (int i = 0; i < GameController.playerForms.Length; i++)
				{
					GameController.playerForms[i].ClaimProgressCard2.Enabled = false;
					GameController.playerForms[i].ProjectProgressCard2.Text = GameController.ProjProgDeck[GameController.turnCounter].Deck[1].displayCard( );
				}
			}
		}

		/// <summary>
		/// Claims the third project progress card
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void ClaimProgressCard3_Click(object sender, EventArgs e)
		{
			int points = GameController.ClaimProgressCard();

			if (points > 0)
			{
				//Syncs the purchased card ඞmong all the players 
				for (int i = 0; i < GameController.playerForms.Length; i++)
				{
					GameController.playerForms[i].ClaimProgressCard3.Enabled = false;
					GameController.playerForms[i].ProjectProgressCard3.Text = GameController.ProjProgDeck[GameController.turnCounter].Deck[2].displayCard( );
				}
			}
		}

		/// <summary>
		/// Claims the fourth project progress card
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void ClaimProgressCard4_Click(object sender, EventArgs e)
		{
			int points = GameController.ClaimProgressCard();

			if (points > 0)
			{
				//Syncs the purchased card ඞmong all the players 
				for (int i = 0; i < GameController.playerForms.Length; i++)
				{
					GameController.playerForms[i].ClaimProgressCard4.Enabled = false;
					GameController.playerForms[i].ProjectProgressCard4.Text = GameController.ProjProgDeck[GameController.turnCounter].Deck[3].displayCard( );
				}
			}
		}
		#endregion

		#region Additional Project Features Cards
		/// <summary>
		/// Claims the first feature card available, costs 4 resources
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ClaimFeaturesCard1_Click(object sender, EventArgs e)
		{

			AdditionalProjectFeaturesType[] cards = GameController.ClaimFeatureCard(0, 4);

            if (cards != null)
            {
				//Syncs the purchased card ඞmong all the players
				for (int i = 0; i < GameController.playerForms.Length; i++)
                {
					GameController.playerForms[i].ClaimFeaturesCard1.Enabled = false;

					if (GameController.ProjFeatDeck.Deck.Count < 1)
                    {
						GameController.playerForms[i].AdditionalFeaturesTextBox1.Text = "All available cards have been purchased.";
					}
                    else
                    {
						GameController.playerForms[i].AdditionalFeaturesTextBox1.Text = GameController.ProjFeatDeck.Deck[0].displayCard( );
					}
				}
			}
		}

		/// <summary>
		/// Claims the second feature card available, costs 3 resources
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ClaimFeaturesCard2_Click(object sender, EventArgs e)
		{
			AdditionalProjectFeaturesType[] cards = GameController.ClaimFeatureCard(1, 3);

			if (cards != null)
			{
				//Syncs the purchased card ඞmong all the players
				for (int i = 0; i < GameController.playerForms.Length; i++)
				{
					GameController.playerForms[i].ClaimFeaturesCard2.Enabled = false;

					if (GameController.ProjFeatDeck.Deck.Count < 2)
					{
						GameController.playerForms[i].AdditionalFeaturesTextBox2.Text = "All available cards have been purchased.";
					}
					else
					{
						GameController.playerForms[i].AdditionalFeaturesTextBox2.Text = GameController.ProjFeatDeck.Deck[1].displayCard( );
					}
				}
			}
		}

		/// <summary>
		/// Claims the third feature card available, costs 2 resources
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ClaimFeaturesCard3_Click(object sender, EventArgs e)
		{
			AdditionalProjectFeaturesType[] cards = GameController.ClaimFeatureCard(2, 2);

			if (cards != null)
			{
				//Syncs the purchased card ඞmong all the players
				for (int i = 0; i < GameController.playerForms.Length; i++)
				{
					GameController.playerForms[i].ClaimFeaturesCard3.Enabled = false;

					if (GameController.ProjFeatDeck.Deck.Count < 3)
					{
						GameController.playerForms[i].AdditionalFeaturesTextBox3.Text = "All available cards have been purchased.";
					}
					else
					{
						GameController.playerForms[i].AdditionalFeaturesTextBox3.Text = GameController.ProjFeatDeck.Deck[2].displayCard( );
					}
				}
			}
		}

		/// <summary>
		/// Claims the fourth feature card available, costs 1 resource
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ClaimFeaturesCard4_Click(object sender, EventArgs e)
		{
			AdditionalProjectFeaturesType[] cards = GameController.ClaimFeatureCard(3, 1);

			if (cards != null)
			{
				//Syncs the purchased card ඞmong all the players
				for (int i = 0; i < GameController.playerForms.Length; i++)
				{
					GameController.playerForms[i].ClaimFeaturesCard4.Enabled = false;

					if (GameController.ProjFeatDeck.Deck.Count < 4)
					{
						GameController.playerForms[i].AdditionalFeaturesTextBox4.Text = "All available cards have been purchased.";
					}
					else
					{
						GameController.playerForms[i].AdditionalFeaturesTextBox4.Text = GameController.ProjFeatDeck.Deck[3].displayCard( );
					}
				}
			}
		}
		#endregion

		#region EndTurn Button
		/// <summary>
		/// Event Handler for EndTurn button to go to next player's turn
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnEndTurn_Click(object sender, EventArgs e)
		{
			//Re-enables do task button for next time current player has a turn
			this.btnDoTasks.Enabled = true;

			//Ends current player's turn and goes to next player's turn
			GameController.endTurn();
		}
		#endregion

		#region Menu Dropdown Buttons
		/// <summary>
		/// Event Handler for Save dropdown menu button to save current game
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Event Handler for dropdown menu button to quit to main menu
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnQuitToMenuMenuItem_Click(object sender, EventArgs e)
		{
			//Opens QuitToMenuForm to prompt user to quit game to main menu or not
			GameController.openQuitToMenuForm();
		}

		/// <summary>
		/// Event Handler for dropdown menu button to open "are you sure you want to quit?" windows form
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnQuitToDesktopMenuItem_Click(object sender, EventArgs e)
		{
			//Opens QuitForm to prompt user to quit game entirely or not
			GameController.openQuitForm();
		}
		#endregion

		#region Help Dropdown Buttons
		/// <summary>
		/// Event Handler for Statistics dropdown menu button to view the inventory, tools, etc. of all players
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Method: instructionsToolStripMenuItem_Click opens the Instructionset.txt file upon clicking
		/// the btnInstructions button on the main form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Opens game instructions
			GameController.openInstructions();
		}

		/// <summary>
		/// Event Handler for dropdown menu button to open "about" windows form
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Opens AboutBox with information about the game
			GameController.openAboutBox();
		}
		#endregion
	}
}