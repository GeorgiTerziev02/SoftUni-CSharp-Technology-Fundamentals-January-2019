using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Division_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double fact1 = factorial(num1);
            double fact2 = factorial(num2);
            Console.WriteLine("{0:f2}", fact1 / fact2);
        }

        static double factorial(int num)
        {
            double sum = 1;
            for (int i = 1; i <= num; i++) sum = sum * i;
            return sum;
        }
    }
}
