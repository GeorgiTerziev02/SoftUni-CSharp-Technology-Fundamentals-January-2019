using System;
using System.Text.RegularExpressions;

namespace _08._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string input= Console.ReadLine();
            Regex numbers = new Regex(pattern);
            MatchCollection allNumbers = Regex.Matches(input, pattern);
            foreach (Match match in allNumbers)
            {
                Console.Write(match);
                Console.Write(" ");
            }
                        
        }
    }
}
