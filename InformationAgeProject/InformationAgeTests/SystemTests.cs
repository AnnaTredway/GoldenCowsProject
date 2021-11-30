///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeTests
//	File Name:         SystemTests.cs
//	Description:       Hosts the SystemTests class for unit testing Information Age's primary functionality (on an Epic level)
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Saturday, November 13, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using InformationAgeProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationAgeTests
{
    [TestClass]
    public class SystemTests
    {
        [TestMethod]
        public void testRecruitmentOffice()
        {
            //Instantiate players, their main forms, team names, and a counter to keep track of player turns
            MainForm[] playerForms = new MainForm[2];
            Player[] playerList = new Player[2];
            playerForms = new MainForm[2];
            string[] teamNames = { "a", "b" };

            //Activates players, sets their team names, and instantiates their MainForms
            for (int i = 0; i < 2; i++)
            {
                playerList[i] = new Player();
                playerList[i].TeamName = teamNames[i];
                playerForms[i] = new MainForm(playerList[i]);
            }

            //Isolate the player forms into a private objects
            MainForm playerForm1 = playerForms[0];
            MainForm playerForm2 = playerForms[1];
            PrivateObject obj1 = new PrivateObject(playerForm1);
            PrivateObject obj2 = new PrivateObject(playerForm2);

            //Pull the player instances from the private objects
            Player player1 = new Player();
            player1 = (Player)obj1.GetField("player");
            Player player2 = new Player();
            player2 = (Player)obj2.GetField("player");

            //Boolean value representing whether the recruitment office is occupied
            bool recruitmentOfficeFull = false;

            //If the first player has at least two free developers,
            //and the recruitment office is vacant
            if (player1.Developers >= 2 & recruitmentOfficeFull == false)
            {
                player1.Developers = player1.Developers - 2;
                recruitmentOfficeFull = true;
            }
            //Else, test that player1's free dev count remains at 5
            else
            {
                Assert.AreEqual(5, player1.Developers);
            }

            //At the end of round, check for recruitment office vacancy
            if (recruitmentOfficeFull == true)
            {
                //Create new recruitment office object, with the current number of the player's developers
                int teamTotal = player1.TeamCount;
                RecruitmentOffice recruitmentOffice = new RecruitmentOffice(teamTotal);
                //Recruit a new developer
                int newTotalDevs = recruitmentOffice.RecruitNewDev();
                //Add the new dev to player's total team count, and available dev count
                player1.TeamCount = newTotalDevs;
                player1.Developers = newTotalDevs;

                recruitmentOfficeFull = false;

                //Test that one developer was successfully added to player's total team count
                Assert.AreEqual(6, player1.TeamCount);
            }
            //Else, test that player's free dev count remains at five.
            else
            {
                Assert.AreEqual(5, player1.TeamCount);
            }
        }

        [TestMethod]
        //Arrange
        [DataRow(true, new int[4] { 1, 1, 1, 1 }, true)]
        [DataRow(false, new int[4] { 1, 1, 1, 1 }, false)]
        [DataRow(true, new int[4] { 0, 0, 0, 0 }, false)]
        /// <param name="testPlayer">Whether player object to be tested is new Player(true) or is null(false)</param>
        /// <param name="devCounts">Number of devcounts for each task/resource to be tested</param>
        /// <param name="expected">Success expected of test</param>
        public void calcTasksTest(bool testPlayer, int[] devCounts, bool expected)
        {
            Player player;

            //Makes player a new Player or null based on if testPlayer is true or false
            if (testPlayer == true)
            {
                player = new Player();
            }
            else
            {
                player = null;

            }

            //Act
            bool actual = GameController.calcTasks(player, devCounts);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Arrange
        [DataRow(true, 6)]
        [DataRow(false, -1)]
        /// <param name="testListBox">Whether listBox object to be tested is new ListBox(true) or is null(false)</param>
        /// <param name="expected">Expected int value to be returned by calcToolLevelsFromList()</param>
        public void calcToolLevelsFromListTest(bool testListBox, int expected)
        {
            ListBox listBox;

            //Makes listBox a new ListBox or null based on if testListBox is true or false
            if (testListBox == true)
            {
                //Add 3 level 2 tools to listBox
                listBox = new ListBox();
                listBox.Items.Add(2);
                listBox.Items.Add(2);
                listBox.Items.Add(2);
            }
            else
            {
                listBox = null;
            }

            //Act
            int actual = GameController.calcToolLevelsFromList(listBox);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
