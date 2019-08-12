using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prinandsum4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = n; i <= m; i++) { sum = sum + i; Console.Write("{0} ",i);if (i == m) Console.WriteLine(""); }
            Console.WriteLine("Sum: {0}",sum);

            


        }
    }
}
