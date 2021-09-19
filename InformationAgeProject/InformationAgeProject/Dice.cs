///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         Dice.cs
//	Description:       Dice class for random number generation when used
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Treadway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Sunday, September 19, 2021
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
	class Dice
	{
		private readonly Random RNG;    //Random Number Generator for use in RollDice() method

		/// <summary>
		/// Constructor for Dice 
		/// </summary>
		public Dice()
		{
			this.RNG = new Random();

		}//end Dice() Constructor

		#region RollDice() & StaticRollDice() Methods
		/// <summary>
		/// Method for returning random value from custom number of dice with custom number of sides
		/// </summary>
		/// <param name="numDice">Total number of dice to be rolled</param>
		/// <param name="numSides">Total number of sides per die</param>
		/// <param name="startsAt">Number of sides die starts at(RNG result wont go below this number for each die)</param>
		/// <returns>Random value from custom number of dice with custom number of sides</returns>
		public int RollDice(int numDice, int numSides, int startsAt)
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
		}//end RollDice()

		/// <summary>
		/// Static Method for returning random value from custom number of dice with custom number of sides
		/// </summary>
		/// <param name="numDice">Total number of dice to be rolled</param>
		/// <param name="numSides">Total number of sides per die</param>
		/// <param name="startsAt">Number of sides die starts at(RNG result wont go below this number for each die)</param>
		/// <returns>Random value from custom number of dice with custom number of sides</returns>
		public static int StaticRollDice(int numDice, int numSides, int startsAt)
		{
			Random RNG = new Random();	//RNG for die/dice roll
			int rollVal = 0;            //Stored rolled value initialized to 0

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
		}//end StaticRollDice()
		#endregion

	}//end Dice class

}//end InformationAgeProject namespace
