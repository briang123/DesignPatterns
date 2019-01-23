using System;

namespace Creational.AbstractFactory
{
    /// <inheritdoc />
    /// <summary>
    /// Step 2 - Create concrete classes implementing the same interface
    /// </summary>
    public class RoundedRectangle : IShape
    {
        public static readonly string ShapeName = "ROUNDEDRECTANGLE";

        public void Draw()
        {
            Console.WriteLine("Drawing a Rounded Rectangle.");
        }
    }
}