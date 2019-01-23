using System;

namespace Creational.AbstractFactory
{
    /// <inheritdoc />
    /// <summary>
    /// Step 2 - Create concrete classes implementing the same interface
    /// </summary>
    public class RoundedSquare : IShape
    {
        public static readonly string ShapeName = "ROUNDEDSQUARE";

        public void Draw()
        {
            Console.WriteLine("Drawing a Rounded Square.");
        }
    }
}