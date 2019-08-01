using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeRock
{
    class Human : Player
    {
        public override string ChooseGesture()
        {
            Console.WriteLine("Please choose rock, paper, scissors, lizard, or spock");
            gesture = Console.ReadLine();
            return gesture;
        }
        public override string ChooseName()
        {
            Console.WriteLine("Please enter a name for your player");
            playerName = Console.ReadLine();
            return playerName;
        }
    }
}
