///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         Inventory.cs
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

namespace InformationAgeProject
{
	/// <summary>
	/// Inventory class for interacting with ResourceManger
	/// </summary>
	public class Inventory
	{
		//ResourceManager classes to be used in Inventory
		private ResourceManager manager;

		/// <summary>
		/// Constructor for Inventory 
		/// </summary>
		public Inventory( )
		{
			manager = new ResourceManager( );
		}

		#region Add to resource count methods
		/// <summary>
		/// Adds an amount to the Backlog
		/// </summary>
		/// <param name="amountToAdd">the amount to add</param>
		public void addToBacklog(int amountToAdd)
		{
			manager.setBacklog(manager.getBacklogAmount( ) + amountToAdd);
		}

		/// <summary>
		/// Adds an amount to the low priority
		/// </summary>
		/// <param name="amountToAdd">the amount to add</param>
		public void addToLowPriority(int amountToAdd)
		{
			manager.setLowPriority(manager.getLowPriorityAmount( ) + amountToAdd);
		}

		/// <summary>
		/// Adds an amount to the medium priority
		/// </summary>
		/// <param name="amountToAdd">the amount to add</param>
		public void addToMediumPriority(int amountToAdd)
		{
			manager.setMediumPriority(manager.getMediumPriorityAmount( ) + amountToAdd);
		}

		/// <summary>
		/// Adds an amount to the high priority
		/// </summary>
		/// <param name="amountToAdd">the amount to add</param>
		public void addToHighPriority(int amountToAdd)
		{
			manager.setHighPriority(manager.getHighPriorityAmount( ) + amountToAdd);
		}
		#endregion

		#region Remove from resource count methods
		/// <summary>
		/// Removes an amount to the backlog
		/// </summary>
		/// <param name="amountToRemove">the amount to remove</param>
		public void removeFromBacklog(int amountToRemove)
		{
			manager.setBacklog(manager.getBacklogAmount( ) - amountToRemove);
		}

		/// <summary>
		/// Removes an amount to the low priority
		/// </summary>
		/// <param name="amountToRemove">the amount to remove</param>
		public void removeFromLowPriority(int amountToRemove)
		{
			manager.setLowPriority(manager.getLowPriorityAmount( ) - amountToRemove);
		}

		/// <summary>
		/// Removes an amount to the medium priority
		/// </summary>
		/// <param name="amountToRemove">the amount to remove</param>
		public void removeFromMediumPriority(int amountToRemove)
		{
			manager.setMediumPriority(manager.getMediumPriorityAmount( ) - amountToRemove);
		}

		/// <summary>
		/// Removes an amount to the high priority
		/// </summary>
		/// <param name="amountToRemove">the amount to remove</param>
		public void removeFromHighPriority(int amountToRemove)
		{
			manager.setHighPriority(manager.getHighPriorityAmount( ) - amountToRemove);
		}
		#endregion

		/// <summary>
		/// Prints the current players resources.
		/// </summary>
		/// <returns>Returns a string to printout the current players resource count.</returns>
		public string printInventory()
		{
			string strResult = "---------------------------------\n" +
							  manager.getResourceName(0) + ": " + manager.getBacklogAmount( ) + "\n" +
							  manager.getResourceName(1) + ": " + manager.getLowPriorityAmount( ) + "\n" +
							  manager.getResourceName(2) + ": " + manager.getMediumPriorityAmount( ) + "\n" +
							  manager.getResourceName(3) + ": " + manager.getHighPriorityAmount( ) + "\n" +
							  "---------------------------------\n";
			return strResult;
		}

		/// <summary>
		/// Returns the current state of the resource manager for use in other classes.
		/// </summary>
		/// <returns></returns>
		public ResourceManager ReturnManager()
		{
			return manager;
		}
	}
}
