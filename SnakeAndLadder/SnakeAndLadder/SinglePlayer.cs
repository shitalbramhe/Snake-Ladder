using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SinglePlayer
    {
        public const int NO_PLAY=0, SNAKE=1, LADDER=2;
        public int StartPoint = 0;
        public int DiceRoll;
        public int ComputerChoice;
        int Option = 0;
        public void StartPlaying()
        {
            Random Random = new Random(); 
            DiceRoll = Random.Next(1 , 7); 
            Console.WriteLine("player Roll  Dice number is:" + " " + DiceRoll);
            Option = Random.Next(0, 3);  //Choice to check its snake or ladder
            Console.WriteLine("Dice value:" + Option); // taking input Choice
            switch (Option) //Switch Case 
            {
                case NO_PLAY:                            // if ComputerChoice = 0
                    Console.WriteLine("No Play");
                    break;
                case SNAKE:                             // if ComputerChoice = 1
                    StartPoint += DiceRoll;            //  StartPoint = StartPoint+RandDice
                    Console.WriteLine("Got Ladder:" + StartPoint);
                    break;
                case LADDER:                                  // if ComputerChoice = 2
                    StartPoint -= DiceRoll;              //  StartPoint = StartPoint-RandDice
                    Console.WriteLine("Snake Attack:" + StartPoint);
                    break;
                default:
                    Console.WriteLine("Invalid Option");  //If other than 0 to 2
                    break;
            }
        }
    }
}
