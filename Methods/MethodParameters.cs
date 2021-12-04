using System;
using System.Collections.Generic;
using System.Text;

namespace netcore_csharp_basic_learning.MethodParameter
{
    class MethodParameter
    {
        static int MyMethod(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(5, 3));
        }
    }

    // Outputs 8 (5 + 3)
}
