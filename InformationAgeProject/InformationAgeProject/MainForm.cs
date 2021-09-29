///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         MainForm.cs
//	Description:       Main Form window gui for Information Age Project
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Wednesday, September 15, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationAgeProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        #region Task/Resource Buttons
        /// <summary>
        /// Event Handler for button to add developer to backlog task/resource category if any are available
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void backlogAddButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event Handler for button to remove developer from backlog task/resource category if any are there
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void backlogSubtButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event Handler for button to add developer to low-priority task/resource category if any are available
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void lowAddButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event Handler for button to remove developer from low-priority task/resource category if any there
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void lowSubtButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event Handler for button to add developer to medium-priority task/resource category if any are available
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void medAddButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event Handler for button to remove developer from medium-priority task/resource category if any there
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void medSubtButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event Handler for button to add developer to high-priority task/resource category if any are available
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void highAddButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event Handler for button to remove developer from high-priority task/resource category if any there
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void highSubtButton_Click(object sender, EventArgs e)
        {

        }

        private void doTasksButton_Click(object sender, EventArgs e)
        {

        }
        #endregion
		
        /// <summary>
        /// Method: btnInstructions_Click opens the Instructionset.txt file upon clicking
        /// the btnInstructions button on the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            //Get the current directory
            string filePath = Directory.GetCurrentDirectory();

            //Move up two parent directories
            filePath = Directory.GetParent(filePath).FullName;
            filePath = Directory.GetParent(filePath).FullName;

            //Append the location of InstructionSet.txt to filePath
            filePath += "/Files/InstructionSet.txt";

            //Open the file located at filePath (which is InstructionSet.txt
            Process.Start(filePath);
        }
    }
}