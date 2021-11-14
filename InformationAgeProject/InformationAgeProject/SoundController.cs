///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  InformationAgeProject/InformationAgeProject
//	File Name:         SoundController.cs
//	Description:       SoundController class for methods to control music and sound effects within game
//	Course:            CSCI-4250-002 - Software Engineering I
//	Authors:           Anna Tredway, harwellab@etsu.edu
//                     Bobby Mullins, mullinsbd@etsu.edu
//                     Brandon Rhyno, rhynob@etsu.edu
//                     Magnus Allen, allenmv@etsu.edu
//	Created:           Saturday, November 14, 2021
//	Copyright:         Golden Cows Team, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Media;
using System.Text;
using System.Threading.Tasks;

namespace InformationAgeProject
{
    class SoundController
    {
		//MediaPlayers for music and sounds
		public static MediaPlayer musicPlayer;
		public static MediaPlayer effectPlayer;

		#region SoundController Constructor
		/// <summary>
		/// Private Constructor for SoundController 
		/// </summary>
		private SoundController() 
		{
			//Instantiates MediaPlayers for music and sounds
			musicPlayer = new MediaPlayer();
			effectPlayer = new MediaPlayer();
		}
		#endregion

		#region playMusic() Method
		/// <summary>
		/// Method for opening game to main menu on startup
		/// </summary>
		public static void playMusic()
		{
			musicPlayer.Open(new Uri("\\Files\\Music\\goodmusic.wav"));
			musicPlayer.Play();

		}//end openGame()
		#endregion

		#region playButtonClick() Method
		/// <summary>
		/// Method for opening game to main menu on startup
		/// </summary>
		public static void playButtonClick()
		{
			effectPlayer.Open(new Uri("\\Files\\SoundEffects\\minecraft_click.wav"));
			effectPlayer.Play();

		}//end openGame()
		#endregion
	}
}
