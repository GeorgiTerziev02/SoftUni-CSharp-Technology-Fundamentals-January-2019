using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_and_Subtract_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            AddAndSubtract(a, b, c);
        }
        static void AddAndSubtract(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine(firstNumber + secondNumber - thirdNumber);

        }

    }
}
