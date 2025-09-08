using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class StrDemo
    {
        static void Main()
        {
            string s1 = "Pravalika", s2 = "bunny", s3 = "Navaneetha";
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());
        }
    }
}