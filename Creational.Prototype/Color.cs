using System;

namespace Creational.Prototype
{
    class Color : ColorPrototype
    {
        private readonly int _red;
        private readonly int _green;
        private readonly int _blue;

        public Color(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        public override ColorPrototype Clone()
        {
            Console.WriteLine("Cloning color RGB: {0,3}, {1,3}, {2,3}",
                _red, _green, _blue);

            return MemberwiseClone() as ColorPrototype;
        }
    }
}