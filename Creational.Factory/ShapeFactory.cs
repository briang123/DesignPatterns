namespace Creational.Factory
{
    /// <summary>
    /// Step 3 - Create Factory to generate object of concrete class based on given information
    /// </summary>
    public class ShapeFactory
    {
        public IShape GetShape(string shapeName)
        {
            if (shapeName.ToUpper() == Rectangle.ShapeName)
            {
                return new Rectangle();
            }
            else if (shapeName.ToUpper() == Square.ShapeName)
            {
                return new Square();
            }

            return null;
        }
    }
}