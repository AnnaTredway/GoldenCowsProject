///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         ToolTaskPrompt.cs
//	Description:       ToolTaskPrompt class for allowing user to choose if they want to use tools by dragging and dropping them to the corresponging resources
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
    public partial class ToolTaskPrompt : Form
    {
        private object draggedItem;         //Item currently being dragged between list boxes by mouse cursor
        private int[] currentToolLevels;    //Array of current tool values of current player for the tool prompt
        public int[] finalToolValues;       //Array of final calculated tool values from each of the 4 lists

        public ToolTaskPrompt(int[] toolLevelList, int[] diceVals)
        {
            draggedItem = null;
            currentToolLevels = toolLevelList;  //This is not a hard copy, but it is fine for the purposes of this form
            finalToolValues = new int[4] { 0, 0, 0, 0 };

            InitializeComponent();

            //Sets the dice textboxes to corresponding calculated dice values so the player can determine if they want to use a tool or not
            backlogTextBox.Text = Convert.ToString(diceVals[0]);
            lowTextBox.Text = Convert.ToString(diceVals[1]);
            medTextBox.Text = Convert.ToString(diceVals[2]);
            highTextBox.Text = Convert.ToString(diceVals[3]);

            //Disables lists that have corresponding dice return values above them equal to 0
            //Backlog text box and list box
            if (diceVals[0] == 0)
            {
                this.backlogListBox.Enabled = false;
                this.backlogListBox.BackColor = Color.Gray;
            }

            //Low-priority text box and list box
            if (diceVals[1] == 0)
            {
                this.lowListBox.Enabled = false;
                this.lowListBox.BackColor = Color.Gray;
            }

            //Med-priority text box and list box
            if (diceVals[2] == 0)
            {
                this.medListBox.Enabled = false;
                this.medListBox.BackColor = Color.Gray;
            }

            //High-priority text box and list box
            if (diceVals[3] == 0)
            {
                this.highListBox.Enabled = false;
                this.highListBox.BackColor = Color.Gray;
            }

            //Sets initial list of tools and their corresponding levels
            toolListBox.Items.Add(("Tool 1: Level " + toolLevelList[0]));
            toolListBox.Items.Add(("Tool 2: Level " + toolLevelList[1]));
            toolListBox.Items.Add(("Tool 3: Level " + toolLevelList[2]));
        }

        #region Reset Button
        /// <summary>
        /// Event Handler for Reset button to 
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SoundController.playButtonClick();

            //Clears all list boxes before resetting them
            foreach (ListBox listBox in Controls.OfType<ListBox>())
            {
                listBox.Items.Clear();
            }

            //Resets list of tools and their corresponding levels to what they used to be
            toolListBox.Items.Add(("Tool 1: Level " + currentToolLevels[0]));
            toolListBox.Items.Add(("Tool 2: Level " + currentToolLevels[1]));
            toolListBox.Items.Add(("Tool 3: Level " + currentToolLevels[2]));
        }
        #endregion

        #region Done Button
        /// <summary>
        /// Event Handler for Done button to return tool values added-up for each task/resource they were used on and close the prompt window
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnDone_Click(object sender, EventArgs e)
        {
            SoundController.playButtonClick();

            finalToolValues[0] = GameController.calcToolLevelsFromList(backlogListBox);
            finalToolValues[1] = GameController.calcToolLevelsFromList(lowListBox);
            finalToolValues[2] = GameController.calcToolLevelsFromList(medListBox);
            finalToolValues[3] = GameController.calcToolLevelsFromList(highListBox);

            Close();
        }
        #endregion

        #region ListBox DragAndDrop Event Handlers
        //Link to StackOverflow fix for an issue in the DragAndDrop Events that I could not figure out myself - Bobby
        //https://stackoverflow.com/questions/16591975/c-sharp-drag-and-drop-from-listbox/

        /// <summary>
        /// Event Handler for DragEnter event for list boxes
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void universalListBox_DragEnter(object sender, DragEventArgs e)
        {
            //Stores list box that fired event into "listBox"
            ListBox listBox = sender as ListBox;

            //If there is an item that is currently being dragged that isnt null, add it to the currently hovered over list
            if (draggedItem != null)
            {
                listBox.Items.Add(draggedItem);
                draggedItem = null;
            }
        }

        /// <summary>
        /// Event Handler for DragLeave event for list boxes
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void universalListBox_DragLeave(object sender, EventArgs e)
        {
            //Stores list box that fired event into "listBox"
            ListBox listBox = sender as ListBox;

            draggedItem = listBox.SelectedItem;
            listBox.Items.Remove(listBox.SelectedItem);
        }

        /// <summary>
        /// Event Handler for DragOver event for list boxes
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void universalListBox_DragOver(object sender, DragEventArgs e)
        {
            //Stores list box that fired event into "listBox"
            ListBox listBox = sender as ListBox;

            //Currently event handler does nothing
        }

        /// <summary>
        /// Event Handler for MouseDown event for list boxes
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void universalListBox_MouseDown(object sender, MouseEventArgs e)
        {
            //Stores list box that fired event into "listBox"
            ListBox listBox = sender as ListBox;
            draggedItem = null;

            if (listBox.Items.Count == 0)
            {
                return;
            }

            //try-catch here because program crashes if you click on an area of a list that used to have an item in it but doesnt anymore
            try
            {
                int listIndex = listBox.IndexFromPoint(e.X, e.Y);
                string s = listBox.Items[listIndex].ToString();
                _ = DoDragDrop(s, DragDropEffects.All);
            }
            catch
            { }
        }
        #endregion
    }
}
