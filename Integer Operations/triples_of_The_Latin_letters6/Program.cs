using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triples_of_The_Latin_letters6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=97;i<=96+n;i++)
                for (int j=97;j<=96+n;j++)
                    for (int k=97;k<=96+n;k++)
                    { Console.WriteLine($"{(char)i}{(char)j}{(char)k}"); }

        }
    }
}
