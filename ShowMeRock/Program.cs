using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeRock
{
    class Program
    {
        static void Main(string[] args)
        //Choose player vs player or player vs computer (ask "how many players?" if 1, pvc. if 2, pvp.)
        //choose best of odd number of games
        //get player names
        //get player gestures from player 1
        //if PvP, give player 2 choice. if PvC, randomly generate option from array of choices
        //take player 1 choice and compare to second choice
        //add win counter to appropriate player, or tie and play another round with no win counted
        //determine if the game is won. if not, return to get player 1 gesture. if yes, print winner.
        //would you like to play again?


        // classes: Game, Player, Human, CPU
        //Human and CPU are children classes of the Player parent class
        //player can be abstract, and has: a gesture (string), a score (int), and a name (string)
        //player can do: choose gesture (abstract), choose name (abstract).
        //human player has input to decide gesture, computer gesture has to randomly generate gesture
            //human overrides choose gesture and choose name to read user input with a gesture = console.readline.
            //cpu overrides choose gesture and choose name with RNG and and name of my choice.
        //in GAME create two types of players. Player player1; and Player player2.
            //private methods and variables
            //method: int GetNumberOfPlayers()... ask how many players and give a readline. number of players = int.parse(readline), return number of players
            //method: setup player(int number of players)... if number of players == 1, player 1 == newHuman and player2 = newCPU
                //else player 1 == newHuman and player 2 == newHuman
        //to start the game in game
            //public void RunGame
                //int numberofplayers = getnumberofplayers
                //setupplayers(numberofplayers)
                //begin while loop here to ensure players are saved for this game and players get to pick new gestures each round
                //player1.choosegesture();
                //player2.choosegesture();
        {
            Game game = new Game();
            game.RunGame();
        }
    }
}
