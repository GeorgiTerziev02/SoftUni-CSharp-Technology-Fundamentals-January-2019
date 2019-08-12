using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters_in_Range_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            PrintAllCharsBetween(a, b);
        }

        static void PrintAllCharsBetween(char start, char end)
        {
            int start_int = (int)start;
            int end_int = (int)end;
            if (start_int < end_int)
            {
                for (int i = start_int + 1; i < end_int; i++)
                {
                    char x = (char)i;
                    Console.Write("{0} ", x);
                }
            }
            else
            {

                for (int i = end_int + 1; i < start_int; i++)
                {
                    char x = (char)i;
                    Console.Write("{0} ", x);
                }
            }
        }
    }
}

