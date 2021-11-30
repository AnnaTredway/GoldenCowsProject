///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         Dice.cs
//	Description:       Dice class for random number generation
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Sunday, September 19, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

namespace InformationAgeProject
{
    /// <summary>
    /// Dice class for random number generation
    /// </summary>
    public class Dice
    {
        private readonly Random RNG;    //Random Number Generator for use in RollDice() method

        #region Dice Constructor
        /// <summary>
        /// Constructor for Dice 
        /// </summary>
        public Dice()
        {
            this.RNG = new Random();

        }//end Dice() Constructor
        #endregion

        #region rollDice() & rollCustomDice() Methods
        /// <summary>
        /// Method for returning random value from input number of regular 6-sided dice
        /// </summary>
        /// <param name="numDice">Total number of regular dice to be rolled</param>
        /// <returns>Random value from input number of regular 6-sided dice</returns>
        public int rollDice(int numDice)
        {
            int rollVal = 0;    //Stored rolled value initialized to 0

            for (int i = 0; i < numDice; i++)
            {
                rollVal += (RNG.Next(6) + 1);

            }//end for loop

            return rollVal;

        }//end RollDice()

        /// <summary>
        /// Method for returning random value from custom number of dice with custom number of sides
        /// </summary>
        /// <param name="numDice">Total number of custom dice to be rolled</param>
        /// <param name="numSides">Total number of sides per die</param>
        /// <param name="startsAt">Number of sides die starts at(RNG result wont go below this number for each die)</param>
        /// <returns>Random value from custom number of dice with custom number of sides</returns>
        public int rollCustomDice(int numDice, int numSides, int startsAt)
        {
            int rollVal = 0;    //Stored rolled value initialized to 0

            //If an Exception occurs, the Exception message is displayed and a -1 is returned
            try
            {
                for (int i = 0; i < numDice; i++)
                {
                    rollVal += RNG.Next(startsAt, numSides + 1);

                }//end for loop
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                rollVal = -1;
            }

            return rollVal;

        }//end RollCustomDice()
        #endregion

    }//end Dice class

}//end InformationAgeProject namespace
