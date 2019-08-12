using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_sum8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] + a[j] == n) Console.WriteLine("{0} {1}",a[i],a[j]);
                }   
        }
    }
}
