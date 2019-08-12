using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Count_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower();
            CountVowel(s);
            Console.WriteLine(CountVowel(s));
        }

        private static int CountVowel(string s)
        {
            int br = 0;
            for (int i = 0; i < s.Length; i++)
            { if (s[i] == 'a' || s[i] == 'u' || s[i] == 'i' || s[i] == 'e' || s[i] == 'o') br++; }
            return br;
        }
    }
}
