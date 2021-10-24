///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         Player.cs
//	Description:       Player class for managing a player's team
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Wednesday, October 13, 2021
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
    /// Player class hosts methods and properties for managing a single player's team
    /// </summary>
    public class Player
    {
        // Private Inventory objects for use by Inventory property of this class
        private Inventory _inventory;
        
        // Private developers int for use by Developers property of this class 
        private int _developers;

        /// <summary>
        /// Player default constructor for setting the object's default values
        /// upon instantiation
        /// </summary>
        public Player()
        {
            // Instantiate a new Inventory for the player
            _inventory = new Inventory();

            // Set the initial amount of developers for the player to 5
            _developers = 5;
        }

        /// <summary>
        /// Developers property for maintaining the number of developers on
        /// a player's team. A player's team begins with 5 developers,
        /// and may not exceed a total of 20.
        /// </summary>
        public int Developers
        {
           // Return the current value for Developers
            get { return _developers; }

            // Set the value for Developers
            set
            {
                // If the current value of Developers is less than 20
                if (_developers < 20)
                {
                    // Increase the total of developers by one
                    _developers = _developers + 1;
                }
                // Else the value of Developers has already reached twenty
                else
                {
                    // Maintain the value of 20 for Developers
                    _developers = 20;
                }
            }
        }

        /// <summary>
        /// Inventory property for accessing a player's inventory
        /// </summary>
        public Inventory Inventory
        {
            // Return the current state of the inventory
            get { return _inventory;  }

            // Set the value for Inventory
            set { _inventory = value; }
        }

        /// <summary>
        /// TeamName property for accessing and setting a player's team name
        /// </summary>
        public string TeamName { get; set; }
    }
}
