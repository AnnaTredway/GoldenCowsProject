///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         EasterEggImageForm.cs
//	Description:       EasterEggImageForm window gui to display Easter Egg images
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Tuesday, November 30, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System.Drawing;
using System.Windows.Forms;

namespace InformationAgeProject
{
    public partial class EasterEggImageForm : Form
    {
        public EasterEggImageForm(Image image, string windowName)
        {
            InitializeComponent();

            this.easterEggPictureBox.Image = image;
            this.Text = windowName;
        }
    }
}
