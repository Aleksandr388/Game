using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            IGame game =  new Game();
            game.CreateGame();
        }
    }
}