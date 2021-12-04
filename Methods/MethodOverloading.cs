using System;
using System.Collections.Generic;
using System.Text;

namespace netcore_csharp_basic_learning.MethodOverloding
{
    public class MethodOverloding
    {
        With method overloading, multiple methods can have the same name with different parameters:
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

    }
}
