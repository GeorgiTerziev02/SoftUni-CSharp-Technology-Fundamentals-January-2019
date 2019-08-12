using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace water_Overflow7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=0;i<n;i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (sum + liters > 255) { Console.WriteLine("Insufficient capacity!"); }
                else sum = sum + liters;
            }

            Console.WriteLine(sum);
        }
    }
}
