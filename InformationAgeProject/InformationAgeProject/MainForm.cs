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
		readonly Player player;

		public MainForm(Player player)
		{
			InitializeComponent();

			//Assigns player, player number, and corresponding team name to this MainForm instance
			this.player = player;
			this.Text = $"Information Age | Player: {player.PlayerNum + 1} | Team: {player.TeamName}";
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
			this.txtDevelopers.Text = player.TeamCount.ToString();

			//Loads initial progress cards into ProjectProgressCard textboxes
			ProjectProgressCard1.Text = GameController.ProjProgDeck[GameController.turnCounter].Deck[0].displayCard();
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

			//Resets tool maker because developer was already added back to player at the end of previous round
			txtToolMaker.Text = "0";

			//Sets btnRecallDevs to default false status
			btnRecallDevs.Enabled = false;
		}
		#endregion

		//Regular Methods
		#region Reload()
		/// <summary>
		/// Method for reloading some parts of main forms when new round begins
		/// </summary>
		public void Reload()
		{
			//Re-Loads developer count into txtDevelopers
			this.txtDevelopers.Text = player.TeamCount.ToString();
			lblRecruitStatus.Text = "";

			if (GameController.recruitmentOfficeFull == true)
            {
				btnSendDevs.Enabled = false;
				btnRecallDevs.Enabled = false;
            }
			else
            {
				btnSendDevs.Enabled = true;
				btnRecallDevs.Enabled = false;
            }

			//Re-Loads tool levels into toolSlot textboxes
			int[] toolLevelList = player.Inventory.getToolLevelList();
			toolSlot1.Text = toolLevelList[0].ToString();
			toolSlot2.Text = toolLevelList[1].ToString();
			toolSlot3.Text = toolLevelList[2].ToString();

			//Resets tool maker because developer was already added back to player at the end of previous round
			txtToolMaker.Text = "0";
		}
		#endregion

		#region SendDevsBackFromTasks()
		/// <summary>
		/// Method for sending all developers back to developer pool from tasks area
		/// </summary>
		public void SendDevsBackFromTasks()
		{
			//Adds developers from tasks area back to player's free developer pool
			int leftoverDevelopers = player.Developers;
			player.Developers = leftoverDevelopers
								+ int.Parse(txtBacklog.Text)
								+ int.Parse(txtLow.Text)
								+ int.Parse(txtMed.Text)
								+ int.Parse(txtHigh.Text);

			//Shows all developers from tasks area returned to developer pool
			txtDevelopers.Text = Convert.ToString(player.Developers);

			//Resets developer counts on each task/resource
			txtBacklog.Text = "0";
			txtLow.Text = "0";
			txtMed.Text = "0";
			txtHigh.Text = "0";
		}
		#endregion

		//Form Controls Methods and Events
		#region Task Adding/Subtracting Buttons
		/// <summary>
		/// Event Handler for button to add developer to backlog task/resource category if any are available
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnAddBacklog_Click(object sender, EventArgs e)
		{
			SoundController.playButtonClick();

			//If the number of developers is larger than 0 and backlog count is less than 7, then subtract 1 from developer count and add 1 to backlog count
			//Else, do nothing
			if (player.Developers > 0 && Int32.Parse(txtBacklog.Text) < 7)
			{
				//Subtract 1 developer from current player's developer count and show in text box
				player.Developers--;
				txtDevelopers.Text = Convert.ToString(player.Developers);

				//Add 1 developer to backlog count
				txtBacklog.Text = Convert.ToString(Int32.Parse(txtBacklog.Text) + 1);

			}
		}

		/// <summary>
		/// Event Handler for button to remove developer from backlog task/resource category if any are there
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnSubtBacklog_Click(object sender, EventArgs e)
		{
			SoundController.playButtonClick();

			//If the number of backlog developers is larger than 0, then subtract 1 from backlog count and add 1 to developer count
			//Else, do nothing
			if (Int32.Parse(txtBacklog.Text) > 0)
			{
				//Subtract 1 developer from backlog count
				txtBacklog.Text = Convert.ToString(Int32.Parse(txtBacklog.Text) - 1);

				//Add 1 developer to current player's developer count and show in text box
				player.Developers++;
				txtDevelopers.Text = Convert.ToString(player.Developers);

			}
		}

		/// <summary>
		/// Event Handler for button to add developer to low-priority task/resource category if any are available
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnAddLow_Click(object sender, EventArgs e)
		{
			SoundController.playButtonClick();

			//If the number of developers is larger than 0 and low-priority count is less than 7, then subtract 1 from developer count and add 1 to low-priority count
			//Else, do nothing
			if (player.Developers > 0 && Int32.Parse(txtLow.Text) < 7)
			{
				//Subtract 1 developer from current player's developer count and show in text box
				player.Developers--;
				txtDevelopers.Text = Convert.ToString(player.Developers);

				//Add 1 developer to low-priority count
				txtLow.Text = Convert.ToString(Int32.Parse(txtLow.Text) + 1);

			}
		}

		/// <summary>
		/// Event Handler for button to remove developer from low-priority task/resource category if any there
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnSubtLow_Click(object sender, EventArgs e)
		{
			SoundController.playButtonClick();

			//If the number of low-priority developers is larger than 0, then subtract 1 from low-priority count and add 1 to developer count
			//Else, do nothing
			if (Int32.Parse(txtLow.Text) > 0)
			{
				//Subtract 1 developer from low-priority count
				txtLow.Text = Convert.ToString(Int32.Parse(txtLow.Text) - 1);

				//Add 1 developer to current player's developer count and show in text box
				player.Developers++;
				txtDevelopers.Text = Convert.ToString(player.Developers);

			}
		}

		/// <summary>
		/// Event Handler for button to add developer to medium-priority task/resource category if any are available
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnAddMed_Click(object sender, EventArgs e)
		{
			SoundController.playButtonClick();

			//If the number of developers is larger than 0 and medium-priority count is less than 7, then subtract 1 from developer count and add 1 to medium-priority count
			//Else, do nothing
			if (player.Developers > 0 && Int32.Parse(txtMed.Text) < 7)
			{
				//Subtract 1 developer from current player's developer count and show in text box
				player.Developers--;
				txtDevelopers.Text = Convert.ToString(player.Developers);

				//Add 1 developer to medium-priority count
				txtMed.Text = Convert.ToString(Int32.Parse(txtMed.Text) + 1);

			}
		}

		/// <summary>
		/// Event Handler for button to remove developer from medium-priority task/resource category if any there
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnSubtMed_Click(object sender, EventArgs e)
		{
			SoundController.playButtonClick();

			//If the number of medium-priority developers is larger than 0, then subtract 1 from medium-priority count and add 1 to developer count
			//Else, do nothing
			if (Int32.Parse(txtMed.Text) > 0)
			{
				//Subtract 1 developer from medium-priority count
				txtMed.Text = Convert.ToString(Int32.Parse(txtMed.Text) - 1);

				//Add 1 developer to current player's developer count and show in text box
				player.Developers++;
				txtDevelopers.Text = Convert.ToString(player.Developers);

			}
		}

		/// <summary>
		/// Event Handler for button to add developer to high-priority task/resource category if any are available
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnAddHigh_Click(object sender, EventArgs e)
		{
			SoundController.playButtonClick();

			//If the number of developers is larger than 0 and high-priority count is less than 7, then subtract 1 from developer count and add 1 to high-priority count
			//Else, do nothing
			if (player.Developers > 0 && Int32.Parse(txtHigh.Text) < 7)
			{
				//Subtract 1 developer from current player's developer count and show in text box
				player.Developers--;
				txtDevelopers.Text = Convert.ToString(player.Developers);

				//Add 1 developer to medium-priority count
				txtHigh.Text = Convert.ToString(Int32.Parse(txtHigh.Text) + 1);

			}
		}

		/// <summary>
		/// Event Handler for button to remove developer from high-priority task/resource category if any there
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnSubtHigh_Click(object sender, EventArgs e)
		{
			SoundController.playButtonClick();

			//If the number of high-priority developers is larger than 0, then subtract 1 from high-priority count and add 1 to developer count
			//Else, do nothing
			if (Int32.Parse(txtHigh.Text) > 0)
			{
				//Subtract 1 developer from high-priority count
				txtHigh.Text = Convert.ToString(Int32.Parse(txtHigh.Text) - 1);

				//Add 1 developer to current player's developer count and show in text box
				player.Developers++;
				txtDevelopers.Text = Convert.ToString(player.Developers);

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
			SoundController.playButtonClick();

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
				//Print out current inventory text to inventoryBox
				inventoryBox.Text = player.Inventory.printResources();

				//Recalculate the score and update the score text box
				Scoring score = new Scoring(player.Inventory);
				scoreBox.Text = score.calculateScore();

				//Sets btnDoTasks and developer on task buttons to disabled so player cant do tasks again in same turn
				this.btnDoTasks.Enabled = false;
				this.btnAddBacklog.Enabled = false;
				this.btnSubtBacklog.Enabled = false;
				this.btnAddLow.Enabled = false;
				this.btnSubtLow.Enabled = false;
				this.btnAddMed.Enabled = false;
				this.btnSubtMed.Enabled = false;
				this.btnAddHigh.Enabled = false;
				this.btnSubtHigh.Enabled = false;
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
			SoundController.playButtonClick();

			//If the number of developers is larger than 0 and the number of developers at the tool maker less than 1, go to next check
			//Else, do nothing
			if (player.Developers > 0 && Int32.Parse(txtToolMaker.Text) < 1)
			{
				//If the last tool slot does not have the highest tool level, put a developer on the tool maker
				//Else, show error message
				if (Int32.Parse(toolSlot3.Text) != 4)
				{
					//If any other player has not put a developer at the tool maker, add a developer to the tool maker
					//Else, show error message
					if (GameController.toolMakerFull == false)
					{

						//Subtract 1 developer from current player's developer count and show in text box
						player.Developers--;
						txtDevelopers.Text = Convert.ToString(player.Developers);

						//Add 1 developer to tool maker count and show in text box
						txtToolMaker.Text = Convert.ToString(1);

						//Sets storage integer showing which player has a developer at the tool maker equal to the index of the player at the tool maker
						GameController.playerAtToolMaker = player.PlayerNum;
						GameController.toolMakerFull = true;
					}
					else
					{
						MessageBox.Show("Another player already has a developer at the Tool Maker."
						, "Cannot Assign Developer To Tool Maker"
						, MessageBoxButtons.OK
						, MessageBoxIcon.Error);
					} 
				}
				else
                {
					MessageBox.Show("You cannot acquire anymore tools because all three tools in your inventory are at max level."
					, "Cannot Acquire More Tools"
					, MessageBoxButtons.OK
					, MessageBoxIcon.Error);
				}
			}
		}

		/// <summary>
		/// Event Handler for button to remove developer from tool maker i a developer is already there and is the current player's developer
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnSubtToolMaker_Click(object sender, EventArgs e)
		{
			SoundController.playButtonClick();

			//If there is a developer from the current player at the tool maker, then subtract 1 from tool maker count and add 1 to developer count
			//Else, do nothing
			if (Int32.Parse(txtToolMaker.Text) > 0)
			{
				//Subtract 1 developer from tool maker and show in text box
				txtToolMaker.Text = Convert.ToString(0);

				//Add 1 developer to current player's developer count and show in text box
				player.Developers++;
				txtDevelopers.Text = Convert.ToString(player.Developers);

				//Resets the storage integer for showing which player has developer at the tool maker
				GameController.playerAtToolMaker = -1;
				GameController.toolMakerFull = false;
			}
		}
		#endregion

		#region Recruitment Office Buttons and Textboxes
		/// <summary>
		/// Sends two developers from the player's count of available devs.
		/// The two devs, as well as one additional dev, are returned to the player at the round's end.
		/// Only one player can use the recruitment office per round.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSendDevs_Click(object sender, EventArgs e)
		{
			SoundController.playButtonClick();

			//If the player has at least two developers, go to next check
			if (player.Developers >= 2)
			{
				//If the current player does not have the maximum number of 20 developers, go to next check
				//Else, show error message
				if (player.TeamCount < 20)
				{
					//If the recruitment office is not full, put developers at the recruitment office
					//Else, show error message
					if (GameController.recruitmentOfficeFull == false)
					{
						lblRecruitStatus.Text = $"Recruitment Status:\n-----------------------" +
							$"\nOccupied with 2 developers from Team:" +
							$"\n{player.TeamName}";

						player.Developers -= 2;
						txtDevelopers.Text = Convert.ToString(player.Developers);

						btnSendDevs.Enabled = false;
						btnRecallDevs.Enabled = true;

						GameController.playerAtRecruitmentOffice = player.PlayerNum;
						GameController.recruitmentOfficeFull = true;
					}
					else
					{
						MessageBox.Show("Another player already has developers at the Recruitment Office."
						, "Cannot Assign Developer To Recruitment Office"
						, MessageBoxButtons.OK
						, MessageBoxIcon.Error);
					}
				}
                else
                {
					MessageBox.Show("You cannot acquire anymore developers because you already have a maximum of 20 developers."
					, "Cannot Acquire More Developers"
					, MessageBoxButtons.OK
					, MessageBoxIcon.Error);
				}
			}
		}

		/// <summary>
		/// If the current player has just just assigned two developers to the recruitment office,
		/// pressing the recall button will remove the two devs and add them back to the player's
		/// available developers count
		/// </summary>
		private void btnRecallDevs_Click(object sender, EventArgs e)
		{
			SoundController.playButtonClick();

			player.Developers += 2;
			txtDevelopers.Text = Convert.ToString(player.Developers);
			lblRecruitStatus.Text = "";
			btnRecallDevs.Enabled = false;

			if (player.Developers >= 2)
			{
				btnSendDevs.Enabled = true;
				GameController.recruitmentOfficeFull = false;
			}
		}
		#endregion

		#region Project Progress Cards
		/// <summary>
		/// Claims the a project progress card
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void ClaimProgressCard1_Click(object sender, EventArgs e)
		{
			SoundController.playButtonClick();

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
		#endregion

		#region Additional Project Features Cards
		/// <summary>
		/// Claims the first feature card available, costs 4 resources
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ClaimFeaturesCard1_Click(object sender, EventArgs e)
		{
			SoundController.playButtonClick();

			AdditionalProjectFeaturesType[] cards = GameController.ClaimFeatureCard(0, 4);

			if (cards != null)
			{
				//Syncs the purchased card ඞmong all the players
				for (int i = 0; i < GameController.playerForms.Length; i++)
				{
					GameController.playerForms[i].ClaimFeaturesCard1.Enabled = false;

					if (GameController.ProjFeatDeck.AvailableCount() < 1)
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
			SoundController.playButtonClick();

			AdditionalProjectFeaturesType[] cards = GameController.ClaimFeatureCard(1, 3);

			if (cards != null)
			{
				//Syncs the purchased card ඞmong all the players
				for (int i = 0; i < GameController.playerForms.Length; i++)
				{
					GameController.playerForms[i].ClaimFeaturesCard2.Enabled = false;

					if (GameController.ProjFeatDeck.AvailableCount() < 2)
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
			SoundController.playButtonClick();

			AdditionalProjectFeaturesType[] cards = GameController.ClaimFeatureCard(2, 2);

			if (cards != null)
			{
				//Syncs the purchased card ඞmong all the players
				for (int i = 0; i < GameController.playerForms.Length; i++)
				{
					GameController.playerForms[i].ClaimFeaturesCard3.Enabled = false;

					if (GameController.ProjFeatDeck.AvailableCount() < 3)
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
			SoundController.playButtonClick();

			AdditionalProjectFeaturesType[] cards = GameController.ClaimFeatureCard(3, 1);

			if (cards != null)
			{
				//Syncs the purchased card ඞmong all the players
				for (int i = 0; i < GameController.playerForms.Length; i++)
				{
					GameController.playerForms[i].ClaimFeaturesCard4.Enabled = false;

					if (GameController.ProjFeatDeck.AvailableCount() < 4)
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
			DialogResult DLResult = DialogResult.None;	// Stores the selected result form the player

			SoundController.playButtonClick();

			if (btnDoTasks.Enabled == true)
            {
				DLResult = MessageBox.Show("You still have the ability to \"Do Tasks\" are you sure you want to skip your turn?", "Skip turn?", MessageBoxButtons.YesNo);
			}

            if (btnDoTasks.Enabled == false || DLResult == DialogResult.Yes)
            {
                //Re-enables do task button and developers on tasks buttons for next time current player has a turn
                this.btnDoTasks.Enabled = true;
                this.btnAddBacklog.Enabled = true;
                this.btnSubtBacklog.Enabled = true;
                this.btnAddLow.Enabled = true;
                this.btnSubtLow.Enabled = true;
                this.btnAddMed.Enabled = true;
                this.btnSubtMed.Enabled = true;
                this.btnAddHigh.Enabled = true;
                this.btnSubtHigh.Enabled = true;

                //Sends all developers from tasks area back to developer pool
                SendDevsBackFromTasks();

                //Ends current player's turn and goes to next player's turn
                GameController.endTurn(); 
            }
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
		/// Event Handler for Options dropdown menu button to go to options screen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// 
		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new OptionsForm().Show();
		}
		/// <summary>
		/// Event Handler for dropdown menu button to quit to main menu
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnQuitToMenuMenuItem_Click(object sender, EventArgs e)
		{
			new QuitToMenuForm().Show();
		}

		/// <summary>
		/// Event Handler for dropdown menu button to open "are you sure you want to quit?" windows form
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnQuitToDesktopMenuItem_Click(object sender, EventArgs e)
		{
			new QuitForm().Show();
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
			new StatsForm().Show();
		}

		/// <summary>
		/// Method: instructionsToolStripMenuItem_Click opens the Instructionset.txt file upon clicking
		/// the btnInstructions button on the main form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GameController.openInstructions();
		}

		/// <summary>
		/// Event Handler for dropdown menu button to open AboutBox with information about the game
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new AboutBox().Show();
		}
        #endregion

        #region Form Closing
        /// <summary>
        /// Handles the FormClosing event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
			e.Cancel = true; // Prevents the window form instantly closing
			btnQuitToMenuMenuItem_Click(sender, e);
		}
        #endregion
    }
}