using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeRock
{
    class Player
    {
        //member variable (has)
        public int playerNumber;
        public int winCounter;

        //constructor (builds)
        public Player(int playerNumber)
        {
            this.playerNumber = playerNumber;
            winCounter = 0;
        }
        //methods (does)
        public string MakeChoice(Hand hand)
        {
            string pick = hand.AskChoice();
            return pick;
        }
    }
}
