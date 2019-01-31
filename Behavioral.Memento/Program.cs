using System;

namespace Behavioral.Memento
{
    internal class Program
    {
        private static void Main()
        {
            var o = new Originator { State = "On" };

            // Store internal state
            var c = new Caretaker { Memento = o.CreateMemento() };

            // Continue changing originator
            o.State = "Off";

            // Restore saved state
            o.SetMemento(c.Memento);

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}