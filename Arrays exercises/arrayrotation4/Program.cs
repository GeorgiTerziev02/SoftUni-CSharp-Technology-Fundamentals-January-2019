using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayrotation4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = a[0];

                for (int j = 0; j < a.Length - 1; j++)

                { 
                    a[j] = a[j+1];
                }
                a[a.Length - 1] = x;
            }
            Console.WriteLine(String.Join(" ",a));
        }
    }
}
