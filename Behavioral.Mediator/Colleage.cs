namespace Behavioral.Mediator
{
    public abstract class Colleage
    {
        protected Mediator Mediator;

        protected Colleage(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
}