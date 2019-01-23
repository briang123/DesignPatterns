using System;

namespace Behavioral.Template
{
    /// <inheritdoc />
    /// <summary>
    /// Step 2 - Create concrete classes extending above class
    /// </summary>
    public class Soccer : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Soccer Game Finished!");
        }

        public override void Initialize()
        {
            Console.WriteLine("Soccer Game Initialized!");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Soccer Game Started!");
        }
    }
}