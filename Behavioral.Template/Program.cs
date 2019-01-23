using System;

namespace Behavioral.Template
{
    /// <summary>
    /// Step 3 - Use the Game's template method play to demonstrate a defined way of playing the game.
    /// </summary>
    internal class Program
    {
        private static void Main()
        {

            Game game = new Tennis();
            game.Play();

            game = new Soccer();
            game.Play();

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
