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

        //MediaPlayers for sounds and music
        public static MediaPlayer buttonPlayer;
        public static MediaPlayer musicPlayer;

        private static string filePath;                 //String for storing location of "Sounds" folder
        private static string currentMusicPath = "";    //Current file path of music playing Set to empty for first comparison in playMusic()
        private static int numTracks = 2;               //Number of music tracks currently in program
        private static Uri[] musicUriArray;             //Storage array of Uri's to use in musicPlayer

        #region SoundController Constructor
        /// <summary>
        /// Private Constructor for SoundController 
        /// </summary>
        private SoundController() { }
        #endregion

        #region openAllSounds() Method
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

            //Open relative location of button sound effect file for later use
            buttonPlayer.Open(new Uri(filePath + "\\Effects\\minecraftclick.wav"));

            //Fills Uri array of music tracks
            musicUriArray = fillMusicUriArray(numTracks);

            //Open relative location of music files for later use from musicUriArray
            foreach (Uri musicUri in musicUriArray)
            {
                musicPlayer.Open(musicUri);
            }

            //Adds event handlers to music player to be able to play more than one track
            musicPlayer.MediaEnded += new EventHandler(c_MusicMediaEnded);

            //Sets volume of each MediaPlayer to respective global property
            buttonPlayer.Volume = (double)Properties.Settings.Default.EffectsVolume / 100;
            musicPlayer.Volume = (double)Properties.Settings.Default.MusicVolume / 100;

        }
        #endregion

        #region setSoundsPath() Method
        /// <summary>
        /// Method for getting filepath of "Sounds" folder
        /// </summary>
        /// <returns>Filepath of "Sounds" folder within program</returns>
        private static string getSoundsPath()
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

        #region fillMusicUriArray() Method
        /// <summary>
        /// Method for filling a Uri array of music tracks
        /// </summary>
        /// <returns>Filled Uri array of music trakcs</returns>
        private static Uri[] fillMusicUriArray(int arraySize)
        {
            Uri[] uriArray = new Uri[arraySize];

            //Open relative location of music files and puts them in uriArray (This has to be hard-coded currently)

            uriArray[0] = new Uri(filePath + "\\Music\\NeverGonnaGiveYouUp.wav");   //Source: https://www.youtube.com/watch?v=dQw4w9WgXcQ
            uriArray[1] = new Uri(filePath + "\\Music\\NokiaEspionagePTRK.wav");    //Source: https://www.youtube.com/watch?v=K_4ZoMp0Rpo

            return uriArray;
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
            bool newTrackPlayed = false;
            int randomVal;

            //Stays in while loop until new track has been played
            while (newTrackPlayed == false)
            {
                //Selects next song to play randomly after previous one ends, but not the same one twice in a row
                randomVal = random.Next(numTracks);

                //If the stored current song path is not the same as the next songs's path, load and play it
                //Else, restart while loop and hope for random number that doesn't land on same array index
                if (currentMusicPath != musicUriArray[randomVal].AbsoluteUri)
                {
                    currentMusicPath = musicUriArray[randomVal].AbsoluteUri;    //Set currentMusicPath to new path for future comparison

                    musicPlayer.Open(musicUriArray[randomVal]);
                    musicPlayer.Play();

                    newTrackPlayed = true; //Set to true to get out of while loop if new track is played
                }


            }

        }
        #endregion

        //Event Handlers
        #region c_MusicMediaEnded() Event
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
        #endregion
    }
}
