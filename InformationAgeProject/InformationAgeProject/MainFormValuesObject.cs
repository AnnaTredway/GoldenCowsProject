///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         MainFormValuesObject.cs
//	Description:       MainFormValuesObject class for storing values of a MainForm. For use in SaveLoadObject class
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Monday, November 29, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

namespace InformationAgeProject
{
    /// <summary>
	/// MainFormValuesObjectclass for storing values of a MainForm. For use in SaveLoadObject class
	/// </summary>
    [Serializable]
    public class MainFormValuesObject
    {
        //Tool maker value
        public string toolMakerText;

        //Recruitment Office maker value
        public string recruitmentOfficeText;
        public bool sendDevEnabled;
        public bool recallDevEnabled;

        //Tasks values
        public string backlogText;
        public string lowText;
        public string medText;
        public string highText;
        public bool backlogAddEnabled;
        public bool backlogSubEnabled;
        public bool lowAddEnabled;
        public bool lowSubEnabled;
        public bool medAddEnabled;
        public bool medSubEnabled;
        public bool highAddEnabled;
        public bool highSubEnabled;
        public bool doTasksEnabled;

        //Inventory and Score text values
        public string inventoryText;
        public string scoreText;

        /// <summary>
		/// Private Constructor for MainFormValuesObject needed to serialize to and from XML file for saving and loading 
		/// </summary>
        private MainFormValuesObject() { }

        /// <summary>
		/// Parameterized Constructor for MainFormValuesObject 
		/// </summary>
        public MainFormValuesObject(string toolMakerText,
            string recruitmentOfficeText,
            bool sendDevEnabled,
            bool recallDevEnabled,
            string backlogText,
            string lowText,
            string medText,
            string highText,
            bool backlogAddEnabled,
            bool backlogSubEnabled,
            bool lowAddEnabled,
            bool lowSubEnabled,
            bool medAddEnabled,
            bool medSubEnabled,
            bool highAddEnabled,
            bool highSubEnabled,
            bool doTasksEnabled,
            string inventoryText,
            string scoreText)
        {
            this.toolMakerText = toolMakerText;
            this.recruitmentOfficeText = recruitmentOfficeText;
            this.sendDevEnabled = sendDevEnabled;
            this.recallDevEnabled = recallDevEnabled;
            this.backlogText = backlogText;
            this.lowText = lowText;
            this.medText = medText;
            this.highText = highText;
            this.backlogAddEnabled = backlogAddEnabled;
            this.backlogSubEnabled = backlogSubEnabled;
            this.lowAddEnabled = lowAddEnabled;
            this.lowSubEnabled = lowSubEnabled;
            this.medAddEnabled = medAddEnabled;
            this.medSubEnabled = medSubEnabled;
            this.highAddEnabled = highAddEnabled;
            this.highSubEnabled = highSubEnabled;
            this.doTasksEnabled = doTasksEnabled;
            this.inventoryText = inventoryText;
            this.scoreText = scoreText;
        }
    }
}
