///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         AdditionalProjectFeaturesDeck.cs
//	Description:       Class for managing a deck of additional project feature cards
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Friday, October 22, 2021
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
    /// Creates a deck of Additional Project Features
    /// </summary>
    public class AdditionalProjectFeaturesDeck
    {
        private static Random rNum = new Random( );                                           // Used to shuffle the deck
        public List<AdditionalProjectFeatures> Deck = new List<AdditionalProjectFeatures>( ); // Creates a deck of 36 Project Features cards

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalProjectFeaturesDeck"/> class.
        /// </summary>
        public AdditionalProjectFeaturesDeck( )
        {
            for (int i = 0; i < 22; i++)
            {
                Deck.Add(new AdditionalProjectFeatures( ));
            }// end for (int i = 0; i < 22; i++)
            for (int i = 0; i < 14; i++)
            {
                Deck.Add(new AdditionalProjectFeatures(rNum.Next(2) + 1));
            }// end for (int i = 0; i < 14; i++)

            Shuffle( );
        }// end AdditionalProjectFeaturesDeck( )

        /// <summary>
        /// Shuffles a deck of project progress cards
        /// </summary>
        public void Shuffle( )
        {
            int iRandom;                 // Stores a number generated from rNum
            AdditionalProjectFeatures swap;        // Temporary stores a card so it can be swapped
            for (int i = 0; i < Deck.Count; i++)
            {
                iRandom = rNum.Next(Deck.Count);
                swap = Deck[i];
                Deck[i] = Deck[iRandom];
                Deck[iRandom] = swap;
            }// end for (int i = 0; i < Deck.Length; i++)
        }// end Shuffle( )
    }// end class AdditionalProjectFeaturesDeck
}// end namespace InformationAgeProject
