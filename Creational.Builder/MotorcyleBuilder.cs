namespace Creational.Builder
{
    public class MotorcyleBuilder : VehicleBuilder
    {
        public MotorcyleBuilder()
        {
            vehicle = new Vehicle("Motorcycle");
        }
        public override void BuildFrame()
        {
            vehicle["frame"] = "Motorcycle Frame";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "500 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }
    }
}