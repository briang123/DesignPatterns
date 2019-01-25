using System;

namespace Behavioral.Mediator
{
    internal class ConcreteColleage2 : Colleage
    {
        public ConcreteColleage2(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleage2 gets message: {0}", message);
        }
    }
}