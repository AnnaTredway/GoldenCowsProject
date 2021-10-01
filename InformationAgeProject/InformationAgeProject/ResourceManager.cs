///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         ResourceManager.cs
//	Description:       Manages the resources used in Information Age
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Monday, September 20, 2021
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
    /// Manages the different resources you can obtain through the game.
    /// </summary>
    class ResourceManager
    {
        // Maybe it would be better to make this "Inventory Manager" and handle resources, tools, cards, and points.
        private Resource[] gameResources = new Resource[4];

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceManager"/> class.
        /// </summary>
        public ResourceManager( )
        {
            this.gameResources[0] = new Resource("Backlog", ResourceType.BACKLOG);
            this.gameResources[1] = new Resource("Low Priority", ResourceType.LOWPRIORITY);
            this.gameResources[2] = new Resource("Medium Priority", ResourceType.MEDPRIORITY);
            this.gameResources[3] = new Resource("High Priority", ResourceType.HIGHPRIORITY);
        }

        #region Setters
        /// <summary>
        /// Sets the amount a player has of this resource.
        /// </summary>
        /// <param name="amountInBacklog">The amount of the resource.</param>
        public void setBacklog(int amountInBacklog)
        {
            this.gameResources[0].resourceAmount = amountInBacklog;
        }

        /// <summary>
        /// Sets the amount a player has of this resource.
        /// </summary>
        /// <param name="amountInPriority">The amount of the resource.</param>
        public void setLowPriority(int amountInPriority)
        {
            this.gameResources[1].resourceAmount = amountInPriority;
        }

        /// <summary>
        /// Sets the amount a player has of this resource.
        /// </summary>
        /// <param name="amountInPriority">The amount of the resource.</param>
        public void setMediumPriority(int amountInPriority)
        {
            this.gameResources[2].resourceAmount = amountInPriority;
        }

        /// <summary>
        /// Sets the amount a player has of this resource.
        /// </summary>
        /// <param name="amountInPriority">The amount of the resource.</param>
        public void setHighPriority(int amountInPriority)
        {
            this.gameResources[3].resourceAmount = amountInPriority;
        }
        #endregion

        #region Getters
        /// <summary>
        /// Gets the resource name for the input resource
        /// </summary>
        /// <param name="resourceIndex">Index of the resource in array to get the name of</param>
        /// <returns>The amount in Backlog</returns>
        public string getResourceName(int resourceIndex)
        {
            return this.gameResources[resourceIndex].resourceName;
        }

        /// <summary>
        /// Gets the resource amount for the current resource.
        /// </summary>
        /// <returns>The amount in Backlog</returns>
        public int getBacklogAmount( )
        {
            return this.gameResources[0].resourceAmount;
        }

        /// <summary>
        /// Gets the resource amount for the current resource.
        /// </summary>
        /// <returns>The amount in low priority</returns>
        public int getLowPriorityAmount( )
        {
            return this.gameResources[1].resourceAmount;
        }

        /// <summary>
        /// Gets the resource amount for the current resource.
        /// </summary>
        /// <returns>The amount in medium priority</returns>
        public int getMediumPriorityAmount( )
        {
            return this.gameResources[2].resourceAmount;
        }

        /// <summary>
        /// Gets the resource amount for the current resource.
        /// </summary>
        /// <returns>The amount in high priority</returns>
        public int getHighPriorityAmount( )
        {
            return this.gameResources[3].resourceAmount;
        }
        #endregion

    }
}
