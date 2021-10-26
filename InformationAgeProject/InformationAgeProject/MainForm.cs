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
		ProjectProgressDeck ProjProgDeck;
		AdditionalProjectFeaturesDeck ProjFeatDeck;

		public MainForm(Player player, ProjectProgressDeck progressDeck, AdditionalProjectFeaturesDeck featuresDeck)
		{
			InitializeComponent();

			//Assigns player and corresponding team name to this MainForm instance
			this.player = player;
			this.Text = "Information Age: " + player.TeamName;

			//Assigns master deck to current mainform
			ProjProgDeck = progressDeck;
			ProjFeatDeck = featuresDeck;
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
			ProjectProgressCard1.Text = ProjProgDeck.Deck[0].displayCard();
			ProjectProgressCard2.Text = ProjProgDeck.Deck[1].displayCard();
			ProjectProgressCard3.Text = ProjProgDeck.Deck[2].displayCard();
			ProjectProgressCard4.Text = ProjProgDeck.Deck[3].displayCard();

			//Loads initial feature cards into AdditionalFeatures textboxes
			AdditionalFeaturesTextBox1.Text = ProjFeatDeck.Deck[0].displayCard();
			AdditionalFeaturesTextBox2.Text = ProjFeatDeck.Deck[1].displayCard();
			AdditionalFeaturesTextBox3.Text = ProjFeatDeck.Deck[2].displayCard();
			AdditionalFeaturesTextBox4.Text = ProjFeatDeck.Deck[3].displayCard();

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
			int points = ProjProgDeck.Deck[0].claimCard(player.Inventory.ReturnResourceManager( )) ;
			Scoring score = new Scoring(player.Inventory);

			if (points > 0)
			{
				player.Inventory.ProjectProgressCards.Add(ProjProgDeck.Deck[0]);
				ProjProgDeck.Deck[0].blnSold = true;
				ClaimProgressCard1.Enabled = false;
				ProjectProgressCard1.Text = "Card claimed by\r\nPLAYERPLACEHOLDER";
				inventoryBox.Text = player.Inventory.printResources( );
				scoreBox.Text = score.calculateScore( );
			}
		}

		/// <summary>
		/// Claims the second project progress card
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void ClaimProgressCard2_Click(object sender, EventArgs e)
		{
			int points = ProjProgDeck.Deck[1].claimCard(player.Inventory.ReturnResourceManager( ));
			Scoring score = new Scoring(player.Inventory);

			if (points > 0)
			{
				player.Inventory.ProjectProgressCards.Add(ProjProgDeck.Deck[1]);
				ProjProgDeck.Deck[1].blnSold = true;
				ClaimProgressCard2.Enabled = false;
				ProjectProgressCard2.Text = "Card claimed by\r\nPLAYERPLACEHOLDER";
				inventoryBox.Text = player.Inventory.printResources( );
				scoreBox.Text = score.calculateScore( );
			}
		}

		/// <summary>
		/// Claims the third project progress card
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void ClaimProgressCard3_Click(object sender, EventArgs e)
		{
			int points = ProjProgDeck.Deck[2].claimCard(player.Inventory.ReturnResourceManager( ));
			Scoring score = new Scoring(player.Inventory);

			if (points > 0)
			{
				player.Inventory.ProjectProgressCards.Add(ProjProgDeck.Deck[2]);
				ProjProgDeck.Deck[2].blnSold = true;
				ClaimProgressCard3.Enabled = false;
				ProjectProgressCard3.Text = "Card claimed by\r\nPLAYERPLACEHOLDER";
				inventoryBox.Text = player.Inventory.printResources( );
				scoreBox.Text = score.calculateScore( );
			}
		}

		/// <summary>
		/// Claims the fourth project progress card
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void ClaimProgressCard4_Click(object sender, EventArgs e)
		{
			int points = ProjProgDeck.Deck[3].claimCard(player.Inventory.ReturnResourceManager( ));
			Scoring score = new Scoring(player.Inventory);

			if (points > 0)
			{
				player.Inventory.ProjectProgressCards.Add(ProjProgDeck.Deck[3]);
				ProjProgDeck.Deck[3].blnSold = true;
				ClaimProgressCard4.Enabled = false;
				ProjectProgressCard4.Text = "Card claimed by\r\nPLAYERPLACEHOLDER";
				inventoryBox.Text = player.Inventory.printResources( );
				scoreBox.Text = score.calculateScore( );
			}
		}
		#endregion

		#region Additional Project Features Cards
		private void ClaimFeaturesCard1_Click(object sender, EventArgs e)
		{
			AdditionalProjectFeaturesType[] cards = ProjFeatDeck.Deck[0].claimCard(4, player.Inventory);
			Scoring score = new Scoring(player.Inventory);

			if (cards != null)
			{
				player.Inventory.AdditionalProjectFeaturesCards.Add(ProjFeatDeck.Deck[0]);
				ProjFeatDeck.Deck[0].blnSold = true;
				ClaimFeaturesCard1.Enabled = false;
				AdditionalFeaturesTextBox1.Text = "Card claimed by\r\nPLAYERPLACEHOLDER";
				inventoryBox.Text = player.Inventory.printResources( );
				scoreBox.Text = score.calculateScore( );
				int[] toolLevelList = player.Inventory.getToolLevelList( );
				toolSlot1.Text = toolLevelList[0].ToString( );
				toolSlot2.Text = toolLevelList[1].ToString( );
				toolSlot3.Text = toolLevelList[2].ToString( );
			}
		}

		private void ClaimFeaturesCard2_Click(object sender, EventArgs e)
		{
			AdditionalProjectFeaturesType[] cards = ProjFeatDeck.Deck[1].claimCard(3, player.Inventory);
			Scoring score = new Scoring(player.Inventory);

			if (cards != null)
			{
				player.Inventory.AdditionalProjectFeaturesCards.Add(ProjFeatDeck.Deck[1]);
				ProjFeatDeck.Deck[1].blnSold = true;
				ClaimFeaturesCard2.Enabled = false;
				AdditionalFeaturesTextBox2.Text = "Card claimed by\r\nPLAYERPLACEHOLDER";
				inventoryBox.Text = player.Inventory.printResources( );
				scoreBox.Text = score.calculateScore( );
				int[] toolLevelList = player.Inventory.getToolLevelList( );
				toolSlot1.Text = toolLevelList[0].ToString( );
				toolSlot2.Text = toolLevelList[1].ToString( );
				toolSlot3.Text = toolLevelList[2].ToString( );
			}
		}

		private void ClaimFeaturesCard3_Click(object sender, EventArgs e)
		{
			AdditionalProjectFeaturesType[] cards = ProjFeatDeck.Deck[2].claimCard(2, player.Inventory);
			Scoring score = new Scoring(player.Inventory);

			if (cards != null)
			{
				player.Inventory.AdditionalProjectFeaturesCards.Add(ProjFeatDeck.Deck[2]);
				ProjFeatDeck.Deck[2].blnSold = true;
				ClaimFeaturesCard3.Enabled = false;
				AdditionalFeaturesTextBox3.Text = "Card claimed by\r\nPLAYERPLACEHOLDER";
				inventoryBox.Text = player.Inventory.printResources( );
				scoreBox.Text = score.calculateScore( );
				int[] toolLevelList = player.Inventory.getToolLevelList( );
				toolSlot1.Text = toolLevelList[0].ToString( );
				toolSlot2.Text = toolLevelList[1].ToString( );
				toolSlot3.Text = toolLevelList[2].ToString( );
			}
		}

		private void ClaimFeaturesCard4_Click(object sender, EventArgs e)
		{
			AdditionalProjectFeaturesType[] cards = ProjFeatDeck.Deck[3].claimCard(1, player.Inventory);
			Scoring score = new Scoring(player.Inventory);

			if (cards != null)
			{
				player.Inventory.AdditionalProjectFeaturesCards.Add(ProjFeatDeck.Deck[3]);
				ProjFeatDeck.Deck[3].blnSold = true;
				ClaimFeaturesCard4.Enabled = false;
				AdditionalFeaturesTextBox4.Text = "Card claimed by\r\nPLAYERPLACEHOLDER";
				inventoryBox.Text = player.Inventory.printResources( );
				scoreBox.Text = score.calculateScore( );
				int[] toolLevelList = player.Inventory.getToolLevelList( );
				toolSlot1.Text = toolLevelList[0].ToString( );
				toolSlot2.Text = toolLevelList[1].ToString( );
				toolSlot3.Text = toolLevelList[2].ToString( );
			}
		}
		#endregion

		#region Menubar Dropdown Menu Buttons
		/// <summary>
		/// Event Handler for Statistics dropdown menu button to view the inventory, tools, etc. of all players
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Method: btnInstructions_Click opens the Instructionset.txt file upon clicking
		/// the btnInstructions button on the main form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnInstructionsMenuItem_Click(object sender, EventArgs e)
		{
			//Opens game instructions
			GameController.openInstructions();
		}

		/// <summary>
		/// Event Handler for dropdown menu button to open "about" windows form
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnAboutMenuItem_Click(object sender, EventArgs e)
		{
			//Opens AboutBox with information about the game
			GameController.openAboutBox();
		}

		/// <summary>
		/// Event Handler for dropdown menu button to quit to main menu
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnQuitToMenuMenuItem_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Event Handler for dropdown menu button to open "are you sure you want to quit?" windows form
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnQuitToDesktopMenuItem_Click(object sender, EventArgs e)
		{
			//Opens QuitForm to prompt user to quit game or not
			GameController.quitGame();
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
	}
}