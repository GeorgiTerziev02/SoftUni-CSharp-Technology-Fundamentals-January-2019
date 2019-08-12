using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_digits2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int a = int.Parse(Console.ReadLine());
            int k = 0;
            while (a!=0)
            { k = k + a % 10;
                a = a / 10;
            }
            Console.WriteLine(k);
        }
    }
}
