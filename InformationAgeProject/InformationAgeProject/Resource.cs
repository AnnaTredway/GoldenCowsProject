///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         Resource.cs
//	Description:       Creates a resource
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Monday, September 20, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Contains the classes within the Information Age project
/// </summary>
namespace InformationAgeProject
{
    /// <summary>
    /// Creates a resource
    /// </summary>
    class Resource
    {
        public string resourceName; // Stores the name of the resource
        public int resourceAmount;  // Stores the amount of this resource a player has.

        /// <summary>
        /// Initializes a new instance of the <see cref="Resource"/> class.
        /// </summary>
        public Resource( )
        {
            var temp = ResourceType.ANY;
            this.resourceName = temp.ToString( );
            this.resourceAmount = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Resource"/> class.
        /// </summary>
        /// <param name="resourceName">Name of the resource.</param>
        public Resource(int iResourceEnumIndex)
        {
            var temp = (ResourceType)iResourceEnumIndex;
            this.resourceName = temp.ToString();
            this.resourceAmount = 0;
        }// end Resource(string resourceName)

        public bool EqualTo(Resource otherResource)
        {
            return this.resourceName.Equals(otherResource.resourceName);
        }
    }// end class Resource
}// end namespace InformationAgeProject
