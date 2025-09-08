using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  Perfect number (6 => 1, 2, 3   => 6) Perfect number 
/// </summary>
namespace ConsoleApp1
{
    internal class PerfectNbr
    {
        public void Show(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("Perfect Number...");
            }
            else
            {
                Console.WriteLine("Not Perfect Number...");
            }
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter N value  ");
            n = Convert.ToInt32(Console.ReadLine());
            PerfectNbr perfect = new PerfectNbr();
            perfect.Show(n);
        }
    }
}
