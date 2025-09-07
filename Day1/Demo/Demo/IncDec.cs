using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class IncDec
    {
        static void Main()
        {
            int x = 10;
            int y = x++ + ++x;
            Console.WriteLine(y);
        }
    }
}
