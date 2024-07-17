namespace CSharp
{
    static class FactoryProgram
    {
        static void Main(string[] args)
        {
            //RewardFactory.GetReward("Gold");

            var goldCustomer = RewardFactory.GetReward("Gold");
            var silverCustomer = RewardFactory.GetReward("Silver");

            //RewardFactory.RegisterCustomerType("Bronze", typeof(Bronze)); // We can use this to register new req in future
            //var bronzeCustomer = RewardFactory.GetReward("Bronze");
        }
    }

    public interface ICustomer
    {
        public int RewardPoints { get; set; }

        public string CustomerType { get; set; }

        public void Display();

    }

    class SilverCustomer : ICustomer
    {
        public int RewardPoints { get; set; }

        public string CustomerType { get; set; }

        public SilverCustomer()
        {
            RewardPoints = 100;
            CustomerType = "Silver";
        }
        public void Display()
        {
            Console.WriteLine("Reward Point = {0}", RewardPoints);
        }

    }
    class GoldCustomer : ICustomer
    {
        public int RewardPoints { get; set; }

        public string CustomerType { get; set; }

        public GoldCustomer()
        {
            RewardPoints = 100;
            CustomerType = "Gold";
        }
        public void Display()
        {
            Console.WriteLine("Reward Point = {0}", RewardPoints);
        }
    }

    class RewardFactory
    {
        public static ICustomer GetReward(string type)
        {
            ICustomer customer = null!;
            if (type == "Gold")
            {
                customer = new GoldCustomer();
            }
            else if (type == "Silver")
            {
                customer = new SilverCustomer();
            }

            customer.Display();

            return customer;
        }

    }

    public static class RewardFactoryWithoutIf
    {
        private static readonly Dictionary<string, Type> customerTypes = new Dictionary<string, Type>();

        static RewardFactoryWithoutIf()
        {
            RegisterCustomerType("Gold", typeof(GoldCustomer));
            RegisterCustomerType("Silver", typeof(SilverCustomer));
        }

        public static void RegisterCustomerType(string key, Type type)
        {
            if (!typeof(ICustomer).IsAssignableFrom(type))
            {
                throw new ArgumentException("Type must implement ICustomer interface");
            }
            customerTypes[key] = type;
        }

        public static ICustomer GetReward(string type)
        {
            if (!customerTypes.ContainsKey(type))
            {
                throw new KeyNotFoundException($"Customer type '{type}' not registered.");
            }

            var customer = (ICustomer)Activator.CreateInstance(customerTypes[type])!;
            customer.Display();
            return customer;
        }
    }
}