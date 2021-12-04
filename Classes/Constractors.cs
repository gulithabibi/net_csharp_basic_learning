using System;
using System.Collections.Generic;
using System.Text;

namespace netcore_csharp_basic_learning.Constractors
{
    /*
    A constructor is a special method that is used to initialize objects.The advantage of a constructor, 
    is that it is called when an object of a class is created.It can be used to set initial values for fields:
    */

    // Create a Car class
    class Car
    {
        public string model;  // Create a field

        // Create a class constructor for the Car class
        public Car()
        {
            model = "Mustang"; // Set the initial value for model
        }

        static void Main(string[] args)
        {
            Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford.model);  // Print the value of model
        }
    }

    // Outputs "Mustang"
}
