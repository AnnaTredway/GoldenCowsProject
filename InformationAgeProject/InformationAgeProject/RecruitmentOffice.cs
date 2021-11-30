///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeTests
//	File Name:         RecruitmentOffice.cs
//	Description:       RecruitmentOffice defines the Recruitment Office object
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Friday, November 12, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace InformationAgeProject
{
    /// <summary>
    /// RecruitmentOffice Class: Hosts methods/properties needed to manipulate the game's recruitment office.
    /// </summary>
    public class RecruitmentOffice
    {
        //Private player developer count
        private int _devs;

        /// <summary>
        /// RecruitmentOffice Constructor: Parameterized constructor that defines a
        /// newly instantiated recruitmnet office. 
        /// </summary>
        /// <param name="devs">Player's total developer count</param>
        public RecruitmentOffice(int devs)
        {
            _devs = devs;
        }

        /// <summary>
        /// RecruitNewDev Method: Adds an addtional developer to the player's total
        /// developer count.
        /// </summary>
        /// <returns></returns>
        public int RecruitNewDev()
        {
            _devs += 1;
            int devsRecruited = _devs;
            return devsRecruited;
        }
    }
}
