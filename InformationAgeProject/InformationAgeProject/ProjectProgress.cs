using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationAgeProject
{
    class ProjectProgress
    {
        private Random rNum = new Random();
        private int iPointValue;
        private int iDifferentTypesNeeded;
        private List<Resource> ResourceCost = new List<Resource>( );

        public ProjectProgress( )
        {
            this.iPointValue = rNum.Next(6) + 10;
            this.ResourceCost.Add(new Resource(rNum.Next(3)));
            this.ResourceCost.Add(new Resource(rNum.Next(3)));
            this.ResourceCost.Add(new Resource(rNum.Next(3)));
        }

        public ProjectProgress(int reseouceAmountNeeded, int reseouceTypeNeeded)
        {
            for (int i = 0; i < reseouceAmountNeeded; i++)
            {
                this.ResourceCost.Add(new Resource());
            }
            this.iDifferentTypesNeeded = reseouceTypeNeeded;
        }

        public int awardPoints(ResourceManager playersResources)
        {
            bool enoughResources = true;
            int iPoints = 0;
            int[] iCost = new int[ResourceCost.Count];
            int[] iPlayer = new int[4];
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
                    }
                    else if (this.ResourceCost[i].type == ResourceType.LOWPRIORITY && iPlayer[1] > 0)
                    {
                        iPlayer[1]--;
                    }
                    else if (this.ResourceCost[i].type == ResourceType.MEDPRIORITY && iPlayer[2] > 0)
                    {
                        iPlayer[2]--;
                    }
                    else if (this.ResourceCost[i].type == ResourceType.HIGHPRIORITY && iPlayer[3] > 0)
                    {
                        iPlayer[3]--;
                    }
                    else
                    {
                        MessageBox.Show("You do not have enough resources to complete this card!", "Not Enough Resources");
                        enoughResources = false;
                        break;
                    }
                }
                if (enoughResources == true)
                {
                    playersResources.setBacklog(iPlayer[0]);
                    playersResources.setLowPriority(iPlayer[1]);
                    playersResources.setMediumPriority(iPlayer[2]);
                    playersResources.setHighPriority(iPlayer[3]);
                    iPoints = this.iPointValue;
                }
            }
            else
            {
                // Set up a way for the player to select which resources they want to use.
                int counter = 0;

                for (int i = 0; i < iCost.Length; i++)
                {
                    for (int j = 0; j < iCost.Length; j++)
                    {
                        if (iCost[i] != iCost[j] && i != j)
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
            }
            return iPoints;
        }
    }
}
