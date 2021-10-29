///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeTests
//	File Name:         GameControllerTests.cs
//	Description:       GameControllerTests class for unit testing GameController
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Tuesday, October 26, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using Microsoft.VisualStudio.TestTools.UnitTesting;
using InformationAgeProject;

//Directives copied from GameController class
using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationAgeTests
{
	/// <summary>
	/// Test class for GameController class
	/// </summary>
	[TestClass]
	public class GameControllerTests
	{
		[TestMethod]
		//Arrange
		[DataRow(4, new string[4] { "a", "b", "c", "d" }, true)]
		public void startGameTest(int playerCount, string[] teamNames, bool expected)
		{
			//Act
			bool actual = GameController.startGame(playerCount, teamNames);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		//Arrange
		[DataRow(null, new int[4] { 1, 1, 1, 1 }, false)]
		//[DataRow(new Player(), new int[4] { 0, 0, 0, 0 }, false)]
		public void calcTasksTest(Player player, int[] devCounts, bool expected)
		{
			//Act
			bool actual = GameController.calcTasks(player, devCounts);

			//Assert
			Assert.AreEqual(expected, actual);
		}

        [TestMethod]
        public void endTurnTest()
        {
            //Instantiate players, their main forms, team names, and a counter to keep track of player turns
            MainForm[] playerForms = new MainForm[4];
            int turnCounter = 0;
            Player[] playerList = new Player[4];
            playerForms = new MainForm[4];
            string[] teamNames = { "a", "b", "c", "d" };

            //Creates new master card decks
            ProjectProgressDeck ProjProgDeck = new ProjectProgressDeck();
            AdditionalProjectFeaturesDeck ProjFeatDeck = new AdditionalProjectFeaturesDeck();

            //Activates players, sets their team names, and instantiates their MainForms
            for (int i = 0; i < 4; i++)
            {
                playerList[i] = new Player();
                playerList[i].TeamName = teamNames[i];
                playerForms[i] = new MainForm(playerList[i], ProjProgDeck, ProjFeatDeck);
            }

            //Current form is set to invisible so it is not in the way of the next player
            playerForms[turnCounter].Visible = false;

            //Turn counter goes up by one to move on to next player
            turnCounter++;

            //Act
            bool actual;

            try
            {
                //If there is a player form at the turnCounter index, go to that form
                playerForms[turnCounter].Visible = true;
                actual = playerForms[turnCounter].Visible;
            }
            catch
            {
                //If there is not a player form at the turnCounter index, go back to first player form
                turnCounter = 0;
                playerForms[turnCounter].Visible = true;
                actual = playerForms[turnCounter].Visible;
            }

            //Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        [DataRow(null)]
        public void calcToolLevelsFromListTest(ListBox listBox)
        {
            //Add 3 level 2 tools to listBox
            listBox = new ListBox();
            listBox.Items.Add(2);
            listBox.Items.Add(2);
            listBox.Items.Add(2);

            int expected = 6;

            int actual = GameController.calcToolLevelsFromList(listBox);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void openInstructionsTest()
        {
            bool actual = true;

            /**Get the current directory
            string filePath = Directory.GetCurrentDirectory();

            //Move up two parent directories
            filePath = Directory.GetParent(filePath).FullName;
            filePath = Directory.GetParent(filePath).FullName;

            //Append the location of InstructionSet.txt to filePath
            filePath += "/Files/InstructionSet.txt";

            //Open the file located at filePath (which is InstructionSet.txt
            Process.Start(filePath);**/

            GameController.openInstructions();

            //Get the currently running process
            Process process = Process.GetCurrentProcess();

            if (process == null)
            {
                actual = false;
            }

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void openAboutBoxTest()
        {
            bool actual = true;

            //Opens new AboutBox window for About information
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();

            if (aboutBox.Visible != true)
            {
                actual = false;
            }

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void quitGameTest()
        {
            bool actual = true;

            //Opens new QuitForm window for prompting user if they want to exit application
            QuitForm quitForm = new QuitForm();
            quitForm.Show();

            if (quitForm.Visible != true)
            {
                actual = false;
            }

            Assert.AreEqual(true, actual);
        }
    }
}
