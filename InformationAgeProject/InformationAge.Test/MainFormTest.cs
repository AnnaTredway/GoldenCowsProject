///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         MainFormTest.cs
//	Description:       Main Form window gui for Information Age Project
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Monday, October 25, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using InformationAgeProject;
using NUnit.Framework;
using System.Windows.Forms;
using NUnit.Extensions.Forms;

namespace InformationAge.Test
{
	/// <summary>
	/// Test class for the MainForm
	/// </summary>
    [TestFixture]
    public class MainFormTest : Form
    {
		// Instantiate the aspects needed to create the MainForm
		static Player player = new Player();
		static ProjectProgressDeck progressDeck = new ProjectProgressDeck();
		static AdditionalProjectFeaturesDeck additionalDeck = new AdditionalProjectFeaturesDeck();
		static MainForm mainForm = new MainForm(player, progressDeck, additionalDeck);

		/// <summary>
		/// Test case for when the user story text boxes contain "0" when the DoTasks
		/// button is pressed
		/// </summary>
		[Test]
        public void DoTasksWhenNull()
        {
            mainForm.Show();

            ButtonTester btnDoTasksTest = new ButtonTester("btnDoTasks");
            btnDoTasksTest.Click();

			string text = "0";

			TextBoxTester txtBackLog = new TextBoxTester("txtBackLog");
			TextBoxTester txtLow = new TextBoxTester("txtLow");
			TextBoxTester txtMed = new TextBoxTester("txtMed");
			TextBoxTester txtHigh = new TextBoxTester("txtHigh");

			Assert.AreEqual(text, txtBackLog);
			Assert.AreEqual(text, txtLow);
			Assert.AreEqual(text, txtMed);
			Assert.AreEqual(text, txtHigh);
		}
	}
}
