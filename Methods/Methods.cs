using System;
using System.Collections.Generic;
using System.Text;

namespace netcore_csharp_basic_learning.Methods
{
    class Methods
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();
        }

        // I just got executed!
        // I just got executed!
        // I just got executed!
    }


}
