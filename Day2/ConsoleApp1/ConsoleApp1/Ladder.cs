using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ladder
    {
        public void Show(int choice)
        {
            if (choice == 1)
            {
                Console.WriteLine("Hi I am Pravalika...");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Hi I am Bunny...");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Hi I am Navaneetha...");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Hi am Sunitha...");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }
}
