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
		//Player and Dice instances to be used throughout program
		Player player1 = new Player();
		Dice dice = new Dice();
		ProjectProgressDeck ProjProgDeck = new ProjectProgressDeck( );

		public MainForm( )
		{
			InitializeComponent( );
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.txtDevelopers.Text = player1.Developers.ToString( );
			ProjectProgressCard1.Text = ProjProgDeck.Deck[0].DisplayCard( );
			ProjectProgressCard2.Text = ProjProgDeck.Deck[1].DisplayCard( );
			ProjectProgressCard3.Text = ProjProgDeck.Deck[2].DisplayCard( );
			ProjectProgressCard4.Text = ProjProgDeck.Deck[3].DisplayCard( );
		}

		#region Task/Resource/Scoring Buttons and Textboxes
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

		/// <summary>
		/// Event Handler for button to tell developers to do tasks and then roll dice to calculate how many tasks/resources are completed/acquired
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnDoTasks_Click(object sender, EventArgs e)
		{
			//Stores current counts of developers on each task/resource for calculation
			int backlogNum = Int32.Parse(txtBacklog.Text);
			int lowNum = Int32.Parse(txtLow.Text);
			int medNum = Int32.Parse(txtMed.Text);
			int highNum = Int32.Parse(txtHigh.Text);

			//Add calculated resources to ResourceManager for current player
			//(Number of dice rolled is equal to number of developers on specific resource)
			//(Dice result is then divided by 3,4,5, or 6 to get final resource count acquired)
			player1.Inventory.addToBacklog(dice.RollDice(backlogNum) / 3);      //Lowest-tier resource divided by 3
			player1.Inventory.addToLowPriority(dice.RollDice(lowNum) / 4);      //Low-tier resource divided by 4
			player1.Inventory.addToMediumPriority(dice.RollDice(medNum) / 5);   //Mid-tier resource divided by 5
			player1.Inventory.addToHighPriority(dice.RollDice(highNum) / 6);    //Highest-tier resource divided by 6

			//Print out current inventory text to inventoryBox
			inventoryBox.Text = player1.Inventory.printInventory();

			//Resets developer counts on each task/resource
			txtBacklog.Text = "0";
			txtLow.Text = "0";
			txtMed.Text = "0";
			txtHigh.Text = "0";

			//Adds developers back to player's free developer pool
			int leftoverDevelopers = Int32.Parse(txtDevelopers.Text);
			txtDevelopers.Text = Convert.ToString(leftoverDevelopers + backlogNum + lowNum + medNum + highNum);

			//Recalculate the score and update the score text box
			Scoring score = new Scoring(player1.Inventory);
			scoreBox.Text = score.calculateScore();
		}
		#endregion

		#region Toolbar Dropdown Menu Buttons
		/// <summary>
		/// Method: btnInstructions_Click opens the Instructionset.txt file upon clicking
		/// the btnInstructions button on the main form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnInstructionsMenuItem_Click(object sender, EventArgs e)
		{
			//Get the current directory
			string filePath = Directory.GetCurrentDirectory();

			//Move up two parent directories
			filePath = Directory.GetParent(filePath).FullName;
			filePath = Directory.GetParent(filePath).FullName;

			//Append the location of InstructionSet.txt to filePath
			filePath += "/Files/InstructionSet.txt";

			//Open the file located at filePath (which is InstructionSet.txt
			Process.Start(filePath);
		}

		/// <summary>
		/// Event Handler for dropdown menu button to open "about" windows form
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnAboutMenuItem_Click(object sender, EventArgs e)
		{
			//Opens new AboutBox window for About information
			AboutBox aboutBox = new AboutBox();
			aboutBox.Show();
		}

		/// <summary>
		/// Event Handler for dropdown menu button to open "are you sure you want to quit?" windows form
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnQuitMenuItem_Click(object sender, EventArgs e)
		{
			//Opens new QuitForm window for prompting user if they want to exit application
			QuitForm quitForm = new QuitForm();
			quitForm.Show();
		}
		#endregion

		#region Project Progress Cards
		/// <summary>
		/// Claims the first project progress card
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void ClaimCard1_Click(object sender, EventArgs e)
		{
			int points = ProjProgDeck.Deck[0].awardPoints(player1.Inventory.ReturnManager( )) ;
			Scoring score = new Scoring(player1.Inventory);

			if (points > 0)
			{
				// TODO: award points to player
				ProjProgDeck.Deck.RemoveAt(0);
				ClaimCard1.Enabled = false;
				ProjectProgressCard1.Text = "Card claimed by\r\nPLAYERPLACEHOLDER";
				inventoryBox.Text = player1.Inventory.printInventory( );
				scoreBox.Text = score.calculateScore( );
			}
		}

		/// <summary>
		/// Claims the second project progress card
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void ClaimCard2_Click(object sender, EventArgs e)
		{
			int points = ProjProgDeck.Deck[0].awardPoints(player1.Inventory.ReturnManager( ));
			Scoring score = new Scoring(player1.Inventory);

			if (points > 0)
			{
				// TODO: award points to player
				ProjProgDeck.Deck.RemoveAt(1);
				ClaimCard2.Enabled = false;
				ProjectProgressCard2.Text = "Card claimed by\r\nPLAYERPLACEHOLDER";
				inventoryBox.Text = player1.Inventory.printInventory( );
				scoreBox.Text = score.calculateScore( );
			}
		}

		/// <summary>
		/// Claims the third project progress card
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void ClaimCard3_Click(object sender, EventArgs e)
		{
			int points = ProjProgDeck.Deck[0].awardPoints(player1.Inventory.ReturnManager( ));
			Scoring score = new Scoring(player1.Inventory);

			if (points > 0)
			{
				// TODO: award points to player
				ProjProgDeck.Deck.RemoveAt(2);
				ClaimCard3.Enabled = false;
				ProjectProgressCard3.Text = "Card claimed by\r\nPLAYERPLACEHOLDER";
				inventoryBox.Text = player1.Inventory.printInventory( );
				scoreBox.Text = score.calculateScore( );
			}
		}

		/// <summary>
		/// Claims the fourth project progress card
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void ClaimCard4_Click(object sender, EventArgs e)
		{
			int points = ProjProgDeck.Deck[0].awardPoints(player1.Inventory.ReturnManager( ));
			Scoring score = new Scoring(player1.Inventory);

			if (points > 0)
			{
				// TODO: award points to player
				ProjProgDeck.Deck.RemoveAt(3);
				ClaimCard4.Enabled = false;
				ProjectProgressCard4.Text = "Card claimed by\r\nPLAYERPLACEHOLDER";
				inventoryBox.Text = player1.Inventory.printInventory( );
				scoreBox.Text = score.calculateScore( );
			}
		}
		#endregion

	}
}