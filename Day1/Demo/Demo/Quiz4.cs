using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Quiz4
    {
        static void Main()
        {
            int x = 5;
            Console.WriteLine(++x); //6
            Console.WriteLine(x++); //6
            Console.WriteLine(--x); //6
            Console.WriteLine(x--); //6
            Console.WriteLine(x++ + ++x + ++x + x++);
            Console.WriteLine(x++ + x-- + --x + ++x + x++ + --x);

        }
    }
}
