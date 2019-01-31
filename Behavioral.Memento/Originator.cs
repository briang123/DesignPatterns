using System;

namespace Behavioral.Memento
{
    internal class Originator
    {
        private string _state;

        public string State
        {
            get => _state;
            set
            {
                _state = value;
                Console.WriteLine("State = " + _state);
            }
        }

        // Creates memento 
        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        // Restores original state
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }
}