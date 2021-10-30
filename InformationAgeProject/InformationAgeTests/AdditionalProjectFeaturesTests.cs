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

namespace InformationAgeTests
{
    /// <summary>
    /// Test class for AdditionalProjectFeatures
    /// </summary>
    [TestClass]
    public class AdditionalProjectFeaturesTests
    {
        private static Inventory TestInventory;
        private static AdditionalProjectFeaturesDeck ProjFeatDeck = new AdditionalProjectFeaturesDeck( );

        [TestMethod]
        //Arrange
        [DataRow(4, null)]
        /// <param name="iCardCost">Card cost to be tested</param>
        /// <param name="expected">Success string value expected of test</param>
        //Should return null because there are not enough resources to claim this card.
        public void ClaimCardTest_NotEnoughResources(int iCardCost, string expected)
        {
            TestInventory = new Inventory( );
            TestInventory.addToBacklog(2);

            //Act
            AdditionalProjectFeaturesType[] actual = ProjFeatDeck.Deck[0].claimCard(iCardCost, TestInventory);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Arrange
        [DataRow(4, true)]
        /// <param name="iCardCost">Card cost to be tested</param>
        /// <param name="expected">Success bool value expected of test</param>
        //Should expect true because there will be either 1 or 2 items awarded to the player
        public void ClaimCardTest_WithEnoughResources(int iCardCost, bool expected)
        {
            bool actual;

            TestInventory = new Inventory( );
            TestInventory.addToBacklog(1);
            TestInventory.addToLowPriority(1);
            TestInventory.addToMediumPriority(1);
            TestInventory.addToHighPriority(1);

            //Act
            AdditionalProjectFeaturesType[] result = ProjFeatDeck.Deck[0].claimCard(iCardCost, TestInventory);

            if (result.Length > 0)
                actual = true;
            else
                actual = false;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
