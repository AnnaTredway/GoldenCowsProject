///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         QuitForm.cs
//	Description:       QuitForm for prompting user whether or not they want to actually quit program
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Wednesday, October 6, 2021
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
	public partial class QuitForm : Form
	{
		public QuitForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Event Handler for Yes button to exit program completely
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnYes_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Event Handler for No button to close quit window form and go back to main form
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		private void btnNo_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
