using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_sequence_of_Equal_Elements7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxrow = 1;
            int number = a[0];
            int row = 1;
            for(int i=0;i<a.Length-1;i++)
            { if(a[i]==a[i+1])
                {
                    row++;
                   
                }
                else { row = 1; }
                if (maxrow < row) { maxrow = row; number = a[i]; }
            }
            for(int i=0;i<maxrow;i++)
            { Console.Write("{0} ",number); }
        }
    }
}
