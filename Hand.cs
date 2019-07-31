using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeRock
{
    class Hand
    {
        //member variable (has)
        public string choice;

        //constructor (builds)
        public Hand(string Choice)
        {
            choice = Choice;
        }

        //methods (does)
        public string AskChoice()
        {
            Console.WriteLine("What would you like to throw this round? Rock, paper, scissors, lizard, or spock?");
            string inputChoice = Console.ReadLine();
            return inputChoice;
        }
    }
}
