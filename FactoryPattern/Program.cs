namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires should your vehicle have, 2 or 16?");
            string vehicleType = Console.ReadLine();
            
            IVehicle vehicle = VehicleFactory.GetVehicle(vehicleType);
            vehicle.Drive();
            Console.WriteLine();
               
        }
    }
}
