using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeRock
{
    class Human : Player
    {
        //private static void DeletePrevConsoleLine()
        //{
        //    if (Console.CursorTop == 0) return;
        //    Console.SetCursorPosition(0, Console.CursorTop - 1);
        //    Console.Write(new string(' ', Console.WindowWidth));
        //    Console.SetCursorPosition(0, Console.CursorTop - 1);
        //}
        public override string ChooseGesture()
        {
            Console.WriteLine("Please choose rock, paper, scissors, lizard, or spock");
            gesture = Console.ReadLine();
            return gesture.ToLower();
        }
        public override string ChooseName()
        {
            Console.WriteLine("Please enter a name for your player");
            playerName = Console.ReadLine();
            return playerName;
        }
    }
}
