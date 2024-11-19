using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Car
    {
        // field
        //public static int NumberOfCars = 0;
        
        // member variable
        // private hides the variables from other classes
        //private string _model = "";
        //private string _brand = "";
        //private bool _isLuxury;

        // Property 

        //public string Model { get => _model; set => _model = value; } // With lambda expression
        
        //public string Model { get; set; }   

        /*
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        */

        
        //public string MyProperty { get; set; }

        //public bool IsLuxury { get; set; }

        /*
        public string Brand
        {
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
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered nothing");
                    _brand = "defaultValue";
                }
                else
                {
                    _brand = value;
                }
            }
        }
        
        public bool IsLuxury { get; set; }

        
        // Constructor
        public Car(string model, string brand, bool isLuxury)
        {
            NumberOfCars++;

            Model = model;
            Brand = brand;
            //_isLuxury = isLuxury;

            Console.WriteLine($"A {Brand} of the model {Model} has been created");
        }

        public Car()
        {
            NumberOfCars++;
        }

        public void Drive()
        {
            Console.WriteLine($"I'm a {Model} and I'm driving");
        }
        */
    }
}
