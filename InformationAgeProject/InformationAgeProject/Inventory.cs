///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         Inventory.cs
//	Description:       Inventory class for managing resources, cards, buildings, and tools
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
		//Manager classes to be used in Inventory
		private ResourceManager resourceManager;
		private ToolManager toolManager;

		/// <summary>
		/// Constructor for Inventory 
		/// </summary>
		public Inventory( )
		{

			resourceManager = new ResourceManager();
			toolManager = new ToolManager();
			ProjectProgressCards = new List<ProjectProgress>();
		}



		/// <summary>
		/// Property for accessing and altering the
		/// player's project progress cards
		/// </summary>
		public List<ProjectProgress> ProjectProgressCards { get; set; }

		#region Add to resource count methods
		/// <summary>
		/// Adds an amount to the Backlog
		/// </summary>
		/// <param name="amountToAdd">the amount to add</param>
		public void addToBacklog(int amountToAdd)
		{
			resourceManager.setBacklog(resourceManager.getBacklogAmount( ) + amountToAdd);
		}

		/// <summary>
		/// Adds an amount to the low priority
		/// </summary>
		/// <param name="amountToAdd">the amount to add</param>
		public void addToLowPriority(int amountToAdd)
		{
			resourceManager.setLowPriority(resourceManager.getLowPriorityAmount( ) + amountToAdd);
		}

		/// <summary>
		/// Adds an amount to the medium priority
		/// </summary>
		/// <param name="amountToAdd">the amount to add</param>
		public void addToMediumPriority(int amountToAdd)
		{
			resourceManager.setMediumPriority(resourceManager.getMediumPriorityAmount( ) + amountToAdd);
		}

		/// <summary>
		/// Adds an amount to the high priority
		/// </summary>
		/// <param name="amountToAdd">the amount to add</param>
		public void addToHighPriority(int amountToAdd)
		{
			resourceManager.setHighPriority(resourceManager.getHighPriorityAmount( ) + amountToAdd);
		}
		#endregion

		#region Remove from resource count methods
		/// <summary>
		/// Removes an amount to the backlog
		/// </summary>
		/// <param name="amountToRemove">the amount to remove</param>
		public void removeFromBacklog(int amountToRemove)
		{
			resourceManager.setBacklog(resourceManager.getBacklogAmount( ) - amountToRemove);
		}

		/// <summary>
		/// Removes an amount to the low priority
		/// </summary>
		/// <param name="amountToRemove">the amount to remove</param>
		public void removeFromLowPriority(int amountToRemove)
		{
			resourceManager.setLowPriority(resourceManager.getLowPriorityAmount( ) - amountToRemove);
		}

		/// <summary>
		/// Removes an amount to the medium priority
		/// </summary>
		/// <param name="amountToRemove">the amount to remove</param>
		public void removeFromMediumPriority(int amountToRemove)
		{
			resourceManager.setMediumPriority(resourceManager.getMediumPriorityAmount( ) - amountToRemove);
		}

		/// <summary>
		/// Removes an amount to the high priority
		/// </summary>
		/// <param name="amountToRemove">the amount to remove</param>
		public void removeFromHighPriority(int amountToRemove)
		{
			resourceManager.setHighPriority(resourceManager.getHighPriorityAmount( ) - amountToRemove);
		}
		#endregion

		/// <summary>
		/// Prints the current players resources.
		/// </summary>
		/// <returns>Returns a string to printout the current players resource count.</returns>
		public string printResources()
		{
			string strResult = "---------------------------------\n" +
							  resourceManager.getResourceName(0) + ": " + resourceManager.getBacklogAmount( ) + "\n" +
							  resourceManager.getResourceName(1) + ": " + resourceManager.getLowPriorityAmount( ) + "\n" +
							  resourceManager.getResourceName(2) + ": " + resourceManager.getMediumPriorityAmount( ) + "\n" +
							  resourceManager.getResourceName(3) + ": " + resourceManager.getHighPriorityAmount( ) + "\n" +
							  "ProjectProgressCards" + ": " + ProjectProgressCards.Count + "\n" +
							  "---------------------------------\n";
			return strResult;
		}

		/// <summary>
		/// Returns the current state of the resourceManager for use in other classes.
		/// </summary>
		/// <returns></returns>
		public ResourceManager ReturnResourceManager()
		{
			return resourceManager;
		}

		/// <summary>
		/// Returns the current state of the toolManager for use in other classes.
		/// </summary>
		/// <returns></returns>
		public ToolManager ReturnToolManager()
		{
			return toolManager;
		}
	}
}
