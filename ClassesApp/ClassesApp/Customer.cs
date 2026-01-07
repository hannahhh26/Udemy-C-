using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Customer
    {
        // Static field to hold the next ID available
        private static int nextId = 0;

        private readonly int _id;

        // Backing field for write-only property
        private string _password;

        // Write only property
        public string Password
        {
            set
            {
                _password = value;
            }
        }

        // Read only Property
        public int ID { get
            {  return _id; }
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default Constructor
        public Customer()
        {
            _id = nextId++;
            Name = "Default";
            Address = "Default";
            ContactNumber = "Default";
        }

        // Custom Constructor
        public Customer(string name, string address, string contactnumber)
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactnumber;
        }

        public Customer(string name)
        {
            _id = nextId++; 
            Name = name;
        }

        public void SetDetails(string name, string address, string contactnumber = "N/A")
        {
            Name = name;
            Address = address;
            ContactNumber = contactnumber;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Details aboout customer: Name is {Name} and ID is {_id}");
        }
    }
}
