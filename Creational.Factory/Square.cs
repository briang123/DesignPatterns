using System;

namespace Creational.Factory
{
    /// <inheritdoc />
    /// <summary>
    /// Step 2 - Create concrete classes implementing the same interface
    /// </summary>
    public class Square : IShape
    {
        public static readonly string ShapeName = "SQUARE";

        public void Draw()
        {
            Console.WriteLine("Drawing a Square");
        }
    }
}