using System;

namespace Creational.AbstractFactory
{
    /// <summary>
    /// Step 6 - Use the FactoryProducer to get AbstractFactory in order to get factories of
    /// concrete classes by passing information, such as type
    /// https://www.tutorialspoint.com/design_pattern/abstract_factory_pattern.htm
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            //get shape factory
            var shapeFactory = FactoryProducer.GetFactory(false);

            //get an object of Shape Rectangle
            var rectangle = shapeFactory.GetShape(Rectangle.ShapeName);

            //call draw method of Shape Rectangle
            rectangle.Draw();

            //get an object of Shape Square
            var square = shapeFactory.GetShape(Square.ShapeName);

            //call draw method of Shape Square
            square.Draw();

            //-----
            //get rounded shape factory
            shapeFactory = FactoryProducer.GetFactory(true);

            //get an object of Shape Rectangle
            var roundedRectangle = shapeFactory.GetShape(RoundedRectangle.ShapeName);

            //call draw method of Shape Rectangle
            roundedRectangle.Draw();

            //get an object of Shape Square
            var roundedSquare = shapeFactory.GetShape(RoundedSquare.ShapeName);

            //call draw method of Shape Square
            roundedSquare.Draw();

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }
    }

}

