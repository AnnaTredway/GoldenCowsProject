///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         GameController.cs
//	Description:       GameController class for methods and controls the windows forms of the program
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
using System.Windows.Forms;

namespace InformationAgeProject
{
	/// <summary>
	/// GameController class for methods and controls the windows forms of the program
	/// </summary>
	class GameController
	{
		#region GameController Constructor
		/// <summary>
		/// Private Constructor for Dice 
		/// </summary>
		private GameController() { }
		#endregion

		/// <summary>
		/// Method for returning total added up levels value from a single list
		/// </summary>
		/// <param name="listBox">List of tools to have levels added up from</param>
		/// <returns>Int of total calculated levels add up from list</returns>
		static public int calcToolLevelsFromList(ListBox listBox)
		{
			int finalToolVal = 0;

			//If there are items in the list, go through each item's level and add them up
			//Else, just return the 0 that finalToolVal was instantiated with
			if (listBox.Items.Count != 0)
			{
				foreach (var item in listBox.Items)
				{
					finalToolVal += int.Parse(item.ToString().Substring(item.ToString().Length - 1));
				}
			}

			return finalToolVal;

		}//end calcToolLevelsFromList()

	}
}
