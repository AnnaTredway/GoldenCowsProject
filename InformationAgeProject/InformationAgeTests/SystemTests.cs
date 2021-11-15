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
            int turnCounter = 0;
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

            //Send 2 devs belonging to player 1, and recall them
            obj1.Invoke("btnSendDevs_Click");
            obj1.Invoke("btnRecallDevs_Click");

            //Send 2 devs belonging to player 1, and leaving them until round's end
            obj1.Invoke("btnSendDevs_Click");
            obj1.Invoke("btnEndTurn_Click");

            //End turn of player 2
            obj2.Invoke("btnEndTurn_Click");

            Player player = new Player();
            player.TeamCount = (int)obj1.GetFieldOrProperty("TeamCount");

            Assert.AreEqual(6, player.TeamCount);
        }
    }
}
