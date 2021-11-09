using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Program");
            SinglePlayer Player = new SinglePlayer();
            Player.StartPlaying();
            Console.ReadKey();
        }
    }
}
