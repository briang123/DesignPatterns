namespace Creational.AbstractFactory
{
    /// <summary>
    /// Step 3 - Create an Abstract class to get factories for Normal and Rounded Shape objects
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shapeName);
    }
}