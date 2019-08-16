using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _5.__Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number1 = BigInteger.Parse(Console.ReadLine());
            int multiplyNumber = int.Parse(Console.ReadLine());
            number1 = number1 * multiplyNumber;
            Console.WriteLine(number1);
        }
    }
}
