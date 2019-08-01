using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeRock
{
    class Computer : Player
    {
        public override string ChooseGesture()
        {
            Random random = new Random();
            List<string> gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("spock");
            int computerChoice = random.Next(gestures.Count);
            gesture = gestures[computerChoice];
            Console.WriteLine("");
            return gesture;
        }
        public override string ChooseName()
        {
            Console.WriteLine("The computer player is named Billy Bob");
            playerName = "Billy Bob";
            return playerName;
        }

    }
}
