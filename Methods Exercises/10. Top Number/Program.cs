using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Number_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            TopNumber18(num);

        }
        static void TopNumber18(int num)
        {
            for (int i = 1; i <= num; i++)
            { if (FindOddDigit(i) && SumOfDigits(i) % 8 == 0) Console.WriteLine(i); }
        }
        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            return sum;
        }
        static bool FindOddDigit(int num)
        {
            while (num != 0)
            {
                if ((num % 10) % 2 != 0) return true;
                num = num / 10;
            }
            return false;
        }
    }
}

