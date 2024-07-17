namespace CSharp.Concepts
{
    static class OperatorOverloadingProgram
    {
        static void Main(string[] args)
        {
            List<Customer> list = new List<Customer>();
            var c1 = new Customer() { WorkHours = 1, Name = "Anand" };
            var c2 = new Customer() { WorkHours = 2, Name = "Shabu" };
            var combinedCustomerWorkHours = c1 + c2;
            Console.WriteLine(combinedCustomerWorkHours);
        }
    }

    class Customer
    {
        public int WorkHours { get; set; }
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine("Customer WorkHours = {0}", WorkHours);
            Console.WriteLine("Customer Name = {0}", Name);
        }

        public static int operator +(Customer c1, Customer c2)
        {
            return c1.WorkHours + c2.WorkHours;
        }

    }

}