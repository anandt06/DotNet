namespace CSharp.DesignPatterns
{
    internal class FactoryDesignPattern
    {
        static void Main(string[] args)
        {
            string vehicleType = "two wheeler";
            IVehicle vehicle = VehicleFactory.GetVehicleType(vehicleType);
        }
    }

    public interface IVehicle
    {
        string VehicleType();

        int GetNumberOfWheels();
    }

    public class Bike : IVehicle
    {
        public string VehicleType()
        {
            return "Two Wheeler";
        }

        public int GetNumberOfWheels()
        {
            return 2;
        }
    }

    public class Auto : IVehicle
    {
        public string VehicleType()
        {
            return "Three Wheeler";
        }

        public int GetNumberOfWheels()
        {
            return 3;
        }
    }

    class Car : IVehicle
    {
        public string VehicleType()
        {
            return "Four Wheeler";
        }

        public int GetNumberOfWheels()
        {
            return 4;
        }
    }

    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string type)
        {

            IVehicle vehicle = null;

            if (type.ToLower() == "two wheeler")
            {
                vehicle = new Bike();
            }
            else if (type.ToLower() == "four wheeler")
            {
                vehicle = new Car();
            }
            else if (type.ToLower() == "three wheeler")
            {
                vehicle = new Auto();
            }
            return vehicle;
        }

        private static readonly Dictionary<string, Func<IVehicle>> vehicleDictionary = new Dictionary<string, Func<IVehicle>>(StringComparer.OrdinalIgnoreCase)
        {
            { "two wheeler", () => new Bike() },
            { "three wheeler", () => new Auto() },
            { "four wheeler", () => new Car() }
        };

        public static IVehicle GetVehicleType(string type)
        {
            if (vehicleDictionary.TryGetValue(type, out var createVehicle))
            {
                return createVehicle();
            }

            return null;

            //Type vehicleType = Type.GetType(type);
            //if (vehicleType != null && typeof(IVehicle).IsAssignableFrom(vehicleType))
            //{
            //    // Create an instance of the type
            //    return (IVehicle)Activator.CreateInstance(vehicleType);
            //}
        }
    }


}
