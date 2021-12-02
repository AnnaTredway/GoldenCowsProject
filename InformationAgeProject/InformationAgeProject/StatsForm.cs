///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         StatsForm.cs
//	Description:       Displays the stats of all the players in the game.
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Friday, November 12, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows.Forms;

namespace InformationAgeProject
{
    /// <summary>
    /// Creates a form to
    /// </summary>
    public partial class StatsForm : Form
    {
        /// <summary>
        /// Initializes a new StatesForm
        /// </summary>
        public StatsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Populates all the player fields with the respected players stats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatsForm_Load(object sender, EventArgs e)
        {
            Scoring score;
            int[] toolLevelList;
            if (GameController.playerList.Length == 4)
            {
                Player4GroupBox.Text = "Player 4: " + GameController.playerList[3].TeamName;
                P4InventoryBox.Text = GameController.playerList[3].Inventory.printResources();
                score = new Scoring(GameController.playerList[3].Inventory);
                P4ScoreBox.Text = score.calculateScore();
                P4ProjectProgressCardsGroupBox.Text = "Project Progress Cards: " + GameController.ProjProgDeck[3].Deck.Count + " cards remain";
                try
                {
                    P4ProjectProgressCard1.Text = GameController.ProjProgDeck[3].Deck[0].displayCard();
                }
                catch (Exception)
                {
                    P4ProjectProgressCard1.Text = "This player has purchased all available cards";
                }
                P4TxtDevelopers.Text = GameController.playerList[3].Developers.ToString();

                toolLevelList = GameController.playerList[3].Inventory.getToolLevelList();
                P4ToolSlot1.Text = toolLevelList[0].ToString();
                P4ToolSlot2.Text = toolLevelList[1].ToString();
                P4ToolSlot3.Text = toolLevelList[2].ToString();
            }
            else
            {
                Player4GroupBox.Visible = false;
            }

            if (GameController.playerList.Length >= 3)
            {
                Player3GroupBox.Text = "Player 3: " + GameController.playerList[2].TeamName;
                P3InventoryBox.Text = GameController.playerList[2].Inventory.printResources();
                score = new Scoring(GameController.playerList[2].Inventory);
                P3ScoreBox.Text = score.calculateScore();
                P3ProjectProgressCardsGroupBox.Text = "Project Progress Cards: " + GameController.ProjProgDeck[2].Deck.Count + " cards remain";
                try
                {
                    P3ProjectProgressCard1.Text = GameController.ProjProgDeck[2].Deck[0].displayCard();
                }
                catch (Exception)
                {
                    P3ProjectProgressCard1.Text = "This player has purchased all available cards";
                }
                P3TxtDevelopers.Text = GameController.playerList[2].Developers.ToString();

                toolLevelList = GameController.playerList[2].Inventory.getToolLevelList();
                P3ToolSlot1.Text = toolLevelList[0].ToString();
                P3ToolSlot2.Text = toolLevelList[1].ToString();
                P3ToolSlot3.Text = toolLevelList[2].ToString();
            }
            else
            {
                Player3GroupBox.Visible = false;
            }

            // Adds all the elements to the second player
            Player2GroupBox.Text = "Player 2: " + GameController.playerList[1].TeamName;
            P2InventoryBox.Text = GameController.playerList[1].Inventory.printResources();
            score = new Scoring(GameController.playerList[1].Inventory);
            P2ScoreBox.Text = score.calculateScore();
            P2ProjectProgressCardsGroupBox.Text = "Project Progress Cards: " + GameController.ProjProgDeck[1].Deck.Count + " cards remain";
            try
            {
                P2ProjectProgressCard1.Text = GameController.ProjProgDeck[1].Deck[0].displayCard();
            }
            catch (Exception)
            {
                P2ProjectProgressCard1.Text = "This player has purchased all available cards";
            }
            P2TxtDevelopers.Text = GameController.playerList[1].Developers.ToString();

            toolLevelList = GameController.playerList[1].Inventory.getToolLevelList();
            P2ToolSlot1.Text = toolLevelList[0].ToString();
            P2ToolSlot2.Text = toolLevelList[1].ToString();
            P2ToolSlot3.Text = toolLevelList[2].ToString();


            // Adds all the elements to the first player
            Player1GroupBox.Text = "Player 1: " + GameController.playerList[0].TeamName;
            P1InventoryBox.Text = GameController.playerList[0].Inventory.printResources();
            score = new Scoring(GameController.playerList[0].Inventory);
            P1ScoreBox.Text = score.calculateScore();
            P1ProjectProgressCardsGroupBox.Text = "Project Progress Cards: " + GameController.ProjProgDeck[0].Deck.Count + " cards remain";
            try
            {
                P1ProjectProgressCard1.Text = GameController.ProjProgDeck[0].Deck[0].displayCard();
            }
            catch (Exception)
            {
                P1ProjectProgressCard1.Text = "This player has purchased all available cards";
            }
            P1TxtDevelopers.Text = GameController.playerList[0].Developers.ToString();

            toolLevelList = GameController.playerList[0].Inventory.getToolLevelList();
            P1ToolSlot1.Text = toolLevelList[0].ToString();
            P1ToolSlot2.Text = toolLevelList[1].ToString();
            P1ToolSlot3.Text = toolLevelList[2].ToString();

        }

        /// <summary>
        /// Refreshes the fields with any new data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SoundController.playButtonClick();
            StatsForm_Load(sender, e);
        }
    }
}
