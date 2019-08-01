using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeRock
{
    class Game
    {
        //member variable (has) TODO: Add player option for best of how many games
        private int numberOfPlayers;
        private Player player1;
        private Player player2;
        private int winningThreshold;
        private string player1Choice;
        private string player2Choice;
        private int player1WinCounter;
        private int player2WinCounter;

        //constructor (builds)
        public Game()
        {
            player1WinCounter = 0;
            player2WinCounter = 0;
        }

        //methods (does)
        private void DisplayRules()
        {
            Console.WriteLine("Each player will choose rock, paper, scissors, lizard or spock, and their choices will be compared to see who wins.");
            Console.WriteLine("Rock crushes scissors\nScissors cuts paper\nPaper covers rock\nRock crushes lizard\nPaper disproves spock\nLizard eats paper\nSpock crushes scissors\nScissors decapitates lizard\nLizard poisons spock\nSpock vaporizes rock");
        }
        private int GetNumberOfPlayers()
        {
            Console.WriteLine("How many human players are present?");
            while (int.TryParse(Console.ReadLine(), out numberOfPlayers) && numberOfPlayers > 2 || numberOfPlayers < 1)
            {
                Console.WriteLine("This game is for a maximum of 2 players and minimum of 1 player");
            }
            return numberOfPlayers;
            //    if (numberOfPlayers < 1 || numberOfPlayers > 2)
            //    {
            //        Console.WriteLine("There must be at least 1 human player, but no more than 2.");
            //        return GetNumberOfPlayers();
            //    }
            //    else
            //    {
            //        return numberOfPlayers;
            //    }
            //}
            //else if (numberOfPlayers == false)
            //{
            //    Console.WriteLine("You must enter a number. 1 or 2");
            //    return GetNumberOfPlayers();
            //}
        }
        private void setupPlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                player1 = new Human();
                player1.ChooseName();
                player2 = new Computer();
                player2.ChooseName();
            }
            else if (numberOfPlayers == 2)
            {
                player1 = new Human();
                player1.ChooseName();
                player2 = new Human();
                player2.ChooseName();
            }
        }
        private int GetNumberOfGames()
        {
            Console.WriteLine("How many round victories will this contest take to win?");
            winningThreshold = int.Parse(Console.ReadLine());
            return winningThreshold;
        }
        public void RunGame()
        {
            DisplayRules();
            numberOfPlayers = GetNumberOfPlayers();
            setupPlayers(numberOfPlayers);
            GetNumberOfGames();
            while (player1WinCounter < winningThreshold && player2WinCounter < winningThreshold)
            {
                player1Choice = player1.ChooseGesture();
                player2Choice = player2.ChooseGesture();

                Console.WriteLine("\n" + player1.playerName + " chose " + player1Choice);
                Console.WriteLine("\n" + player2.playerName + " chose " + player2Choice + "\n");

                if (player1Choice == "rock")
                {
                    if (player2Choice == "scissors" || player2Choice == "lizard")
                    {
                        Console.WriteLine(player1.playerName + " wins this round!\n");
                        player1WinCounter++;
                    }
                    else if (player2Choice == "paper" || player2Choice == "spock")
                    {
                        Console.WriteLine(player2.playerName + " wins this round!\n");
                        player2WinCounter++;
                    }
                    else
                    {
                        Console.WriteLine("This round was a tie!\n");
                    }
                }
                if (player1Choice == "paper")
                {
                    if (player2Choice == "rock" || player2Choice == "spock")
                    {
                        Console.WriteLine(player1.playerName + " wins this round!\n");
                        player1WinCounter++;
                    }
                    else if (player2Choice == "scissors" || player2Choice == "lizard")
                    {
                        Console.WriteLine(player2.playerName + " wins this round!\n");
                        player2WinCounter++;
                    }
                    else
                    {
                        Console.WriteLine("This round was a tie!\n");
                    }
                }
                if (player1Choice == "scissors")
                {
                    if (player2Choice == "paper" || player2Choice == "lizard")
                    {
                        Console.WriteLine(player1.playerName + " wins this round!\n");
                        player1WinCounter++;
                    }
                    else if (player2Choice == "rock" || player2Choice == "spock")
                    {
                        Console.WriteLine(player2.playerName + " wins this round!\n");
                        player2WinCounter++;
                    }
                    else
                    {
                        Console.WriteLine("This round was a tie!\n");
                    }
                }
                if (player1Choice == "lizard")
                {
                    if (player2Choice == "paper" || player2Choice == "spock")
                    {
                        Console.WriteLine(player1.playerName + " wins this round!\n");
                        player1WinCounter++;
                    }
                    else if (player2Choice == "scissors" || player2Choice == "rock")
                    {
                        Console.WriteLine(player2.playerName + " wins this round!\n");
                        player2WinCounter++;
                    }
                    else
                    {
                        Console.WriteLine("This round was a tie!\n");
                    }
                }
                if (player1Choice == "spock")
                {
                    if (player2Choice == "scissors" || player2Choice == "rock")
                    {
                        Console.WriteLine(player1.playerName + " wins this round!\n");
                        player1WinCounter++;
                    }
                    else if (player2Choice == "paper" || player2Choice == "lizard")
                    {
                        Console.WriteLine(player2.playerName + " wins this round!\n");
                        player2WinCounter++;
                    }
                    else
                    {
                        Console.WriteLine("This round was a tie!\n");
                    }
                }
                DisplayScore();
                Console.ReadLine();
            }
            DisplayWinner();
        }
        private void DisplayWinner()
        {
            if (player1WinCounter == winningThreshold)
            {
                Console.WriteLine(player1.playerName + " won the game!\n");
            }
            else if (player2WinCounter == winningThreshold)
            {
                Console.WriteLine(player2.playerName + " won the game!\n");
            }
            Console.WriteLine("Game over!");
            Console.ReadLine();
        }
        private void DisplayScore()
        {
            Console.WriteLine("\n" + player1.playerName + " has " + player1WinCounter + " wins. " + player2.playerName + " has " + player2WinCounter + " wins.");
        }
    }
}
