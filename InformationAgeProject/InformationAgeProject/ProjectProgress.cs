///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         ProjectProgress.cs
//	Description:       Class for managing Project Progress cards 
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
using System.Windows.Forms;

/// <summary>
/// Contains the classes within the Information Age project
/// </summary>
namespace InformationAgeProject
{
    /// <summary>
    /// Information Age's building cards
    /// </summary>
    public class ProjectProgress
    {
        private static Random rNum = new Random( ); // Used to select a random resource to use
        public int iPointValue;                    // Stores the amount of points this card is worth
        public Boolean blnSold = false;
        private int iDifferentTypesNeeded;          // Stores the number of different resources types needed to purchase this card (used for advance cards)
        private List<Resource> ResourceCost = new List<Resource>( ); // Stores the resources need to purchase this card

        /// <summary>
        /// Creates a basic card with a random with a value of 10-16 and a cost of 3 random resources.
        /// </summary>
        public ProjectProgress( )
        {
            
            this.iPointValue = rNum.Next(6) + 10;
            this.ResourceCost.Add(new Resource(rNum.Next(4)));
            this.ResourceCost.Add(new Resource(rNum.Next(4)));
            this.ResourceCost.Add(new Resource(rNum.Next(4)));
        }// end ProjectProgress( )

        /// <summary>
        /// Creates an advance card that takes X# amount of resources and how many types are needed.
        /// </summary>
        /// <param name="reseouceAmountNeeded">The total amount of recourse needed to purchase this card</param>
        /// <param name="reseouceTypeNeeded">The number of different resource types are needed</param>
        public ProjectProgress(int reseouceAmountNeeded, int reseouceTypeNeeded)
        {
            for (int i = 0; i < reseouceAmountNeeded; i++)
            {
                this.ResourceCost.Add(new Resource());
            }
            this.iDifferentTypesNeeded = reseouceTypeNeeded;
        }// end ProjectProgress(int reseouceAmountNeeded, int reseouceTypeNeeded)

        /// <summary>
        /// Displays the card.
        /// </summary>
        /// <returns>sting that contains the card's info</returns>
        public string displayCard( )
        {
            StringBuilder card = new StringBuilder( );
            card.Append("----------------\r\n");
            card.Append("- Value:       -\r\n");
            card.Append("- " + this.iPointValue.ToString( ).PadLeft(12) + " -\r\n");
            card.Append("- Cost:        -\r\n");
            for (int i = 0; i < ResourceCost.Count; i++)
            {
                card.Append("- " + this.ResourceCost[i].resourceName.PadLeft(12) + " -\r\n");
            }
            card.Append("----------------");
            return card.ToString( );
        }

        /// <summary>
        /// Awards the player with points if they have the necessary resources to purchase the card.
        /// </summary>
        /// <param name="playersResources">The current players resource inventory</param>
        /// <returns>The number of points the player has earned</returns>
        public int claimCard(ResourceManager playersResources)
        {
            bool enoughResources = true;                                // checks if the player has enough has enough resources to purchase the card
            int iPoints = 0;                                            // the points won from the card
            int[] iPlayer = new int[4];                                 // Gets the current resources form the player
            iPlayer[0] = playersResources.getBacklogAmount( );
            iPlayer[1] = playersResources.getLowPriorityAmount( );
            iPlayer[2] = playersResources.getMediumPriorityAmount( );
            iPlayer[3] = playersResources.getHighPriorityAmount( );

            if (this.ResourceCost.Count == 3)
            {
                for (int i = 0; i < this.ResourceCost.Count; i++)
                {
                    if (this.ResourceCost[i].type == ResourceType.BACKLOG && iPlayer[0] > 0)
                    {
                        iPlayer[0]--;
                    }// end if (this.ResourceCost[i].type == ResourceType.BACKLOG && iPlayer[0] > 0)
                    else if (this.ResourceCost[i].type == ResourceType.LOWPRIORITY && iPlayer[1] > 0)
                    {
                        iPlayer[1]--;
                    }// end else if (this.ResourceCost[i].type == ResourceType.LOWPRIORITY && iPlayer[1] > 0)
                    else if (this.ResourceCost[i].type == ResourceType.MEDPRIORITY && iPlayer[2] > 0)
                    {
                        iPlayer[2]--;
                    }// end else if (this.ResourceCost[i].type == ResourceType.MEDPRIORITY && iPlayer[2] > 0)
                    else if (this.ResourceCost[i].type == ResourceType.HIGHPRIORITY && iPlayer[3] > 0)
                    {
                        iPlayer[3]--;
                    }// end else if (this.ResourceCost[i].type == ResourceType.HIGHPRIORITY && iPlayer[3] > 0)
                    else
                    {
                        MessageBox.Show("You do not have enough resources to complete this card!", "Not Enough Resources", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        enoughResources = false;
                        break;
                    }// end else
                }// end for (int i = 0; i < this.ResourceCost.Count; i++)
                if (enoughResources == true)
                {
                    playersResources.setBacklog(iPlayer[0]);
                    playersResources.setLowPriority(iPlayer[1]);
                    playersResources.setMediumPriority(iPlayer[2]);
                    playersResources.setHighPriority(iPlayer[3]);
                    iPoints = this.iPointValue;
                }// end if (enoughResources == true)
            }
            /*else
            {
                // Advanced cards will be developed in the future.
                // For now only basic cards are supported.
                // Set up a way for the player to select which resources they want to use.
                int counter = 0;

                for (int i = 0; i < this.ResourceCost.Count; i++)
                {
                    for (int j = 0; j < this.ResourceCost.Count; j++)
                    {
                        if (this.ResourceCost[i] != this.ResourceCost[j] && i != j)
                        {
                            counter++;
                        }
                    }
                }
                if (counter != iDifferentTypesNeeded)
                {
                    MessageBox.Show("You did not meet the criteria to earn this card!", "Resource Types");
                }
                else
                {
                    // remove selected resources from player inventory and award points based on resource value.
                }
            }*/
            return iPoints;
        }// end claimCard(ResourceManager playersResources)
    }// end  class ProjectProgress
}// end namespace InformationAgeProject
