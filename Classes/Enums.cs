using System;
using System.Collections.Generic;
using System.Text;

namespace netcore_csharp_basic_learning.Enums
{
    //An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).


    class Program
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
        }
    }
}
