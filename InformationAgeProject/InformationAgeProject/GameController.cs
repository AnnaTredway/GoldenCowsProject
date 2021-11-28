///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         GameController.cs
//	Description:       GameController class for methods and controls of the windows forms and game functionality of the program
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
		public static int turnCounter = 0;			//Counts what turn currently being done within a single round
		public static int roundCounter = 1;			//Counts how many rounds are in game and stores current round

		public static bool toolMakerFull = false;   //Shows whether or not the tool maker is currently occupied by a developer
		public static int playerAtToolMaker = -1;   //Array index of player that has developer at tool maker

		public static bool recruitmentOfficeFull = false;   //Shows whether or not the recruitment office is currently occupied by a developer
		public static int playerAtRecruitmentOffice = -1;   //Array index of player that has developer at recruitment office

		public static Timer loadingTimer;			//Timer to elapse for 9.5 seconds for loading initial sounds
		public static MainMenu mainMenu;			//MainMenu instance that opens when opening game
		public static Player[] playerList;			//Array of players for game
		public static MainForm[] playerForms;		//Array of MainForms to be used by players

		public static ProjectProgressDeck[] ProjProgDeck { get; set; }
		public static AdditionalProjectFeaturesDeck ProjFeatDeck { get; set; }

		#region GameController Constructor
		/// <summary>
		/// Private Constructor for GameController 
		/// </summary>
		private GameController() { }
		#endregion

		#region openGame() Method
		/// <summary>
		/// Method for opening game to main menu on startup
		/// </summary>
		public static void openGame()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//Opens all sound files before game opens and then starts music
			SoundController.openAllSounds();

			//Timer to elapse for 9.5 seconds for loading initial sounds
			loadingTimer = new Timer();
			loadingTimer.Tick += c_OnLoadingTimerEnd;
			loadingTimer.Interval = 9500;
			loadingTimer.Enabled = true;

			//Opens application to main menu
			mainMenu = new MainMenu();
			Application.Run(mainMenu);

		}//end openGame()
		#endregion

		//Game functionality method regions
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
			//Ends method immediately if there are not at least 2 players or more than 4 players
			if (playerCount < 2 || playerCount > 4)
			{
				MessageBox.Show("Number of players cannot be less than 2 or more than 4."
						, "Invalid Number Of Players"
						, MessageBoxButtons.OK
						, MessageBoxIcon.Error);

				return false;//Main menu stays visible
			}

			for (int i = 0; i < playerCount; i++)
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

			//Sets array index counts to playerCount number
			playerList = new Player[playerCount];
			playerForms = new MainForm[playerCount];
			ProjProgDeck = new ProjectProgressDeck[playerCount];

			//Creates new master card decks
			for (int i = 0; i < ProjProgDeck.Length; i++)
			{
				ProjProgDeck[i] = new ProjectProgressDeck();
			}

			ProjFeatDeck = new AdditionalProjectFeaturesDeck();

			//Activates players, sets their team names, sets their player numbers, and instantiates their MainForms
			for (int i = 0; i < playerCount; i++)
			{
                playerList[i] = new Player
                {
                    TeamName = teamNames[i],
                    PlayerNum = i
                };

                playerForms[i] = new MainForm(playerList[i]);
			}

			//Shows first player form for first turn within first round
			playerForms[0].Show();

			return true;//Main menu becomes invisible

		}//end startGame()
		#endregion

		#region calcTasks() Method
		/// <summary>
		/// Method for calculating number of tasks that player should acquire based on random dice rolls and tool usage and stores them in player's inventory
		/// </summary>
		/// <param name="player">Player that is currently collecting tasks/resources</param>
		/// <param name="devCounts">Array of developer counts for each task/resource for current player</param>
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
				Dice dice = new Dice();
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

		#region acquireTool() Method
		/// <summary>
		/// Method for a player to acquire tool from tool maker if that player has a developer at the tool maker when the round ends
		/// </summary>
		public static void acquireTool()
		{
			//Adds one tool to inventory of the player with a developer at the tool maker if able to
			playerList[playerAtToolMaker].Inventory.addTool();

			//Adds player's developer back to their free developer pool
			playerList[playerAtToolMaker].Developers++;

			playerAtToolMaker = -1; //Resets value of player at tool maker to not equal any player for new round
			toolMakerFull = false;	//Resets boolean for checking if a player has a developer at the tool maker

		}//end acquireTool()
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

		#region Claim Project Progress Card		
		/// <summary>
		/// Claims a selected Project Progress card.
		/// </summary>
		/// <param name="cardNumber">The card number.</param>
		public static int ClaimProgressCard()
		{
			int points = ProjProgDeck[turnCounter].Deck[0].claimCard(playerList[turnCounter].Inventory.ReturnResourceManager()); // Gets the number of points the card returns
			Scoring score = new Scoring(playerList[turnCounter].Inventory);                                                       // Calculates the total score of the player

			if (points > 0)
			{
				playerList[turnCounter].Inventory.ProjectProgressCards.Add(ProjProgDeck[turnCounter].Deck[0]);

				ProjProgDeck[turnCounter].Deck.RemoveAt(0);

				playerForms[turnCounter].inventoryBox.Text = playerList[turnCounter].Inventory.printResources();
				playerForms[turnCounter].scoreBox.Text = score.calculateScore();

				return points;
			}
			return 0;
		}
		#endregion

		#region Claim Project Feature Card
		/// <summary>
		/// Claims a feature card.
		/// </summary>
		/// <param name="cardNumber">The card's index in the array.</param>
		/// <param name="cardCost">The card's cost in resources.</param>
		/// <returns></returns>
		public static AdditionalProjectFeaturesType[] ClaimFeatureCard(int cardNumber, int cardCost)
		{
			AdditionalProjectFeaturesType[] cards = ProjFeatDeck.Deck[cardNumber].claimCard(cardCost, playerList[turnCounter].Inventory); // The items rewarded by the card
			Scoring score = new Scoring(playerList[turnCounter].Inventory);     // The total calculated score from the player
			int cardCounter = ProjFeatDeck.Deck.Count;                          // The total number of cards left in the deck

			// if there are cards returned then the player did not have enough resources to claim the card
			// if the player claims the card the player is given the card and updates the player's inventory
			if (cards != null)
			{
				playerList[turnCounter].Inventory.AdditionalProjectFeaturesCards.Add(ProjFeatDeck.Deck[cardNumber]);
				ProjFeatDeck.Deck[cardNumber].blnSold = true;
				ProjFeatDeck.Deck[cardNumber].strCard = "Card claimed by\r\n" + playerList[turnCounter].TeamName;
				playerForms[turnCounter].inventoryBox.Text = playerList[turnCounter].Inventory.printResources();
				playerForms[turnCounter].scoreBox.Text = score.calculateScore();

				// Updates the number of available cards in the deck
				for (int i = 0; i < ProjFeatDeck.Deck.Count; i++)
				{
					if (ProjFeatDeck.Deck[i].blnSold == true)
					{
						cardCounter--;
					}
				}

                for (int i = 0; i < playerForms.Length; i++)
                {
                    playerForms[i].ProjectFeaturesCardsGroupBox.Text = "Project Features Cards: " + cardCounter + " cards remain";
                }

				int[] toolLevelList = playerList[turnCounter].Inventory.getToolLevelList();
				playerForms[turnCounter].toolSlot1.Text = toolLevelList[0].ToString();
				playerForms[turnCounter].toolSlot2.Text = toolLevelList[1].ToString();
				playerForms[turnCounter].toolSlot3.Text = toolLevelList[2].ToString();
				return cards;
			}
			return null;
		}
		#endregion

		#region Remove Claimed Project Feature Cards
		/// <summary>
		/// Removes any claimed cards at the deck.
		/// </summary>
		public static void removeClaimedFeatureCards()
		{
			for (int i = 0; i < ProjFeatDeck.Deck.Count; i++)
			{
				if (ProjFeatDeck.Deck[i].blnSold == true)
				{
					ProjFeatDeck.Deck.RemoveAt(i);
					i = -1;
				}
			}

			if (ProjFeatDeck.Deck.Count >= 4)
			{
				for (int i = 0; i < playerForms.Length; i++)
				{
					playerForms[i].AdditionalFeaturesTextBox1.Text = ProjFeatDeck.Deck[0].displayCard();
					playerForms[i].ClaimFeaturesCard1.Enabled = true;
					playerForms[i].AdditionalFeaturesTextBox2.Text = ProjFeatDeck.Deck[1].displayCard();
					playerForms[i].ClaimFeaturesCard2.Enabled = true;
					playerForms[i].AdditionalFeaturesTextBox3.Text = ProjFeatDeck.Deck[2].displayCard();
					playerForms[i].ClaimFeaturesCard3.Enabled = true;
					playerForms[i].AdditionalFeaturesTextBox4.Text = ProjFeatDeck.Deck[3].displayCard();
					playerForms[i].ClaimFeaturesCard4.Enabled = true;
				}
			}
			else
			{
				// The game should end and final score should be tallied
				MessageBox.Show("The game should end");

			}

		}
        #endregion

        #region Calculate Project Feature Card's score		
        /// <summary>
        /// Calculates the points earned from collecting feature cards.
        /// </summary>
        /// <param name="currentPlayer">The current player.</param>
        /// <returns>The points the player has earned.</returns>
        public static int calculateFeatureCardPoints(Player currentPlayer)
		{
			int iPoints = 0;					// Stores the number of points awarded from each card claimed by the player
			List<AdditionalProjectFeaturesType> awaredItems = new List<AdditionalProjectFeaturesType>( ); // Stores the items associated with a card
			int[] iTypeTally = new int[11];		// Stores a tally of the different item types
			Boolean blnContinue = true;			// Continues through a loop if true

			// Add all the items collected from the player into a single list
            for (int i = 0; i < currentPlayer.Inventory.AdditionalProjectFeaturesCards.Count; i++)
            {
				awaredItems.AddRange(currentPlayer.Inventory.AdditionalProjectFeaturesCards[i].listTypeAwared);
			}

			// Tally all the items
			for (int i = 0; i < awaredItems.Count; i++)
			{
				switch (awaredItems[i])
				{
					case AdditionalProjectFeaturesType.medicine:
						iTypeTally[0]++;
						break;
					case AdditionalProjectFeaturesType.art:
						iTypeTally[1]++;
						break;
					case AdditionalProjectFeaturesType.music:
						iTypeTally[2]++;
						break;
					case AdditionalProjectFeaturesType.writing:
						iTypeTally[3]++;
						break;
					case AdditionalProjectFeaturesType.clock:
						iTypeTally[4]++;
						break;
					case AdditionalProjectFeaturesType.pottery:
						iTypeTally[5]++;
						break;
					case AdditionalProjectFeaturesType.transport:
						iTypeTally[6]++;
						break;
					case AdditionalProjectFeaturesType.weaving:
						iTypeTally[7]++;
						break;
					case AdditionalProjectFeaturesType.tool_maker:
						iTypeTally[8]++;
						break;
					case AdditionalProjectFeaturesType.hut_builder:
						iTypeTally[9]++;
						break;
					case AdditionalProjectFeaturesType.shamen:
						iTypeTally[10]++;
						break;
				}
			}
			// Multiply the number of tool makers by the value of the player's tools.
			if (iTypeTally[8] > 0)
            {
				int[] tools = currentPlayer.Inventory.getToolLevelList( ); // Stores the tools the player currently has
				int toolCount = 0;										   // Stores the number of tools the player has

                for (int i = 0; i < tools.Length; i++)
                {
					toolCount += tools[i];
                }

				iPoints += iTypeTally[8] * toolCount;
			}

			// Multiply the number of hut builders by the number of project progress cards.
			if (iTypeTally[9] > 0)
			{
				iPoints += iTypeTally[9] * currentPlayer.Inventory.ProjectProgressCards.Count( );
			}

			// Multiply the number of shamen by the number of people.
			if (iTypeTally[10] > 0)
			{
				iPoints += iTypeTally[10] * currentPlayer.Developers;
			}

            // Multiply the different project feature card items
            while (blnContinue == true)
            {
				blnContinue = false;
				int iMultValue = 0;		// Stores the multiplication value for the group of items 

				for (int i = 0; i < 8; i++)
                {
                    if (iTypeTally[i] > 0)
                    {
                        iMultValue++;
                        iTypeTally[i]--;
						
						// if there is still items left then run through the while loop again.
                        if (iTypeTally[i] > 0)
                        {
							blnContinue = true;
						}
                    }
                }
				iPoints += iMultValue * iMultValue; // max score multiplier is 8 * 8
            }

			return iPoints;
		}
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
				//If there is not a player form at the next turnCounter index, end round and go to next one
				endRound();
			}

		}//end endTurn()
		#endregion

		#region endRound() Method
		/// <summary>
		/// Method for ending round and going to next round
		/// </summary>
		public static void endRound()
		{
			//Acquires tool for player that had developer at tool maker if tool maker has a developer at it
			if (toolMakerFull == true)
			{
				acquireTool();
			}

			if (recruitmentOfficeFull == true)
			{
				//Create new recruitment office object, with the current number of the player's developers
				int teamTotal = playerList[playerAtRecruitmentOffice].TeamCount;
				RecruitmentOffice recruitmentOffice = new RecruitmentOffice(teamTotal);

				//Recruit a new developer
				int newTotalDevs = recruitmentOffice.RecruitNewDev();

				//Add the new dev to player's total team count
				playerList[playerAtRecruitmentOffice].TeamCount = newTotalDevs;
				playerList[playerAtRecruitmentOffice].Developers = newTotalDevs;

				//Resets values for next round
				recruitmentOfficeFull = false;
				playerAtRecruitmentOffice = -1;
			}

			removeClaimedFeatureCards();

			//Resets turn counter and increases the round counter
			turnCounter = 0;
			roundCounter++;

			//Reloads data within main form
			foreach(MainForm form in playerForms)
			{
				form.Reload();
			}

			//Sets player 1's form to visible, 
			playerForms[turnCounter].Visible = true;


		}//end endRound()
		#endregion

		//Switching to different windows/forms or exiting game method regions
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
			filePath += "\\Files\\InstructionSet.txt";

			//Open the file located at filePath (which is InstructionSet.txt
			Process.Start(filePath);

		}//end openInstructions()
		#endregion

		#region quitToMainMenu() Method
		/// <summary>
		/// Method for quitting game to go back to main menu
		/// </summary>
		public static void quitToMainMenu()
		{
			//Closes each mainform before going back to main menu
			foreach (MainForm form in playerForms)
			{
				form.Dispose();
			}

			//Shows main menu
			mainMenu.Show();

		}//end quitToMainMenu()
		#endregion

		#region quitGame() Method
		/// <summary>
		/// Method for quitting game application entirely
		/// </summary>
		public static void quitGame()
		{
			Application.Exit();

		}//end quitGame()
		#endregion

		//Event Handlers
		#region c_OnLoadingTimerEnd() Event
		/// <summary>
		/// Event Handler for handling when loadingTimer ends
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		/// private static void TimerEventProcessor(Object myObject,
		private static void c_OnLoadingTimerEnd(Object source, EventArgs e)
		{
			//Plays great music upon startup after backgroundworker finishes
			SoundController.playMusic();
			mainMenu.showMainMenuScreenControls();
			loadingTimer.Dispose();
		}
		#endregion
	}
}
