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
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Media;
using System.Text;
using System.Threading.Tasks;

namespace InformationAgeProject
{
    class SoundController
    {
		//Random object for choosing next soundtrack
		public static Random random = new Random();

		//MediaPlayers for music and sounds
		public static MediaPlayer musicPlayer;
		public static MediaPlayer buttonPlayer;

		//String for storing location of "Sounds" folder
		private static string filePath;

		#region SoundController Constructor
		/// <summary>
		/// Private Constructor for SoundController 
		/// </summary>
		private SoundController() { }
		#endregion

		#region openAllSounds() & setSoundsPath() Methods
		/// <summary>
		/// Method for opening all sounds in game before game starts to prevent lag
		/// </summary>
		public static void openAllSounds()
		{
			//Gets filepath of "Sounds" folder
			filePath = getSoundsPath();

			//Instantiates all MediaPlayers
			buttonPlayer = new MediaPlayer();
			musicPlayer = new MediaPlayer();

			//Adds event handlers to media players that require it
			musicPlayer.MediaEnded += new EventHandler(c_MusicMediaEnded);

			//Open relative location of sound effect files for later use
			buttonPlayer.Open(new Uri(filePath + "\\Effects\\minecraftclick.wav"));

			//Open relative location of music files for later use
			musicPlayer.Open(new Uri(filePath + "\\Music\\NeverGonnaGiveYouUp.wav"));

			buttonPlayer.Volume = 0.5;
			musicPlayer.Volume = 0.3;

		}

		/// <summary>
		/// Method for getting filepath of "Sounds" folder
		/// </summary>
		/// <returns>Filepath of "Sounds" folder within program</returns>
		public static string getSoundsPath()
		{
			string soundsPath;

			//Get the current directory and move up two parent directories
			soundsPath = Directory.GetCurrentDirectory();
			soundsPath = Directory.GetParent(soundsPath).FullName;
			soundsPath = Directory.GetParent(soundsPath).FullName;

			//Add the relative location of "Sounds" folder to soundsPath
			soundsPath += "\\Sounds";

			return soundsPath;
		}
		#endregion

		#region playButtonClick() Method
		/// <summary>
		/// Method for playing button click sound effect
		/// </summary>
		public static void playButtonClick()
		{
			buttonPlayer.Play();

			//Reopens file to re-use in the futurre
			buttonPlayer.Open(new Uri(filePath + "\\Effects\\minecraftclick.wav"));
		}
		#endregion

		#region playMusic() Method
		/// <summary>
		/// Method for playing random music track
		/// </summary>
		public static void playMusic()
		{
			//Selects next song to play randomly after previous one ends
			//(Currently only has 1 track to play and may play same track in a row even if more tracks are added)
			switch (random.Next(4))
			{
				case 0:
					musicPlayer.Open(new Uri(filePath + "\\Music\\NeverGonnaGiveYouUp.wav"));
					musicPlayer.Play();
					break;

				case 1:
					musicPlayer.Open(new Uri(filePath + "\\Music\\NeverGonnaGiveYouUp.wav"));
					musicPlayer.Play();
					break;

				case 2:
					musicPlayer.Open(new Uri(filePath + "\\Music\\NeverGonnaGiveYouUp.wav"));
					musicPlayer.Play();
					break;

				case 3:
					musicPlayer.Open(new Uri(filePath + "\\Music\\NeverGonnaGiveYouUp.wav"));
					musicPlayer.Play();
					break;
			}

		}
		#endregion


		/// <summary>
		/// Event Handler for handling when musicPlayer media ends
		/// </summary>
		/// <param name="sender">object that raised the event (auto-generated, unused here)</param>
		/// <param name="e">arguments for event (auto-generated, unused here)</param>
		static void c_MusicMediaEnded(object sender, EventArgs e)
		{
			//Starts next track
			playMusic();
		}
	}
}
