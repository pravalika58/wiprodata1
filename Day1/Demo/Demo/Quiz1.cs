using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Quiz1
    {
        static void Main()
        {
            Console.WriteLine("3" + 7 + 9); // 379
            Console.WriteLine("3" + (7 + 9)); // 716
            Console.WriteLine("3 + 7" + 9); // 3+79
        }
    }
}
