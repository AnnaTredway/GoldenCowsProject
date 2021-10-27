///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         GameController.cs
//	Description:       GameController class for methods and controls the windows forms of the program
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Friday, October 22, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationAgeProject
{
	/// <summary>
	/// GameController class for methods and controls the windows forms of the program
	/// </summary>
	public class GameController
	{
		public static int turnCounter = 0;
		public static Dice dice;
		public static Player[] playerList;
		public static MainForm[] playerForms;
		public static ProjectProgressDeck ProjProgDeck;
		public static AdditionalProjectFeaturesDeck ProjFeatDeck;

		#region GameController Constructor
		/// <summary>
		/// Private Constructor for GameController 
		/// </summary>
		private GameController() { }
		#endregion

		#region startGame() Method
		/// <summary>
		/// Method for starting game with set number of players to open set number of MainForms for each player
		/// </summary>
		/// <param name="playerCount">Number of players to start game with</param>
		/// <param name="teamNames">Team names of each player</param>
		/// <returns>Bool of whether or not the main menu should be invisible for starting game</returns>
		public static bool startGame(int playerCount, string[] teamNames)
		{
			//Checks if number of players is between 2 and 4
			//Ends method immediately if there are not atleast 2 players or more than 4 players
			if(playerCount < 2 || playerCount > 4)
			{
				MessageBox.Show("Number of players cannot be less than 2 or more than 4."
						, "Invalid Number Of Players"
						, MessageBoxButtons.OK
						, MessageBoxIcon.Error);

				return false;//Main menu stays visible
			}

			for(int i = 0; i < playerCount; i++)
			{
				if (string.IsNullOrWhiteSpace(teamNames[i]))
				{
					MessageBox.Show("You cannot start the game without typing in a team name each for the amount of players selected."
						, "Team Names Not Input"
						, MessageBoxButtons.OK
						, MessageBoxIcon.Error);
					return false;//Main menu stays visible
				}
			}

			//Activates Dice instance
			dice = new Dice();

			//Sets array index counts to playerCount number
			playerList = new Player[playerCount];
			playerForms = new MainForm[playerCount];

			//Creates new master card decks
			ProjProgDeck = new ProjectProgressDeck();
			ProjFeatDeck = new AdditionalProjectFeaturesDeck();

			//Activates players, sets their team names, and instantiates their MainForms
			for (int i = 0; i < playerCount; i++)
			{
				playerList[i] = new Player();
				playerList[i].TeamName = teamNames[i];
				playerForms[i] = new MainForm(playerList[i], ProjProgDeck, ProjFeatDeck);
			}

			//Shows first player form for first turn within first round
			playerForms[0].Show();

			return true;//Main menu becomes invisible

		}//end startGame()
		#endregion

		#region endTurn() Method
		/// <summary>
		/// Method for ending turn to go to next player's turn
		/// </summary>
		public static void endTurn()
		{
			//Current form is set to invisible so it is not in the way of the next player
			playerForms[turnCounter].Visible = false;

			//Turn counter goes up by one to move on to next player
			turnCounter++;

			try
			{
				//If there is a player form at the turnCounter index, go to that form
				playerForms[turnCounter].Visible = true;
			}
			catch
			{
				//If there is not a player form at the turnCounter index, go back to first player form
				turnCounter = 0;
				playerForms[turnCounter].Visible = true;
			}

		}//end endTurn()
		#endregion

		#region calcTasks() Method
		/// <summary>
		/// Method for calculating number of tasks that player should acquire based on random dice rolls and tool usage and stores them in player's inventory
		/// </summary>
		/// <param name="player">Player that is currently collecting tasks/resources</param>
		/// <param name="player">Array of developer counts for each task/resource for current player</param>
		/// <returns>Bool of whether or not task calculation was successful (Used for determining if DoTasks button should be deactivated for current turn)</returns>
		public static bool calcTasks(Player player, int[] devCounts)
		{
			//Checks if input Player object is null
			if (player == null)
			{
				MessageBox.Show("ERROR: Input Player object null in calcTasks() method."
					, "Player Object Null"
					, MessageBoxButtons.OK
					, MessageBoxIcon.Error);

				return false;   //Value to return to show that calculation was unsuccessful
			}

			//Checks if input devCounts length is not equal to 4
			if (devCounts.Length != 4)
			{
				MessageBox.Show("The input number of indexes in devCounts has to be equal to 4 when calculating tasks."
					, "Number Of Developer Count Categories Invalid"
					, MessageBoxButtons.OK
					, MessageBoxIcon.Error);

				return false;   //Value to return to show that calculation was unsuccessful
			}

			if (devCounts[0] == 0
			 && devCounts[1] == 0
			 && devCounts[2] == 0
			 && devCounts[3] == 0)
			{
				MessageBox.Show("You cannot acquire any tasks because you have no developers at any of the 4 task areas."
					, "Cannot Acquire Tasks"
					, MessageBoxButtons.OK 
					, MessageBoxIcon.Error);

				return false; //Value to return to show that calculation was unsuccessful
			}
			else
			{
				//Dice is rolled for current player on resources/tasks
				//(Number of dice rolled is equal to number of developers on specific resource)
				int[] diceVals = new int[4];
				diceVals[0] = dice.rollDice(devCounts[0]);
				diceVals[1] = dice.rollDice(devCounts[1]);
				diceVals[2] = dice.rollDice(devCounts[2]);
				diceVals[3] = dice.rollDice(devCounts[3]);

				//Before divide calculation, a prompt window for using tools is shown if the player wants to use one or more tools
				//These array values may not change if the player decides to not use any tools or has no tool levels to begin with
				int[] finalToolVals = new int[4] { 0, 0, 0, 0 };

				//Prompts user for possibility of using tools if first tool is not level 0 
				if (player.Inventory.getToolLevelList()[0] != 0)
				{
					//Shows new toolPrompt for possibility of player using tools
					//Uses list of tool levels and dice values for player to help decide if they want to use tools on tasks/resources
					ToolTaskPrompt toolPrompt = new ToolTaskPrompt(player.Inventory.getToolLevelList(), diceVals);
					toolPrompt.ShowDialog();

					finalToolVals = toolPrompt.finalToolValues;
				}

				//Final dice and tool result is then divided by 3, 4, 5, or 6 to get final resource/task count acquired
				player.Inventory.addToBacklog((diceVals[0] + finalToolVals[0]) / 3);           //Lowest-tier backlog resource final result divided by 3
				player.Inventory.addToLowPriority((diceVals[1] + finalToolVals[1]) / 4);       //Low-tier resource divided by 4
				player.Inventory.addToMediumPriority((diceVals[2] + finalToolVals[2]) / 5);    //Mid-tier resource divided by 5
				player.Inventory.addToHighPriority((diceVals[3] + finalToolVals[3]) / 6);      //Highest-tier resource divided by 6

				return true;	//Value to return to show that calculation was successful
			}

		}//end calcTasks()
		#endregion

		#region calcToolLevelsFromList() Method
		/// <summary>
		/// Method for returning total added up levels value from a single list
		/// </summary>
		/// <param name="listBox">List of tools to have levels added up from</param>
		/// <returns>Int of total calculated levels add up from list (Returns -1 if error occurs)</returns>
		public static int calcToolLevelsFromList(ListBox listBox)
		{
			//Checks if input ListBox object is null
			if (listBox == null)
			{
				MessageBox.Show("ERROR: Input ListBox object null in calcToolLevelsFromList() method.."
					, "ListBox Object Null"
					, MessageBoxButtons.OK
					, MessageBoxIcon.Error);
				return -1;   //Value to return to show that calculation was unsuccessful
			}

			int finalToolVal = 0;

			//If there are items in the list, go through each item's level and add them up
			//Else, just return the 0 that finalToolVal was instantiated with
			if (listBox.Items.Count != 0)
			{
				foreach (var item in listBox.Items)
				{
					finalToolVal += int.Parse(item.ToString().Substring(item.ToString().Length - 1));
				}
			}

			return finalToolVal;

		}//end calcToolLevelsFromList()
		#endregion

		#region openInstructions() Method
		/// <summary>
		/// Method for opening game instructions
		/// </summary>
		public static void openInstructions()
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

		}//end openInstructions()
		#endregion

		#region openAbout() Method
		/// <summary>
		/// Method for opening about information within AboutBox for game
		/// </summary>
		public static void openAboutBox()
		{
			//Opens new AboutBox window for About information
			AboutBox aboutBox = new AboutBox();
			aboutBox.Show();

		}//end openAbout()
		#endregion

		#region quitGame() Method
		/// <summary>
		/// Method for opening QuitForm to prompt user to quit game or not
		/// </summary>
		public static void quitGame()
		{
			//Opens new QuitForm window for prompting user if they want to exit application
			QuitForm quitForm = new QuitForm();
			quitForm.Show();

		}//end quitGame()
		#endregion
	}
}
