using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeRock
{
    class Game
    {
        //member variable (has)
        public string opponent;
        public int bestOf;
        public Player player1;
        public Player player2;
        public Player computer;
        public Hand hand1;
        public Hand hand2;
        public Hand handComputer;
        public int winningThreshold;

        //constructor (builds)
        public Game()
        {
            player1 = new Player();
            player2 = new Player();
            hand1 = new Hand();
            hand2 = new Hand();
            winningThreshold = 3;
        }

        //methods (does)
        private void DisplayRules()
        {
            Console.WriteLine("Each player will choose rock, paper, scissors, lizard or spock, and their choices will be compared to see who wins each round.");
        }
        public void RunGame()
        {
            DisplayRules();
            while(player1.winCounter < winningThreshold && player2.winCounter < winningThreshold)
            {
                string player1Choice = player1.pick(hand1);
            }
        }
    }
}
