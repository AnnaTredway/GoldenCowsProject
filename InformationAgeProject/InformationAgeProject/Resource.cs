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
        public int resourceAmount;  // Stores the amount of this resource a player has
        public ResourceType type;   // Stores the type of the resource/task

        /// <summary>
        /// Initializes a new instance of the <see cref="Resource"/> class.
        /// </summary>
        public Resource( )
        {
            this.resourceName = "Any";
            this.resourceAmount = 0;
            this.type = ResourceType.ANY;
        }// end Resource( )

        /// <summary>
        /// Initializes a new instance of the <see cref="Resource"/> class.
        /// </summary>
        /// <param name="resourceName">Name of the resource</param>
        /// <param name="type">Type of the resource</param>
        public Resource(string resourceName, ResourceType type)
        {
            this.resourceName = resourceName;
            this.resourceAmount = 0;
            this.type = type; 
        }// end Resource(string resourceName)

        /// <summary>
        /// Initializes a new instance of the <see cref="Resource"/> class.
        /// </summary>
        /// <param name="randomType">A random number.</param>
        public Resource (int randomType)
        {
            var temp = (ResourceType)randomType;
            this.resourceName = temp.ToString();
            this.resourceAmount = 0;
            this.type = temp;
        }

        /// <summary>
        /// Checks to see if two resources are equal to each other
        /// </summary>
        /// <param name="otherResource">The other resource.</param>
        /// <returns></returns>
        public bool EqualTo(Resource otherResource)
        {
            return this.type.Equals(otherResource.type);
        }
    }// end class Resource
}// end namespace InformationAgeProject
