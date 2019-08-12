using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            { num[i] = int.Parse(Console.ReadLine()); sum = sum + num[i]; }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ",num[i]);
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
