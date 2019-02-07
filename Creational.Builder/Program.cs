using System;

namespace Creational.Builder
{
    public class Program
    {
        private static void Main()
        {
            var shop = new Shop();

            VehicleBuilder builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorcyleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.Write(@"Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
