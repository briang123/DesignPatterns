namespace Behavioral.Interpreter
{
    internal interface IExpression
    {
        bool Interpret(string context);
    }
}