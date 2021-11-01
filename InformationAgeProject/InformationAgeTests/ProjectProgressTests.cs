///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeTests
//	File Name:         AdditionalProjectFeaturesTests.cs
//	Description:       AdditionalProjectFeaturesTests class for unit testing AdditionalProjectFeatures
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Thursday, October 28, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InformationAgeProject;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationAgeTests
{
    [TestClass]
    public class ProjectProgressTests
    {
        private static Inventory TestInventory;
        private static ProjectProgressDeck ProjFeatDeck = new ProjectProgressDeck( );

        [TestMethod]
        //Arrange
        [DataRow(4, 0)]
        /// <param name="iCardCost">Card cost to be tested</param>
        /// <param name="expected">Success int value expected of test</param>
        //Should return null because there are not enough resources to claim this card.
        public void ClaimCardTest_NotEnoughResources(int iCardCost, int expected)
        {
            TestInventory = new Inventory( );

            //Act
            int actual = ProjFeatDeck.Deck[0].claimCard(TestInventory.ReturnResourceManager( ));

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Arrange
        [DataRow(4, true)]
        /// <param name="iCardCost">Card cost to be tested</param>
        /// <param name="expected">Success bool value expected of test</param>
        //Should expect true because the points returned should be greater then 0
        public void ClaimCardTest_WithEnoughResources(int iCardCost, bool expected)
        {
            bool actual;

            TestInventory = new Inventory( );
            //Just fill the inventory for the sake of testing if i can claim a card
            TestInventory.addToBacklog(99);
            TestInventory.addToLowPriority(99);
            TestInventory.addToMediumPriority(99);
            TestInventory.addToHighPriority(99);

            //Act
            int result = ProjFeatDeck.Deck[0].claimCard(TestInventory.ReturnResourceManager( ));

            if (result > 0)
                actual = true;
            else
                actual = false;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
