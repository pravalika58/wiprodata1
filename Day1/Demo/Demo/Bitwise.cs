using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Bitwise
    {
        static void Main()
        {
            int a = 4, b = 1;  // 4 - 100  1 - 001
            // 0 0 - 0
            // 0 1 - 0
            // 1 0 - 0 
            // 1 1 - 1
            // a & b - 000
            Console.WriteLine(a & b);
        }
    }
}