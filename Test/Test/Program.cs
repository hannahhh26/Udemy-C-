using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Grade { get; set; }

        public Student(int id, string name, int grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>
            {
                ["John"] = new Student(1, "John", 85),
                ["Alice"] = new Student(1, "Alice", 90),
                ["Bob"] = new Student(1, "Bob", 78)
            };

            foreach (var item in students)
            {
                Console.WriteLine($"Name: {item.Value.Name}, Id: {item.Value.Id}, " +
                    $"Grade: {item.Value.Grade}");
            }

            Console.ReadKey();
        }
    }
}
