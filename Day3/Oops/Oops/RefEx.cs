using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class RefEx
    {
        public void Calc(int n, ref int f)
        {

            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
        }
        static void Main()
        {
            int n, f = 1;
            Console.WriteLine("Enter N value   ");
            n = Convert.ToInt32(Console.ReadLine());
            RefEx obj = new RefEx();
            obj.Calc(n, ref f);
            Console.WriteLine("Factorial Value  " + f);
        }
    }
}
