using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strongnumer6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = n;
            int sum = 0;
            while(n!=0)
            {
                int p = n % 10;
                int q = 1;
                for(int i=1;i<=p;i++) { q = q * i; }
                sum = sum + q;
                n = n / 10;

            }
            if (sum == k) Console.WriteLine("yes");
            else Console.WriteLine("no");


        }
    }
}
