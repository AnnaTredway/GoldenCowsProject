///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         AdditionalProjectFeatures.cs
//	Description:       Class for managing additional project feature cards
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
    /// Our games version of civilization cards
    /// </summary>
    public class AdditionalProjectFeatures
    {
        private static Random rNum = new Random( );
        private Boolean blnDiceRollRequired = false;
        private List<ResourceType> listResourceAwared = new List<ResourceType>( );
        public List<AdditionalProjectFeaturesType> listTypeAwared = new List<AdditionalProjectFeaturesType>( );
        public Boolean blnSold = false;
        public string strCard;

        /// <summary>
        /// Creates a card that awards the player a random resource and item
        /// </summary>
        public AdditionalProjectFeatures ( )
        {
            this.listResourceAwared.Add((ResourceType)(rNum.Next(4)));
            this.listTypeAwared.Add((AdditionalProjectFeaturesType)rNum.Next(11));
            if (1 == rNum.Next(2))
            {
                this.listResourceAwared.Add(listResourceAwared[0]);
            }

            if ((int)listTypeAwared[0] > 7 && 1 == rNum.Next(2))
            {
                this.listTypeAwared.Add(listTypeAwared[0]);
            }

            generateCard( );
        }

        /// <summary>
        /// Creates a card that awards the player a random resource and item 
        /// </summary>
        /// <param name="choice">Creates a different card based on the choice</param>
        public AdditionalProjectFeatures (int choice)
        {
            if (choice == 1)
            {
                this.blnDiceRollRequired = true;     // requires the user to make a dice roll so they can be awarded x amount for that resource
                this.listResourceAwared.Add((ResourceType)(rNum.Next(4)));
                this.listTypeAwared.Add((AdditionalProjectFeaturesType)rNum.Next(11));

                if ((int)listTypeAwared[0] > 7 && 1 == rNum.Next(2))
                {
                    this.listTypeAwared.Add(listTypeAwared[0]);
                }
            }
            else if (choice == 2)
            {
                this.listTypeAwared.Add((AdditionalProjectFeaturesType)rNum.Next(11));

                if ((int)listTypeAwared[0] > 7 && 1 == rNum.Next(2))
                {
                    this.listTypeAwared.Add(listTypeAwared[0]);
                }
            }

            generateCard( );
        }

        /// <summary>
        /// Claims the card.
        /// </summary>
        /// <param name="cardCost">The card cost.</param>
        /// <param name="playerInventory">The player inventory.</param>
        /// <returns></returns>
        public AdditionalProjectFeaturesType[] claimCard(int cardCost, Inventory playerInventory)
        {
            ResourceManager playerResources = playerInventory.ReturnResourceManager( );
            ResourceType[] listPlayersChoice;
            int[] iPlayer = new int[4];                                 // Gets the current resources form the player
            iPlayer[0] = playerResources.getBacklogAmount( );
            iPlayer[1] = playerResources.getLowPriorityAmount( );
            iPlayer[2] = playerResources.getMediumPriorityAmount( );
            iPlayer[3] = playerResources.getHighPriorityAmount( );
            int iTotalResources = iPlayer[0] + iPlayer[1] + iPlayer[2] + iPlayer[3];
            if (iTotalResources >= cardCost)
            {
                //Prompts the user to select what resources they want to spend 
                AdditionalProjectFeaturesSelector form = new AdditionalProjectFeaturesSelector(cardCost, iPlayer);
                form.ShowDialog( );
                listPlayersChoice = form.getSelectedResources();
                form.Dispose( );

                for (int i = 0; i < listPlayersChoice.Length; i++)
                {
                    if (listPlayersChoice[i] == ResourceType.BACKLOG)
                    {
                        playerInventory.removeFromBacklog(1);
                    }

                    if (listPlayersChoice[i] == ResourceType.LOWPRIORITY)
                    {
                        playerInventory.removeFromLowPriority(1);
                    }

                    if (listPlayersChoice[i] == ResourceType.MEDPRIORITY)
                    {
                        playerInventory.removeFromMediumPriority(1);
                    }

                    if (listPlayersChoice[i] == ResourceType.HIGHPRIORITY)
                    {
                        playerInventory.removeFromHighPriority(1);
                    }
                }

                if (listResourceAwared.Count > 0)
                {
                    if (blnDiceRollRequired == true)
                    {
                        int iDiceRoll = rNum.Next(5) + 1;

                        if (listResourceAwared[0] == ResourceType.BACKLOG)
                        {
                            playerInventory.addToBacklog(iDiceRoll);
                        }

                        if (listResourceAwared[0] == ResourceType.LOWPRIORITY)
                        {
                            playerInventory.addToLowPriority(iDiceRoll);
                        }

                        if (listResourceAwared[0] == ResourceType.MEDPRIORITY)
                        {
                            playerInventory.addToMediumPriority(iDiceRoll);
                        }

                        if (listResourceAwared[0] == ResourceType.HIGHPRIORITY)
                        {
                            playerInventory.addToHighPriority(iDiceRoll);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < listResourceAwared.Count; i++)
                        {
                            if (listResourceAwared[i] == ResourceType.BACKLOG)
                            {
                                playerInventory.addToBacklog(1);
                            }

                            if (listResourceAwared[i] == ResourceType.LOWPRIORITY)
                            {
                                playerInventory.addToLowPriority(1);
                            }

                            if (listResourceAwared[i] == ResourceType.MEDPRIORITY)
                            {
                                playerInventory.addToMediumPriority(1);
                            }

                            if (listResourceAwared[i] == ResourceType.HIGHPRIORITY)
                            {
                                playerInventory.addToHighPriority(1);
                            }
                        }
                    }
                }
                else
                {
                    playerInventory.addTool( );
                }
                return listTypeAwared.ToArray( );
            }
            else
            {
                MessageBox.Show("You do not have enough resources to claim this card."
                    , "Not Enough Resources"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);

                return null;
            }
        }

        /// <summary>
        /// generates the cards description.
        /// </summary>
        public void generateCard( )
        {
            StringBuilder card = new StringBuilder( );
            card.Append("----------------\r\n");
            card.Append("- Reward:      -\r\n");
            if (listResourceAwared.Count > 0)
            {
                if (blnDiceRollRequired == true)
                {
                    card.Append("- " + "earn 1-6 of".PadLeft(12) + " -\r\n");
                    card.Append("- " + this.listResourceAwared[0].ToString( ).PadLeft(12) + " -\r\n");
                }
                else
                {
                    for (int i = 0; i < listResourceAwared.Count; i++)
                    {
                        card.Append("- " + this.listResourceAwared[i].ToString( ).PadLeft(12) + " -\r\n");
                    } 
                }
            }
            else 
            {
                card.Append("- " + "Tool".PadLeft(12) + " -\r\n");
            }
            card.Append("- Item:        -\r\n");
            for (int i = 0; i < listTypeAwared.Count; i++)
            {
                card.Append("- " + this.listTypeAwared[i].ToString().PadLeft(12) + " -\r\n");
            }
            card.Append("----------------");
            strCard = card.ToString( );
        }

        /// <summary>
        /// Displays the card.
        /// </summary>
        /// <returns>The string that represents the card</returns>
        public string displayCard( )
        {
            return strCard;
        }
    }
}
