namespace Behavioral.Template
{
    /// <summary>
    /// Step 1 - Create an abstract class with a template method being final.
    /// </summary>
    public abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        //template method
        public void Play()
        {
            //initialize the game
            Initialize();

            //start the game
            StartPlay();

            //end the game
            EndPlay();
        }

    }
}