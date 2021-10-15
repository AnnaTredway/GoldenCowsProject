///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         Tool.cs
//	Description:       Tool class for help with collecting resources/tasks
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
    /// Tool class for help with collecting resources/tasks
    /// </summary>
    class Tool
    {
        public int toolLevel;  //Stores number of the level for easier access
        public ToolType type;  //Stores the enumerated ToolType for hard-coded error prevention

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool"/> class.
        /// </summary>
        public Tool()
        {   
            //New tool with no parameters is set to level 0
            this.toolLevel = 0;
            this.type = ToolType.LEVEL0;

        }//end Tool() Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool"/> class with an int toolLevel parameter
        /// </summary>
        /// <param name="toolLevel">Level number for tool</param>
        public Tool(int toolLevel)
        {
            this.toolLevel = toolLevel;

            //Matches the level to the input toolLevel
            switch (this.toolLevel)
            {
                case 0:
                    this.type = ToolType.LEVEL0;
                    break;

                case 1:
                    this.type = ToolType.LEVEL1;
                    break;

                case 2:
                    this.type = ToolType.LEVEL2;
                    break;

                case 3:
                    this.type = ToolType.LEVEL3;
                    break;

                case 4:
                    this.type = ToolType.LEVEL4;
                    break;
            }

        }//end Tool() Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool"/> class with an enumerated ToolType level parameter
        /// </summary>
        /// <param name="type">ToolType for tool</param>
        public Tool(ToolType type)
        {
            this.type = type;

            //Matches the toolLevel to the input level 
            switch (this.type)
            {
                case ToolType.LEVEL0:
                    this.toolLevel = 0;
                    break;

                case ToolType.LEVEL1:
                    this.toolLevel = 1;
                    break;

                case ToolType.LEVEL2:
                    this.toolLevel = 2;
                    break;

                case ToolType.LEVEL3:
                    this.toolLevel = 3;
                    break;

                case ToolType.LEVEL4:
                    this.toolLevel = 4;
                    break;
            }

        }//end Tool() Constructor

        /// <summary>
        /// Changes level of tool
        /// </summary>
        /// <param name="newLevel">New level for the tool.</param>
        public void ChangeLevel(int newLevel)
        {
            this.toolLevel = newLevel;

            //Matches the level to the newly updated toolLevel
            switch (this.toolLevel)
            {
                case 0:
                    this.type = ToolType.LEVEL0;
                    break;

                case 1:
                    this.type = ToolType.LEVEL1;
                    break;

                case 2:
                    this.type = ToolType.LEVEL2;
                    break;

                case 3:
                    this.type = ToolType.LEVEL3;
                    break;

                case 4:
                    this.type = ToolType.LEVEL4;
                    break;
            }

        }//end ChangeLevel()

        /// <summary>
        /// Checks to see if two tools are equal to each other
        /// </summary>
        /// <param name="otherTool">The other tool.</param>
        /// <returns>True or False</returns>
        public bool EqualTo(Tool otherTool)
        {
            return this.type.Equals(otherTool.type);

        }//end EqualTo()

    }//end class Tool
}//end namespace InformationAgeProject
