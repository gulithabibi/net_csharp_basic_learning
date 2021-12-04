using System;
using System.Collections.Generic;
using System.Text;

namespace netcore_csharp_basic_learning
{
    class Car2
    {
        // Class members
        public string model;  // Create a field
        string color = "red";       //field
        int maxSpeed = 200;         //field
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        // Create a class constructor for the Car class
        public Car2()
        {
            model = "Mustang";      // Set the initial value for model
        }
    }
}
