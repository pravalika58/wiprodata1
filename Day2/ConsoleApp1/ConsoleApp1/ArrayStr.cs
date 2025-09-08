using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArrayStr
    {
        public void Show()
        {
            string[] names = new string[]
            {
                "Pravalika","Navaneetha","Pranith","Bunny","Chitti"
            };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
        static void Main()
        {
            ArrayStr arrayStr = new ArrayStr();
            arrayStr.Show();
        }
    }
}
