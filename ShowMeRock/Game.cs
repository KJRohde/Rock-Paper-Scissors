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
            winningThreshold = 3;
            player1WinCounter = 0;
            player2WinCounter = 0;
        }

        //methods (does)
        private void DisplayRules()
        {
            Console.WriteLine("Each player will choose rock, paper, scissors, lizard or spock, and their choices will be compared to see who wins each round.");
        }
        private int GetNumberOfPlayers()
        {
            Console.WriteLine("How many human players are present?");
            numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }
        private void setupPlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if (numberOfPlayers == 2)
            {
                player1 = new Human();
                player2 = new Human();
            }
        }
        public void RunGame()
        {
            DisplayRules();
            numberOfPlayers = GetNumberOfPlayers();
            setupPlayers(numberOfPlayers);
            while (player1WinCounter < winningThreshold && player2WinCounter < winningThreshold)
            {
                player1Choice = player1.ChooseGesture();
                player2Choice = player2.ChooseGesture();

                Console.WriteLine("\nPlayer 1 chose" + player1Choice);
                Console.WriteLine("Plyer 2 chose" + player2Choice);

                if (player1Choice == "rock")
                {
                    if (player2Choice == "scissors" || player2Choice == "lizard")
                    {
                        Console.WriteLine("Player 1 wins this round!\n");
                        player1WinCounter++;
                    }
                    else if (player2Choice == "paper" || player2Choice == "spock")
                    {
                        Console.WriteLine("Player 2 wins this round!\n");
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
                        Console.WriteLine("Player 1 wins this round!\n");
                        player1WinCounter++;
                    }
                    else if (player2Choice == "scissors" || player2Choice == "lizard")
                    {
                        Console.WriteLine("Player 2 wins this round!\n");
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
                        Console.WriteLine("Player 1 wins this round!\n");
                        player1WinCounter++;
                    }
                    else if (player2Choice == "rock" || player2Choice == "spock")
                    {
                        Console.WriteLine("Player 2 wins this round!\n");
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
                        Console.WriteLine("Player 1 wins this round!\n");
                        player1WinCounter++;
                    }
                    else if (player2Choice == "scissors" || player2Choice == "rock")
                    {
                        Console.WriteLine("Player 2 wins this round!\n");
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
                        Console.WriteLine("Player 1 wins this round!\n");
                        player1WinCounter++;
                    }
                    else if (player2Choice == "paper" || player2Choice == "lizard")
                    {
                        Console.WriteLine("Player 2 wins this round!\n");
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
                Console.WriteLine("Player 1 won the game!\n");
            }
            else if (player2WinCounter == winningThreshold)
            {
                Console.WriteLine("Player 2 won the game!\n");
            }
            Console.WriteLine("Game over!");
            Console.ReadLine();
        }
        private void DisplayScore()
        {
            Console.WriteLine("\n Player1 has " + player1WinCounter + " wins. Player2 has " + player2WinCounter + " wins.");
        }
    }
}
