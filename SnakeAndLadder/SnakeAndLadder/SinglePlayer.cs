using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SinglePlayer
    {
        public const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
        public int StartPoint = 0;
        public int DiceRoll;
        int Option = 0;
        public void StartPlaying()
        {
            Random Random = new Random();
            DiceRoll = Random.Next(1, 7);
            Console.WriteLine("player Roll  Dice number is:" + " " + DiceRoll);
            Option = Random.Next(0, 3);  
            Console.WriteLine("Dice value:" + Option); 
            switch (Option) 
            {
                case NO_PLAY:                            
                    Console.WriteLine("No Play");
                    break;
                case SNAKE:                             
                    StartPoint += DiceRoll;           
                    Console.WriteLine("Got Ladder:" + StartPoint);
                    break;
                case LADDER:                                 
                    StartPoint -= DiceRoll;              
                    Console.WriteLine("Snake Attack:" + StartPoint);
                    break;
                default:
                    Console.WriteLine("Invalid Option");  
                    break;
            }
        }
    }
}