/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         OptionsForm.cs
//	Description:       OptionsForm form for options menu GUI
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Monday, November 1, 2021
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
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Event Handler for handling when OptionsForm loads
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void OptionsForm_Load(object sender, EventArgs e)
        {
            //Sets every control on the form to invisible
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            //Sets every control on main options screen to visible
            lblOptions.Visible = true;
            btnGraphics.Visible = true;
            btnSound.Visible = true;
            btnBackToMainMenu.Visible = true;
            btnResetGraphics.Visible = true;
            btnResetSound.Visible = true;
        }

        /// <summary>
        /// Event Handler for button to go to graphics options screen
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnGraphics_Click(object sender, EventArgs e)
        {
            //Sets every control on the form to invisible
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            //Sets every control on graphics options screen to visible
            lblGraphics.Visible = true;
            btnBackColor.Visible = true;
            btnButtonColor.Visible = true;
            btnBack.Visible = true;
            btnResetGraphics.Visible = true;
            btnResetSound.Visible = true;
        }

        /// <summary>
        /// Event Handler for button to go to sound options screen
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnSound_Click(object sender, EventArgs e)
        {
            //Sets every control on the form to invisible
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            //Sets every control on sound options screen to visible
            lblSound.Visible = true;

            btnBack.Visible = true;
            btnResetGraphics.Visible = true;
            btnResetSound.Visible = true;
        }

        #region Graphics Options Buttons
        /// <summary>
        /// Event Handler for button to change background color in program
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnBackColor_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event Handler for button to change button color in program
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnButtonColor_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Reset Buttons
        /// <summary>
        /// Event Handler for button to reset graphics options back to default
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnResetGraphics_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event Handler for button to reset sound options back to default
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnResetSound_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Back Buttons
        /// <summary>
        /// Event Handler for button to go back to main menu
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Event Handler for button to go back to main options screen
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            //Sets every control on the form to invisible
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            //Sets every control on main options screen to visible
            lblOptions.Visible = true;
            btnGraphics.Visible = true;
            btnSound.Visible = true;
            btnBackToMainMenu.Visible = true;
            btnResetGraphics.Visible = true;
            btnResetSound.Visible = true;
        }
        #endregion

    }
}
