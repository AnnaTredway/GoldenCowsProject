///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         Scoring.cs
//	Description:       Scoring class for calculating a player's score
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Monday, October 4, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationAgeProject
{
    /// <summary>
    /// The Scoring cass hosts methods needing for calculating and managing a player's score
    /// </summary>
    public class Scoring
    {
        //Inventory and Resource manager objects
        private Inventory inventory = new Inventory();
        private ResourceManager manager = new ResourceManager();
        
        /// <summary>
        /// Parameterized constructor for scoring
        /// </summary>
        /// <param name="inventory">Inventory object that provides access to a player's resources</param>
        public Scoring(Inventory inventory)
        {
            this.inventory = inventory;
            manager = inventory.ReturnResourceManager();
        }

        /// <summary>
        /// Calculates the player's current score according to the values
        /// determined in the game instructions
        /// </summary>
        /// <returns></returns>
        public string calculateScore()
        {
            //Integers for holding the individual scoring components
            int backLog = 0;
            int low = 0;
            int medium = 0;
            int high = 0;
            int total = 0;

            //Retrieve the number of each resource and multiply it by the appropriate amount of points
            //Increase each scoring component by the newly calculated scores
            backLog += manager.getBacklogAmount() * 1;
            low += manager.getLowPriorityAmount() * 2;
            medium += manager.getMediumPriorityAmount() * 3;
            high += manager.getHighPriorityAmount() * 4;

            total += backLog + low + medium + high;

            //Return a formatted string that accounts for all scoring components
            return $"Score:\n" +
                $"Back Log Tasks: {backLog}\n" +
                $"Low Priority Tasks: {low}\n" +
                $"Medium Priority Tasks: {medium}\n" +
                $"High Priority Tasks: {high}\n" +
                $"Total: {total}";
        }
    }
}
