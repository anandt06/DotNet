namespace CSharp.Concepts
{
    internal class LinqProgram
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            var p1 = new Person { Salary = 100, Car = "Ferrari", Name = "Anand" };
            var p2 = new Person { Salary = 72, Car = "BMW", Name = "Amru" };
            var p3 = new Person { Salary = 83, Car = "Audi", Name = "John" };
            var p4 = new Person { Salary = 104, Car = "Audi", Name = "Shabu" };

            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);

            var groupedAndOrdered = persons.GroupBy(p => p.Car)
            .Select(g => new
            {
                Car = g.Key,
                Persons = g.OrderBy(p => p.Salary).ToList()
            });

            var persons1 = persons.GroupBy(s => s.Car).OrderBy(q => q.Key);  //  no effect of orderby

            var peoples = persons.GroupBy(s => s.Car);

            var audiOwners = persons.GroupBy(p => p.Salary)
            .Select(g => new
            {
                PersonID = g.Key,    //Here Key will be the Column used for GroupBy
                Persons = g.ToList(),
            });

            var abc1  = persons.Distinct().ToList();

            var abc = persons.GroupBy(p => p.Car).Select(g => new { Car = g.Key, Persons = g.ToList() });

            // Sample list of employees
            List<Employee1> employees = new List<Employee1>
            {
                new Employee1 { Name = "Alice", Department = "HR", Age=1 },
                new Employee1 { Name = "Bob", Department = "IT", Age=2  },
                new Employee1 { Name = "Charlie", Department = "HR", Age=2  },
                new Employee1 { Name = "Dave", Department = "Finance", Age=1  },
                new Employee1 { Name = "Eve", Department = "IT", Age=1  }
            };

            // Group by department and then order by department name
            var groupedByDepartment = employees.GroupBy(e => e.Department).OrderBy(g => g.Key);

            var groupedByDepartmentThenByAge = employees.GroupBy(e => e.Department).OrderBy(g => g.Key).Select(g => new
            {
                Department = g.Key,
                Employees = g.OrderByDescending(e => e.Age) // Order employees within each group by age
            }).ToList();


            var emp = employees.OrderBy(s => s.Name).ToList().GroupBy(s => s.Age);

        }
    }

    class Person
    {
        internal int Salary { get; set; }
        internal string Car { get; set; }
        internal string Name { get; set; }
    }
    public class Employee1
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public int Age { get; set; }
    }
}
