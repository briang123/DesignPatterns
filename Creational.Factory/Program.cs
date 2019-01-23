using System;

namespace Creational.Factory
{
    /// <summary>
    /// Step 4 - Use the Factory to get object of concrete class by passing
    /// information, such as type.
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            //get shape factory
            var shapeFactory = new ShapeFactory();

            //get an object of Shape Rectangle
            var rectangle = shapeFactory.GetShape(Rectangle.ShapeName);

            //call draw method of Shape Rectangle
            rectangle.Draw();

            //get an object of Shape Square
            var square = shapeFactory.GetShape(Square.ShapeName);

            //call draw method of Shape Square
            square.Draw();

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }
    }

}

