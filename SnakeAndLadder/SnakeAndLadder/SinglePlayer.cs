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
        public void StartPlaying()
        {
            Console.WriteLine("Game Started! Good Luck "); 

            Console.WriteLine("Starting point is " + StartPoint); //Main Start Point
        }
    }
}
