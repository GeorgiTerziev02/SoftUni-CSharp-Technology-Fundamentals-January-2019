using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zig_zag3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            
            for(int j=0;j<n;j++)
            {
                string s = Console.ReadLine();
                int[] input = s.Split().Select(int.Parse).ToArray();
                if (j%2==0)
                { a[j] = input[0];
                    b[j] = input[1];
                }
                else if(j%2!=0)
                { a[j] = input[1];
                    b[j] = input[0];
                }   
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", b[i]);
            }
        }
    }
}
