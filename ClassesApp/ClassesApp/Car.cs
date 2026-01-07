using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Car
    {
        public static int NumberOfCars;

        // member variable
        // private hides the variable from other classes
        // Backing Field of the Model property
        private string _brand = "";

        // Property
        public string Model { get; set; }
        public string Brand { 
            get
            {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {  
                    return _brand;
                }
            }

            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING");
                    _brand = "DEFAULTVALUE";
                }
                else
                {
                    _brand = value;
                }
                _brand = value; }
        }

        public bool IsLuxury { get; set; }

        // Constructor
        public Car(string model, string brand, bool isLuxury) 
        {
            NumberOfCars++;

            Model = model;
            Brand = brand;
            Console.WriteLine($"An {Brand} of model {Model} has been created!");
            IsLuxury = isLuxury;
        }

        public void Drive()
        {
            Console.WriteLine("I'm driving");
        }
    }
}
