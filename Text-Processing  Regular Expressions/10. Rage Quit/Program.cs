using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var builder = new StringBuilder();
            //to collect the final result
            string pattern = @"([^0-9]+[0-9]+)";
            //pattern for matches
            MatchCollection matches = Regex.Matches(input, pattern);
            //collection
            foreach (Match match in matches)
            {
                string currentMatch = match.ToString();
                //takes the current match and divides it into text and number
                string patternText = @"([^0-9]+)";
                //pattern for the text
                var regText = Regex.Match(currentMatch, patternText);
                //dividing
                string text = regText.Groups[1].Value.ToString();
                //takes th e text part
                text = text.ToUpper();

                string patternNumber = @"([0-9]+)";
                //pattern for multiplier
                var regNumber = Regex.Match(currentMatch, patternNumber);
                //dividing
                int multiplier = int.Parse(regNumber.ToString());
                //takes the multiplier
                for (int i = 0; i < multiplier; i++)
                {
                    builder.Append(text);
                }
            }
            string unique = new String(builder.ToString().Distinct().ToArray());
            //makes an unique string from the builder
            Console.WriteLine($"Unique symbols used: {unique.Length}");
            Console.WriteLine($"{builder.ToString()}");
        }
    }
}