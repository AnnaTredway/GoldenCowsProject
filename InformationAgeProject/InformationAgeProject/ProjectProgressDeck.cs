using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationAgeProject
{
    class ProjectProgressDeck
    {
        ProjectProgress[] Deck = new ProjectProgress[28];
        public ProjectProgressDeck( )
        {
            for (int i = 0; i < Deck.Length; i++)
            {
                Deck[i] = new ProjectProgress( );
            }
        }

        public void Shuffle( )
        {
            Random rNum = new Random( );
            int iRandom;
            ProjectProgress swap;
            for (int i = 0; i < Deck.Length; i++)
            {
                iRandom = rNum.Next(Deck.Length);
                swap = Deck[i];
                Deck[i] = Deck[iRandom];
                Deck[iRandom] = swap;
            }
        }
    }
}
