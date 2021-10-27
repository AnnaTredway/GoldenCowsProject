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
		[DataRow(4, new string[4] { "a", "b","c", "d" }, true)]
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
	}
}
