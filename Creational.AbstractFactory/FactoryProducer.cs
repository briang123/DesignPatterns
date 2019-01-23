namespace Creational.AbstractFactory
{
    /// <summary>
    /// Step 5 - Create a Factory generator/producer class to get factories by passing
    /// information, such as Shape
    /// </summary>
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(bool rounded)
        {
            if (rounded)
                return new RoundedShapeFactory();

            return new ShapeFactory();
        }
    }
}