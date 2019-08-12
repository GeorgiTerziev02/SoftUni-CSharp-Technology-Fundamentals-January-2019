using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Characters_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            MiddleCharacters(s);
        }

        static void MiddleCharacters(string s)
        {
            if (s.Length % 2 == 0)
            { Console.WriteLine("{0}{1}", s[(s.Length / 2) - 1], s[s.Length / 2]); }
            else Console.WriteLine(s[s.Length / 2]);
        }
    }
}