using System;
using System.Collections.Generic;
using System.Text;

namespace netcore_csharp_basic_learning.Interface
{
    /*
     *Another way to achieve abstraction in C#, is with interfaces.

    An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies):
     * */
    // Interface
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
        }
    }
}
