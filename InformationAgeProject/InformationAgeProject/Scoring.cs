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
    /// The Scoring class hosts methods needing for calculating and managing a player's score
    /// </summary>
    public class Scoring
    {
        //Inventory object
        private readonly Inventory inventory = new Inventory();
        
        /// <summary>
        /// Parameterized constructor for scoring
        /// </summary>
        /// <param name="inventory">Inventory object that provides access to a player's resources</param>
        public Scoring(Inventory inventory)
        {
            this.inventory = inventory;
        }

        /// <summary>
        /// Backlog Property: Total integer point value for player's backlog tasks
        /// </summary>
        public int Backlog { get; set; }

        /// <summary>
        /// Low Property: Total integer point value for player's low tasks
        /// </summary>
        public int Low { get; set; }

        /// <summary>
        /// Medium Property: Total integer point value for player's medium tasks
        /// </summary>
        public int Medium { get; set; }

        /// <summary>
        /// High Property: Total integer point value for player's high tasks
        /// </summary>
        public int High { get; set; }

        /// <summary>
        /// ProjectProgressCards Property: Total integer point value for player's project projess cards
        /// </summary>
        public int ProjectProgressCards { get; set; }

        /// <summary>
        /// AdditionalProjectFeaturesCards Property: Total integer point value for player's
        /// additional project features cards
        /// </summary>
        public int AdditionalProjectFeaturesCards { get; set; }

        /// <summary>
        /// Total Property: Total integer point value for player's total score
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Calculates the player's current score according to the values
        /// determined in the game instructions
        /// </summary>
        /// <returns></returns>
        public string calculateScore()
        {
            //Integers for holding the individual scoring components
            Backlog = 0;
            Low = 0;
            Medium = 0;
            High = 0;
            ProjectProgressCards = 0;
            Total = 0;

            //Retrieve the number of each resource and multiply it by the appropriate amount of points
            //Increase each scoring component by the newly calculated scores
            Backlog += inventory.ReturnResourceManager().getBacklogAmount() * 1;
            Low += inventory.ReturnResourceManager().getLowPriorityAmount() * 2;
            Medium += inventory.ReturnResourceManager().getMediumPriorityAmount() * 3;
            High += inventory.ReturnResourceManager().getHighPriorityAmount() * 4;

            //Iterate through the player's list of project progress cards,
            //and add each card's point value to the total
            if (inventory.ProjectProgressCards.Count != 0)
            {
                foreach (ProjectProgress p in inventory.ProjectProgressCards)
                {
                    ProjectProgressCards += p.iPointValue;
                }
            }
            
            Total += Backlog + Low + Medium + High + ProjectProgressCards;

            //Return a formatted string that accounts for all scoring components
            return $"--------------------------------------------------------\n" +
                   $"Back Log Tasks: {Backlog}\n" +
                   $"Low Priority Tasks: {Low}\n" +
                   $"Medium Priority Tasks: {Medium}\n" +
                   $"High Priority Tasks: {High}\n" +
                   $"Project Progress Cards: {ProjectProgressCards}\n" +
                   $"--------------------------------------------------------\n" +
                   $"Total: {Total}";
        }
    }
}
