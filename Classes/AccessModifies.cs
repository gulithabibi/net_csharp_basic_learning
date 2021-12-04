using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    /*
        public	The code is accessible for all classes
        private	The code is only accessible within the same class
        protected	The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
        internal	The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter
     */
    class Car
    {
        private string model = "Mustang";
        public string model2 = "Mustang";
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model2); //output Mustang
            //Console.WriteLine(myObj.model);//'Car.model' is inaccessible due to its protection level, The field 'Car.model' is assigned but its value is never used
        }
    }
}
