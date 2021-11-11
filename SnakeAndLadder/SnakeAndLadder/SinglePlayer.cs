using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class SinglePlayer
    {
        public const int NO_PLAY=0, SNAKE=1, LADDER=2, WINNING=100;
        public int StartPoint = 0;
        public int DiceRoll;
        int Option = 0;
        int count=0;
        public void StartPlaying()
        {
            while (this.StartPoint != 100)
            {
                count++;
            Random Random = new Random(); 
            DiceRoll = Random.Next(1 , 7); 
            
            Console.WriteLine("player Roll  Dice number is:" + " " + DiceRoll);
            Option = Random.Next(0, 3);  
            Console.WriteLine("option value:" + Option); 
            switch (Option) 
               {
                case NO_PLAY:                            
                    Console.WriteLine("No Play");
                    break;
                case SNAKE:                             
                    StartPoint -= DiceRoll;          
                    Console.WriteLine("Snake Attack:" + StartPoint);
                    break;
                case LADDER:                  
                    StartPoint += DiceRoll;
                    Console.WriteLine("Got Ladder:" + StartPoint);
                    break;
                default:
                    Console.WriteLine("Invalid Option");  
                    break;
               }
                if (StartPoint < 0)               
                {
                          StartPoint = 0;
                }
            }
            Console.WriteLine("Number of times Dice Roll " + count); 
            Console.WriteLine("congratulation");
	        Console.WriteLine("Game ended");
        }
    }
}