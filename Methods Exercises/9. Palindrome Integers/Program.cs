using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Integers_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            while (s != "END")
            {
                int num = int.Parse(s);
                if (IsPalindrom(num)) Console.WriteLine("true");
                else Console.WriteLine("false");
                s = Console.ReadLine();
            }
        }
        static bool IsPalindrom(int number)
        {
            int duplicate = number;
            int reversedNumber = 0;
            while (number != 0)
            {
                reversedNumber = reversedNumber * 10 + number % 10;
                number = number / 10;
            }
            if (duplicate == reversedNumber) return true;
            else return false;
        }
    }
}
