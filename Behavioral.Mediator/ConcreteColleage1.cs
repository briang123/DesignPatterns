using System;

namespace Behavioral.Mediator
{
    internal class ConcreteColleage1 : Colleage
    {
        public ConcreteColleage1(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleage1 gets message: {0}", message);
        }
    }
}