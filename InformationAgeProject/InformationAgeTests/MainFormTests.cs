///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeTests
//	File Name:         MainFormTests.cs
//	Description:       MainFormTests class for unit testing MainForm
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

//Directives copied from MainForm class
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

namespace InformationAgeTests
{
	/// <summary>
	/// Test class for MainForm class
	/// </summary>
	[TestClass]
	public class MainFormTests
	{
		// Instantiate the aspects needed to create the MainForm
		static Player player = new Player();
		static ProjectProgressDeck progressDeck = new ProjectProgressDeck();
		static AdditionalProjectFeaturesDeck additionalDeck = new AdditionalProjectFeaturesDeck();
		static MainForm mainForm = new MainForm(player, progressDeck, additionalDeck);

		/*
		/// <summary>
		/// Test case for when the user story text boxes contain "0" when the DoTasks
		/// button is pressed
		/// </summary>
		[TestMethod]
		public void DoTasksWhenNull()
		{
			mainForm.Show();

			Button btnDoTasksTest = new Button("btnDoTasks");
			btnDoTasksTest.Click();

			string text = "0";

			TextBox txtBackLog = new TextBox("txtBackLog");
			TextBox txtLow = new TextBox("txtLow");
			TextBox txtMed = new TextBox("txtMed");
			TextBox txtHigh = new TextBox("txtHigh");

			Assert.AreEqual(text, txtBackLog);
			Assert.AreEqual(text, txtLow);
			Assert.AreEqual(text, txtMed);
			Assert.AreEqual(text, txtHigh);
		}
		*/
	}
}
