///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         ProjectProgressDeck.cs
//	Description:       Class for handling a deck of project progress cards
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
    [Serializable]
    public class ProjectProgressDeck
    {
        public List<ProjectProgress> Deck = new List<ProjectProgress>(); // Creates a deck of 7 Project Progress cards

        /// <summary>
        /// Creates a new deck of cards and shuffles them.
        /// </summary>
        public ProjectProgressDeck()
        {
            for (int i = 0; i < 7; i++)
            {
                Deck.Add(new ProjectProgress());
            }// end for (int i = 0; i < Deck.Length; i++)

            Shuffle();
        }// end ProjectProgressDeck( )

        /// <summary>
        /// Shuffles a deck of project progress cards
        /// </summary>
        public void Shuffle()
        {
            Random rNum = new Random(); // Used to shuffle the deck
            int iRandom;                 // Stores a number generated from rNum
            ProjectProgress swap;        // Temporary stores a card so it can be swapped
            for (int i = 0; i < Deck.Count; i++)
            {
                iRandom = rNum.Next(Deck.Count);
                swap = Deck[i];
                Deck[i] = Deck[iRandom];
                Deck[iRandom] = swap;
            }// end for (int i = 0; i < Deck.Length; i++)
        }// end Shuffle( )
    }// end class ProjectProgressDeck
}// end namespace InformationAgeProject
