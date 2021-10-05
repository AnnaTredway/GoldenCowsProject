/////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         ResourceType.cs
//	Description:       ResourceType enum class for the different resource/task types
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Friday, October 1, 2021
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
    /// ResourceType enum for different types of resources/tasks
    /// </summary>
    enum ResourceType
    {
        BACKLOG,
        LOWPRIORITY,
        MEDPRIORITY,
        HIGHPRIORITY
    }
}
