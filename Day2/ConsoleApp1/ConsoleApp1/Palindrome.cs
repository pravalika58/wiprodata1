using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Palindrome
    {
        public bool Check(string str)
        {
            char[] chars = str.ToCharArray();
            string rev = "";
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                rev += chars[i];
            }
            Console.WriteLine(rev);
            if (rev.Equals(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            string str = "liril";
            Palindrome obj = new Palindrome();
            Console.WriteLine(obj.Check(str));
        }
    }
}
