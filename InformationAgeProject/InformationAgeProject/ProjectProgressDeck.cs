///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         Dice.cs
//	Description:       Inventory class for managing resources, tools, cards, buildings, and tools
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Friday, October 1, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Contains the classes within the Information Age project
/// </summary>
namespace InformationAgeProject
{
    /// <summary>
    /// Creates a deck of Project Progress cards
    /// </summary>
    class ProjectProgressDeck
    {
        ProjectProgress[] Deck = new ProjectProgress[28]; // Creates a deck of 28 Project Progress cards

        /// <summary>
        /// Creates a new deck of cards and shuffles them.
        /// </summary>
        public ProjectProgressDeck( )
        {
            for (int i = 0; i < Deck.Length; i++)
            {
                Deck[i] = new ProjectProgress( );
            }// end for (int i = 0; i < Deck.Length; i++)

            Shuffle( );
        }// end ProjectProgressDeck( )

        /// <summary>
        /// Shuffles a deck of project progress cards
        /// </summary>
        public void Shuffle( )
        {
            Random rNum = new Random( ); // Used to shuffle the deck
            int iRandom;                 // Stores a number generated from rNum
            ProjectProgress swap;        // Temporary stores a card so it can be swapped
            for (int i = 0; i < Deck.Length; i++)
            {
                iRandom = rNum.Next(Deck.Length);
                swap = Deck[i];
                Deck[i] = Deck[iRandom];
                Deck[iRandom] = swap;
            }// end for (int i = 0; i < Deck.Length; i++)
        }// end Shuffle( )
    }// end class ProjectProgressDeck
}// end namespace InformationAgeProject
