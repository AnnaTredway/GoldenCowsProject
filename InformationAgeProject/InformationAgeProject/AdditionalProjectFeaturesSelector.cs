///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         AdditionalProjectFeaturesSelector.cs
//	Description:       Class for selecting resources for awarding cards
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationAgeProject
{
    /// <summary>
    /// Form that prompts the user to spend resources
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class AdditionalProjectFeaturesSelector : Form
    {
        private int iCardCost;                                                    // The cost of claiming a card 
        private List<ResourceType> listPlayersChoice = new List<ResourceType>( ); // The list of resources a player currently has

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalProjectFeaturesSelector"/> class.
        /// </summary>
        /// <param name="cardCost">The card cost.</param>
        /// <param name="iPlayer">The i player.</param>
        public AdditionalProjectFeaturesSelector(int cardCost, int[] iPlayer)
        {
            InitializeComponent( );

            this.iCardCost = cardCost;

            //Update each checklist to have the number of resources the player has.
            TitleLable.Text = "Please select " + iCardCost + " resources.";
            for (int i = 0; i < iPlayer[0]; i++)
            {
                BacklogCheckList.Items.Add(ResourceType.BACKLOG);
            }

            for (int i = 0; i < iPlayer[1]; i++)
            {
                LowPriorityCheckList.Items.Add(ResourceType.LOWPRIORITY);
            }

            for (int i = 0; i < iPlayer[2]; i++)
            {
                MedPriorityCheckList.Items.Add(ResourceType.MEDPRIORITY);
            }

            for (int i = 0; i < iPlayer[3]; i++)
            {
                HighPrioroityCheckList.Items.Add(ResourceType.HIGHPRIORITY);
            }
        }

        /// <summary>
        /// Handles the Click event of the SelectButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SelectButton_Click(object sender, EventArgs e)
        {
            int iTotalSelected;
            iTotalSelected = BacklogCheckList.CheckedItems.Count;
            iTotalSelected += LowPriorityCheckList.CheckedItems.Count;
            iTotalSelected += MedPriorityCheckList.CheckedItems.Count;
            iTotalSelected += HighPrioroityCheckList.CheckedItems.Count;

            if (iTotalSelected == iCardCost)
            {
                for (int i = 0; i < BacklogCheckList.CheckedItems.Count; i++)
                {
                    listPlayersChoice.Add(ResourceType.BACKLOG);
                }
                for (int i = 0; i < LowPriorityCheckList.CheckedItems.Count; i++)
                {
                    listPlayersChoice.Add(ResourceType.LOWPRIORITY);
                }
                for (int i = 0; i < MedPriorityCheckList.CheckedItems.Count; i++)
                {
                    listPlayersChoice.Add(ResourceType.MEDPRIORITY);
                }
                for (int i = 0; i < HighPrioroityCheckList.CheckedItems.Count; i++)
                {
                    listPlayersChoice.Add(ResourceType.HIGHPRIORITY);
                }
                this.Close( );
            }
            else if (iTotalSelected > iCardCost)
            {
                MessageBox.Show("You have selected too many resources. Please select exactly " + iCardCost
                    , "Too Many Resources"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You did not select enough resources. Please select exactly " + iCardCost
                    , "Not Enough Resources"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Gets the selected resources.
        /// </summary>
        /// <returns>Returns the players selection of resources</returns>
        public ResourceType[] getSelectedResources( )
        {
            return listPlayersChoice.ToArray();
        }
    }
}
