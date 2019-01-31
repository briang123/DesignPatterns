# Memento Pattern

https://www.dofactory.com/net/memento-design-pattern

Without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later.

# Implementation

```c#
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

internal class Memento
{
    public string State { get; }

    public Memento(string state)
    {
        State = state;
    }
}

internal class Caretaker
{
    public Memento Memento { set; get; }
}
```

The results of running this design pattern is...
```console
State = On
State = Off
Restoring state...
State = On
Press any key to continue...
```