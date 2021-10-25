///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         ToolManager.cs
//	Description:       ToolManager class for managing tools in program
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Thursday, October 14, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationAgeProject
{
    /// <summary>
    /// ToolManager class for managing tools in program
    /// </summary>
    public class ToolManager
    {
        //Tool array for current player, one slot in array for each slot on board for current player
        private Tool[] toolList = new Tool[3];

        //Counter for adding level to each tool in correct order when new tool is acquired
        int levelCounter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolManager"/> class.
        /// </summary>
        public ToolManager()
        {
            //All tools in inventory set to level 0 at the beginning of the program
            this.toolList[0] = new Tool(ToolType.LEVEL0);
            this.toolList[1] = new Tool(ToolType.LEVEL0);
            this.toolList[2] = new Tool(ToolType.LEVEL0);

            levelCounter = 0;
        }

        #region Setters
        /// <summary>
        /// Sets the tool level of the tool in the first slot
        /// </summary>
        /// <param name="inputLevel">The input level for the first tool be set to.</param>
        public void setFirstSlotLevel(int inputLevel)
        {
            this.toolList[0].changeLevel(inputLevel);

        }//end setFirstSlotLevel()

        /// <summary>
        /// Sets the tool level of the tool in the second slot
        /// </summary>
        /// <param name="inputLevel">The input level for the second tool be set to.</param>
        public void setSecondSlotLevel(int inputLevel)
        {
            this.toolList[1].changeLevel(inputLevel);

        }//end setSecondSlotLevel()

        /// <summary>
        /// Sets the tool level of the tool in the third slot
        /// </summary>
        /// <param name="inputLevel">The input level for the third tool be set to.</param>
        public void setThirdSlotLevel(int inputLevel)
        {
            this.toolList[2].changeLevel(inputLevel);

        }//end setThirdSlotLevel()
        #endregion

        #region Getters
        /// <summary>
        /// Gets the level of the first tool in inventory
        /// </summary>
        /// <returns>The level of the first tool</returns>
        public int getFirstSlotLevel()
        {
            return this.toolList[0].toolLevel;

        }//end getFirstSlotLevel()

        /// <summary>
        /// Gets the level of the second tool in inventory
        /// </summary>
        /// <returns>The level of the second tool</returns>
        public int getSecondSlotLevel()
        {
            return this.toolList[1].toolLevel;

        }//end getSecondSlotLevel()

        /// <summary>
        /// Gets the level of the third tool in inventory
        /// </summary>
        /// <returns>The level of the third tool</returns>
        public int getThirdSlotLevel()
        {
            return this.toolList[2].toolLevel;

        }//end getThirdSlotLevel()
        #endregion

        /// <summary>
        /// Increases tool levels in correct order
        /// </summary>
        public void increaseToolLevel()
        {
            //Resets levelCounter if it goes higher than 2 (the max index level in tool inventory)
            if(levelCounter >= 3)
            {
                levelCounter = 0;
            }

            //Increases tool level of tool in current counter index
            toolList[levelCounter].toolLevel++;

            //Increases counter index for next run
            levelCounter++;

        }//end setFirstSlotLevel()

    }//end class ToolManager
}//end namespace InformationAgeProject
