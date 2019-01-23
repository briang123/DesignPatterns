using System;

namespace Structural.Facade
{
    /// <inheritdoc />
    /// <summary>
    /// Step 2 - Create concrete classes implementing the same interface
    /// </summary>
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Square");
        }
    }
}