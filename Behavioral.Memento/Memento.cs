namespace Behavioral.Memento
{
    internal class Memento
    {
        public string State { get; }

        public Memento(string state)
        {
            State = state;
        }
    }
}