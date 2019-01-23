using System;

namespace Creational.Factory
{
    /// <inheritdoc />
    /// <summary>
    /// Step 2 - Create concrete classes implementing the same interface
    /// </summary>
    public class Rectangle : IShape
    {
        public static readonly string ShapeName = "RECTANGLE";

        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
}