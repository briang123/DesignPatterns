namespace Behavioral.Strategy
{
    /// <inheritdoc />
    /// <summary>
    /// Step 2 - Create concrete classes implementing the same interface
    /// </summary>
    public class OperationDivide : IStrategy
    {
        public int DoOperation(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}