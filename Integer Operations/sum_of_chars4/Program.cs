using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_chars4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=0;i<n;i++)
            {
                int u = 0;
                char k =char.Parse(Console.ReadLine());
                u = (int)k;
                sum = sum + u;
            }
            Console.WriteLine("The sum equals: {0}",sum);




        }
    }
}
