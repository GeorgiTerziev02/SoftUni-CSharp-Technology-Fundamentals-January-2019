using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_part_of_the_ASCII_Table5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            for(int i=n;i<=m;i++)
            {
                Console.Write($"{(char)i} ");


            }

        }
    }
}
