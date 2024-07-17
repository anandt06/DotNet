namespace CSharp.Concepts
{
    static class IndexerProgram
    {
        static void Main(string[] args)
        {
            // Create a list of customers
            EmployeeList employeeList = new EmployeeList();
            var c1 = new Employee() { WorkHours = 1, Name = "Anand" };
            var c2 = new Employee() { WorkHours = 2, Name = "Shabu" };

            employeeList.Add(c1);
            employeeList.Add(c2);

            // Use the indexer to get work hours by customer name
            Console.WriteLine("Work hours of Anand = {0}", employeeList["Anand"]);

            Console.WriteLine($"Work hours of Shabu: {employeeList["Shabu"]}");

            var a = employeeList[2.5];
        }
    }


    class EmployeeList
    {
        private List<Employee> Employees = new List<Employee>();

        // Method to add a customer to the list
        public void Add(Employee employee)
        {
            Employees.Add(employee);
        }

        // Indexer to get work hours by customer name
        public int this[string name]
        {
            get
            {
                foreach (var employee in Employees)
                {
                    if (employee.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        return employee.WorkHours;
                    }
                }
                throw new KeyNotFoundException($"employee with name '{name}' not found.");
            }
        }


        public string this[double index]
        {
            get { return "Anand"; }
        }
    }

    class Employee
    {
        public int WorkHours { get; set; }
        public string Name { get; set; }

    }
}