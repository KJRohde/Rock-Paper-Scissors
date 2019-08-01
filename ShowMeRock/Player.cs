using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeRock
{
    abstract class Player
    {
        //member variable (has)
        public string gesture;
        public string playerName;
        public int winCounter;

        //methods (does)
        public abstract string ChooseName();
        //{
        //    Console.WriteLine("Please choose a name");
        //    playerName = Console.ReadLine();
        //}
        public abstract string ChooseGesture();
        //{
        //    Console.WriteLine("Please choose rock, paper, scissors, lizard, or spock");
        //    gesture = Console.ReadLine();
        //}
    }
}
