using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeRock
{
    class Computer : Player
    {
        public override string ChooseGesture()
        {
            gesture = "rock";
            Console.WriteLine("player2 name chose list index()");
            return gesture;
        }
        public override string ChooseName()
        {
            Console.WriteLine("The computer player is named Billy Bob");
            playerName = "Billy Bob";
            return playerName;
        }
    }
}
