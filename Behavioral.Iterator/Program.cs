using System;
using System.Collections.Generic;

namespace Behavioral.Iterator
{
    public class NameRepository : IContainer
    {
        public List<string> Names;

        public IIterator GetIterator()
        {
            return new NameIterator(Names);
        }

        private class NameIterator : IIterator
        {
            private readonly List<string> _names;
            private int _index;

            public NameIterator(List<string> names)
            {
                _names = names;
            }

            public bool HasNext()
            {
                return _index < _names.Count;
            }

            public object Next()
            {
                return HasNext() ? _names[_index++] : null;
            }
        }
    }

    internal class Program
    {
        private static void Main()
        {
            var namesRepository = new NameRepository
            {
                Names = new List<string> { "Robert", "John", "Julie", "Lora" }
            };

            for (var iter = namesRepository.GetIterator(); iter.HasNext();)
            {
                var name = (string)iter.Next();
                Console.WriteLine("Name: {0}", name);
            }

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}