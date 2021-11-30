///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         SaveLoadObject.cs
//	Description:       SaveLoadObject class for storing a copy of the variables in GameController for saving and loading
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
    /// SaveLoadObject class for storing GameController variables for saving and loading
    /// </summary>
    [Serializable]
    public class SaveLoadObject
    {
        //Copies of variabled used in GameController that are pertinent to saving and loading a game instance
        public int turnCounter;
        public int roundCounter;

        public bool toolMakerFull;
        public int playerAtToolMaker;

        public bool recruitmentOfficeFull;
        public int playerAtRecruitmentOffice;

        public Player[] playerList;
        public MainFormValuesObject[] mainFormValues;

        public ProjectProgressDeck[] ProjProgDeck;
        public AdditionalProjectFeaturesDeck ProjFeatDeck;

        /// <summary>
        /// Private Constructor for SaveLoadObject needed to serialize to and from XML file for saving and loading 
        /// </summary>
        private SaveLoadObject() { }

        #region SaveLoadObject Parameterized Constructor
        /// <summary>
        /// Parameterized Constructor for SaveLoadObject 
        /// </summary>
        public SaveLoadObject(int turnCounter,
                              int roundCounter,
                              bool toolMakerFull,
                              int playerAtToolMaker,
                              bool recruitmentOfficeFull,
                              int playerAtRecruitmentOffice,
                              Player[] playerList,
                              MainForm[] playerForms,
                              ProjectProgressDeck[] ProjProgDeck,
                              AdditionalProjectFeaturesDeck ProjFeatDeck)
        {
            this.turnCounter = turnCounter;
            this.roundCounter = roundCounter;

            this.toolMakerFull = toolMakerFull;
            this.playerAtToolMaker = playerAtToolMaker;

            this.recruitmentOfficeFull = recruitmentOfficeFull;
            this.playerAtRecruitmentOffice = playerAtRecruitmentOffice;

            //Deep clones all Player objects within input array
            this.playerList = new Player[playerList.Length];
            for (int i = 0; i < playerList.Length; i++)
            {
                this.playerList[i] = playerList[i].DeepClone();
            }

            //Deep clones all MainForm objects within input array
            this.mainFormValues = new MainFormValuesObject[playerForms.Length];
            for (int i = 0; i < playerForms.Length; i++)
            {
                this.mainFormValues[i] = playerForms[i].StoreMainFormValuesInObject();
            }

            //Deep clones all ProjectProgressDeck objects within input array
            this.ProjProgDeck = new ProjectProgressDeck[ProjProgDeck.Length];
            for (int i = 0; i < ProjProgDeck.Length; i++)
            {
                this.ProjProgDeck[i] = ProjProgDeck[i].DeepClone();
            }

            this.ProjFeatDeck = ProjFeatDeck.DeepClone();

        }//end SaveLoadObject() Parameterized Constructor
        #endregion
    }
}
