using System;

namespace Addikins.BasicRpg
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello Hero!");

            var game = new Game();
            game.Start();
        }
    }
}
