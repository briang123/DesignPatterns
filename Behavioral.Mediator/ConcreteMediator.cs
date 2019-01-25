namespace Behavioral.Mediator
{
    internal class ConcreteMediator : Mediator
    {
        private ConcreteColleage1 _colleage1;
        private ConcreteColleage2 _colleage2;

        public ConcreteColleage1 Colleage1
        {
            set => _colleage1 = value;
        }

        public ConcreteColleage2 Colleage2
        {
            set => _colleage2 = value;
        }


        public override void Send(string message, Colleage colleage)
        {
            if (colleage == _colleage1)
                _colleage2.Notify(message);
            else
                _colleage1.Notify(message);
        }
    }
}