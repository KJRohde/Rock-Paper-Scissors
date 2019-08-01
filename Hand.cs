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
        public List<string> options;

        //constructor (builds)
        public Hand(List<string> options)
        {
            this.options = new List<string>();
            options.Add("rock");
            options.Add("paper");
            options.Add("scissors");
            options.Add("lizard");
            options.Add("spock");
        }

        //methods (does)
        public string DisplayChoice()
        {
            Console.ReadLine(Player.choice);
        }
    }
}
