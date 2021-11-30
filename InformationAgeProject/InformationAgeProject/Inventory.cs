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
using System.Windows.Forms;

namespace InformationAgeProject
{
    /// <summary>
    /// Inventory class for interacting with ResourceManger
    /// </summary>
    [Serializable]
    public class Inventory
    {
        //Manager classes to be used in Inventory
        private readonly ResourceManager resourceManager;
        private readonly ToolManager toolManager;

        /// <summary>
        /// Constructor for Inventory 
        /// </summary>
        public Inventory()
        {

            resourceManager = new ResourceManager();
            toolManager = new ToolManager();
            ProjectProgressCards = new List<ProjectProgress>();
            AdditionalProjectFeaturesCards = new List<AdditionalProjectFeatures>();
        }

        /// <summary>
        /// Property for accessing and altering the
        /// player's project progress cards
        /// </summary>
        public List<ProjectProgress> ProjectProgressCards { get; set; }

        /// <summary>
        /// Gets or sets the additional project features cards.
        /// </summary>
        /// <value>
        /// The additional project features cards.
        /// </value>
        public List<AdditionalProjectFeatures> AdditionalProjectFeaturesCards { get; set; }

        #region Add to resource count methods
        /// <summary>
        /// Adds an amount to the Backlog
        /// </summary>
        /// <param name="amountToAdd">the amount to add</param>
        public void addToBacklog(int amountToAdd)
        {
            resourceManager.setBacklog(resourceManager.getBacklogAmount() + amountToAdd);
        }

        /// <summary>
        /// Adds an amount to the low priority
        /// </summary>
        /// <param name="amountToAdd">the amount to add</param>
        public void addToLowPriority(int amountToAdd)
        {
            resourceManager.setLowPriority(resourceManager.getLowPriorityAmount() + amountToAdd);
        }

        /// <summary>
        /// Adds an amount to the medium priority
        /// </summary>
        /// <param name="amountToAdd">the amount to add</param>
        public void addToMediumPriority(int amountToAdd)
        {
            resourceManager.setMediumPriority(resourceManager.getMediumPriorityAmount() + amountToAdd);
        }

        /// <summary>
        /// Adds an amount to the high priority
        /// </summary>
        /// <param name="amountToAdd">the amount to add</param>
        public void addToHighPriority(int amountToAdd)
        {
            resourceManager.setHighPriority(resourceManager.getHighPriorityAmount() + amountToAdd);
        }
        #endregion

        #region Remove from resource count methods
        /// <summary>
        /// Removes an amount to the backlog
        /// </summary>
        /// <param name="amountToRemove">the amount to remove</param>
        public void removeFromBacklog(int amountToRemove)
        {
            resourceManager.setBacklog(resourceManager.getBacklogAmount() - amountToRemove);
        }

        /// <summary>
        /// Removes an amount to the low priority
        /// </summary>
        /// <param name="amountToRemove">the amount to remove</param>
        public void removeFromLowPriority(int amountToRemove)
        {
            resourceManager.setLowPriority(resourceManager.getLowPriorityAmount() - amountToRemove);
        }

        /// <summary>
        /// Removes an amount to the medium priority
        /// </summary>
        /// <param name="amountToRemove">the amount to remove</param>
        public void removeFromMediumPriority(int amountToRemove)
        {
            resourceManager.setMediumPriority(resourceManager.getMediumPriorityAmount() - amountToRemove);
        }

        /// <summary>
        /// Removes an amount to the high priority
        /// </summary>
        /// <param name="amountToRemove">the amount to remove</param>
        public void removeFromHighPriority(int amountToRemove)
        {
            resourceManager.setHighPriority(resourceManager.getHighPriorityAmount() - amountToRemove);
        }
        #endregion

        #region printResources() Method
        /// <summary>
        /// Prints the current players resources.
        /// </summary>
        /// <returns>Returns a string to printout the current players resource count.</returns>
        public string printResources()
        {
            string strResult = $"--------------------------------------------------------\n" +
                               $"{resourceManager.getResourceName(0)}: {resourceManager.getBacklogAmount()}\n" +
                               $"{resourceManager.getResourceName(1)}: {resourceManager.getLowPriorityAmount()}\n" +
                               $"{resourceManager.getResourceName(2)}: {resourceManager.getMediumPriorityAmount()}\n" +
                               $"{resourceManager.getResourceName(3)}: {resourceManager.getHighPriorityAmount()}\n" +
                               $"ProjectProgressCards:  {ProjectProgressCards.Count}\n" +
                               $"ProjectFeatureCards:   {AdditionalProjectFeaturesCards.Count}\n" +
                               $"--------------------------------------------------------";
            return strResult;
        }
        #endregion

        #region Tool Related Methods
        /// <summary>
        /// Method for adding a tool to the current player's inventory
        /// If there are already 3 tools of the current level, one tool is instead upgraded to the next level to a maximum of 4 levels
        /// (No "removeTool()" method because tools can be continuously re-used once for each round by each player)
        /// </summary>
        public void addTool()
        {
            //If third tool slot level is less than 4, then add tool or tool level to inventory
            //(4 is the highest level that a tool can be at and toolSlot3 is the last tool slot that would get a level 4 tool)
            //Else, show error message
            if (toolManager.getThirdSlotLevel() < 4)
            {
                toolManager.increaseToolLevel();
            }
            else
            {
                MessageBox.Show("You cannot acquire anymore tools because all three tools in your inventory are at max level."
                    , "Cannot Acquire More Tools"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method for returning an array of the levels of the tools in the inventory
        /// </summary>
        /// <returns>An array </returns>
        public int[] getToolLevelList()
        {
            int[] levelList = new int[3];

            levelList[0] = toolManager.getFirstSlotLevel();
            levelList[1] = toolManager.getSecondSlotLevel();
            levelList[2] = toolManager.getThirdSlotLevel();

            return levelList;
        }

        /// <summary>
        /// Method for setting the levels of the tools in the inventory
        /// </summary>
        /// <param name="setList">Array of levels to set the tools to</param>
        public void setToolLevelList(int[] setList)
        {
            toolManager.setFirstSlotLevel(setList[0]);
            toolManager.setSecondSlotLevel(setList[1]);
            toolManager.setThirdSlotLevel(setList[2]);
        }
        #endregion

        #region ReturnResourceManager() & ReturnToolManager()
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
        #endregion
    }
}
