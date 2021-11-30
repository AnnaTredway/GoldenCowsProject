///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         ExtensionMethods.cs
//	Description:       ExtensionMethods static class for containing method that deep clones objects
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Monday, November 29, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace InformationAgeProject
{
    /// <summary>
    /// ExtensionMethod static class for containing method that deep clones objects
    /// </summary>
    /// Source: https://stackoverflow.com/questions/129389/how-do-you-do-a-deep-copy-of-an-object-in-net
    public static class ExtensionMethods
    {
        /// <summary>
        /// Method for deep cloning an object
        /// </summary>
        /// <param name="a">Object to make a deep clone of</param>
        /// <returns>Deep cloned object</returns>
        public static T DeepClone<T>(this T a)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, a);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }

        }//end DeepClone<T>
    }
}
