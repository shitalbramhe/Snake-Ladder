using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SinglePlayer
    {
        public int StartPoint = 0;
        public int DiceRoll;
        public void StartPlaying()
        {
            Random Random = new Random(); 
            DiceRoll = Random.Next(1 , 7); 
            Console.WriteLine("player Roll  Dice number is:" + " " + DiceRoll);
        }
    }
}
