using System;

namespace Behavioral.Template
{
    /// <inheritdoc />
    /// <summary>
    /// Step 2 - Create concrete classes extending above class
    /// </summary>
    public class Tennis : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Tennis Game Finished!");
        }

        public override void Initialize()
        {
            Console.WriteLine("Tennis Game Initialized!");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Tennis Game Started!");
        }
    }
}