using System;

namespace Structural.Facade
{
    /// <summary>
    /// Step 4 - Use the facade to draw various types of shapes
    /// </summary>
    internal class Program
    {
        private static void Main()
        {

            var shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}