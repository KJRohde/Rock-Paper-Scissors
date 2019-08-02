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
            Console.WriteLine("Rock crushes scissors\nScissors cuts paper\nPaper covers rock\nRock crushes lizard\nPaper disproves spock\nLizard eats paper\nSpock crushes scissors\nScissors decapitates lizard\nLizard poisons spock\nSpock vaporizes rock\nAnd whatever you do... DO NOT THROW FLAMINGO");
        }
        private int GetNumberOfPlayers()
        {
            Console.WriteLine("\nHow many human players are present?");
            while (int.TryParse(Console.ReadLine(), out numberOfPlayers) && numberOfPlayers > 2 || numberOfPlayers < 1)
            {
                Console.WriteLine("This game is for a maximum of 2 players and minimum of 1 player. Please enter the number 1 or 2.");
            }
            return numberOfPlayers;
        }
        private void setupPlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                player1 = new Human();
                player1.ChooseName();
                Console.WriteLine("Player 1 chose to be called " + player1.playerName + ".");
                player2 = new Computer();
                player2.ChooseName();
            }
            else if (numberOfPlayers == 2)
            {
                player1 = new Human();
                player1.ChooseName();
                Console.WriteLine("Player 1 chose to be called " + player1.playerName + ".");
                player2 = new Human();
                player2.ChooseName();
                if (player1.playerName == player2.playerName)
                {
                    Console.WriteLine("Please enter a name for player 2 that is different from player 1!");
                    player2.ChooseName();
                }
                Console.WriteLine("Player 2 chose to be called " + player2.playerName + ".");
            }
        }
        private int GetNumberOfGames()
        {
            Console.WriteLine("\nHow many round victories will this contest take to win?\nThe maximum number of wins required is 10.");
            while (int.TryParse(Console.ReadLine(), out winningThreshold) && winningThreshold >= 10 || winningThreshold < 1)
            {
                Console.WriteLine("The maximum number of games to win is 10.");
            }
            return winningThreshold;
        }
        public void RunGame()
        {
            DisplayRules();
            numberOfPlayers = GetNumberOfPlayers();
            setupPlayers(numberOfPlayers);
            GetNumberOfGames();
            Console.Clear();
            while (player1WinCounter < winningThreshold && player2WinCounter < winningThreshold)
            {
                Console.WriteLine("It is now " + player1.playerName + "'s turn.");
                player1Choice = player1.ChooseGesture();
                Console.Clear();
                Console.WriteLine("It is now " + player2.playerName + "'s turn.");
                player2Choice = player2.ChooseGesture();
                Console.Clear();

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
                    else if (player1Choice == player2Choice)
                    {
                        Console.WriteLine("This round was a tie!\n");
                    }
                    else
                    {
                        Console.WriteLine("Somebody entered an incorrect gesture. This round may not assign a win");
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
                    else if (player1Choice == player2Choice)
                    {
                        Console.WriteLine("This round was a tie!\n");
                    }
                    else
                    {
                        Console.WriteLine("Somebody entered an incorrect gesture. This round may not assign a win");
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
                    else if (player1Choice == player2Choice)
                    {
                        Console.WriteLine("This round was a tie!\n");
                    }
                    else
                    {
                        Console.WriteLine("Somebody entered an incorrect gesture. This round may not assign a win");
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
                    else if (player1Choice == player2Choice)
                    {
                        Console.WriteLine("This round was a tie!\n");
                    }
                    else
                    {
                        Console.WriteLine("Somebody entered an incorrect gesture. This round may not assign a win");
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
                    else if (player1Choice == player2Choice)
                    {
                        Console.WriteLine("This round was a tie!\n");
                    }
                    else
                    {
                        Console.WriteLine("Somebody entered an incorrect gesture. This round may not assign a win.");
                    }
                }
                if (player1Choice == "flamingo" && player2Choice != "flamingo")
                    {
                        player1WinCounter = 0;
                        player2WinCounter = winningThreshold;
                    }
                if (player2Choice == "flamingo" && player1Choice != "flamingo")
                    {
                        player2WinCounter = 0;
                        player1WinCounter = winningThreshold;
                    }
                if (player1Choice == "flamingo" && player2Choice == "flamingo")
                {
                    player1WinCounter = 0;
                    player2WinCounter = 0;
                    Console.WriteLine("Neither one of you deserve to win...\ntry again and play the damn game.");
                    Console.ReadLine();
                    break;
                }
                DisplayScore();
                Console.ReadLine();
                Console.Clear();
            }
            DisplayWinner();
        }
        private void DisplayWinner()
        {
            if (player1WinCounter == winningThreshold)
            {
                Console.WriteLine(player1.playerName + " won the game!\nNice try " + player2.playerName + "!");
            }
            else if (player2WinCounter == winningThreshold)
            {
                Console.WriteLine(player2.playerName + " won the game!\nNice try " + player1.playerName + "!");
            }
            else
            {
                Console.WriteLine("You were warned.");
            }
            Console.WriteLine("Game over!");
            Console.ReadLine();
        }
        private void DisplayScore()
        {
            Console.WriteLine("\nIn this best of " + (2*(winningThreshold) - 1) + " contest, " + player1.playerName + " has " + player1WinCounter + " wins. " + player2.playerName + " has " + player2WinCounter + " wins.");
        }
    }
}
