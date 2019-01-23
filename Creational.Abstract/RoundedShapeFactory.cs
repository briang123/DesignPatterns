namespace Creational.AbstractFactory
{
    /// <inheritdoc />
    /// <summary>
    /// Step 4 - Create Factor classes extending AbstractFactory to generate object of
    /// concrete class based on given information
    /// </summary>
    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeName)
        {
            if (shapeName.ToUpper() == RoundedRectangle.ShapeName)
            {
                return new RoundedRectangle();
            }
            else if (shapeName.ToUpper() == RoundedSquare.ShapeName)
            {
                return new RoundedSquare();
            }

            return null;
        }
    }
}