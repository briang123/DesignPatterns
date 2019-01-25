using System;

namespace Behavioral.Observer
{
    internal class Program
    {
        private static void Main()
        {
            //Configure the Observer pattern
            var subject = new ConcreteSubject();

            subject.Attach(new ConcreteObserver(subject, "X"));
            subject.Attach(new ConcreteObserver(subject, "Y"));
            subject.Attach(new ConcreteObserver(subject, "Z"));

            //Change subject and notify observers
            subject.SubjectState = "ABC";
            subject.Notify();

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}