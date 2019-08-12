using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalsums6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool b = false;
            for(int i=0;i<a.Length;i++)
            {
                int sumleft = 0;
                int sumright = 0;
                if (i == 0) sumleft = 0;
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        sumleft = sumleft + a[j];
                    }
                }
                    if (i == a.Length) sumleft = 0;
                else
                {
                    for (int j = i+1; j < a.Length; j++)
                    {
                        sumright = sumright + a[j];
                    }
                }
                if (sumright == sumleft) { Console.WriteLine(i); b = true; }
            }
            if(b==false)
                Console.WriteLine("no");
        }
    }
}
