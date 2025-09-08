using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CelToFah
    {
        public double ConvertToFahrenehit(double celcius)
        {
            double f = ((9 * celcius) / 5) + 32;
            return f;
        }
        static void Main()
        {
            double celsius;
            Console.WriteLine("Enter Celsius Value  ");
            celsius = Convert.ToDouble(Console.ReadLine());
            CelToFah obj = new CelToFah();
            Console.WriteLine("Fahrenheit Value is  " + obj.ConvertToFahrenehit(celsius));
        }
    }
}
