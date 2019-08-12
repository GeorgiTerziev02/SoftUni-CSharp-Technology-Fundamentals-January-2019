using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestNumber(a, b, c));
        }

        private static int SmallestNumber(int a, int b, int c)
        {
            if (a < b && a < c) return a;
            else if (b < a && b < c) return b;
            else return c;
        }
    }
}
