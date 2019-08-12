using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poke_Mon10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int poke = 0;
            int k = n;
            while(n>=m)
            {n = n - m;
                poke++;
                if (n == (k / 2))
                { if (y != 0) n = n / y;
                    else continue;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(poke);
        }
    }
}
