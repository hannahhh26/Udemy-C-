using System.ComponentModel.DataAnnotations;

namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog myDog = new Dog();
            //myDog.MakeSound();
            //myDog.Eat();

            Employee joe = new Employee("Joe", 36, "Sales Rep", 2345);
            joe.DisplayPersonInfo();
            Console.ReadKey();

            Manager carl = new Manager("Carl", 34, "Manager", 2345, 4);
        }
    }

    // Base Class (Parent class or Superclass)
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound");
        }
    }

    // Derived Class (Child or Subclass)
    class Dog: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Barking...");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow...");
        }
    }

    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        // Base class constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person called");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    public class Employee : Person
    {
        public string JobTitle { get; private set; }
        public int EmployeeID { get; private set; }

        public Employee(string name, int age, string jobTitle, int employeeID) : base(name, age)
        {
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            Console.WriteLine("Employee called");
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; private set; }

        public Manager(string name, int age, string jobTitle, int employeeID, int teamSize) 
            : base(name, age, jobTitle, employeeID)
        {
            TeamSize = teamSize;
        }

        public void DisplayManagerInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }
}
