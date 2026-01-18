namespace Dictionaries
{

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>
            {
                { "numbers", new List<int>{1, 2, 3 } }
            };

            foreach (int n in dict["numbers"])
            {
                Console.Write($"{n} ");
            }
            // Declaring and initailizing a dictionary 
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            employees.Add(1, new Employee("John Doe", 35, 100000));
            employees.Add(2, new Employee("Jane Doe", 30, 200000));
            employees.Add(3, new Employee("Jim Doe", 33, 300000));
            employees.Add(4, new Employee("Jimmy Doe", 31, 320000));

            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Key} named: {item.Value.Name} " +
                    $"earns {item.Value.Salary}" +
                    $" and is {item.Value.Age} years old!");
            }

            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas"
            };


            if(codes.TryGetValue("NY", out string state))
                {
                Console.WriteLine(state);
            }

            foreach (var item in codes)
            {
                Console.WriteLine($"The statecode is {item.Key} and the state " +
                    $"name is {item.Value}");
            }


            Console.ReadKey();

        }
    }
}
