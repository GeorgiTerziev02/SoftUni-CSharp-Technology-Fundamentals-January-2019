using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _11._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string currentString = input[i];
                char firstLetter = currentString[0];
                char lastLetter = currentString[currentString.Length - 1];

                var matches = Regex.Matches(currentString, @"[0-9]+");
                double currentNum = 0;
                foreach (var match in matches)
                {
                    currentNum = double.Parse(match.ToString());
                }

                if (char.IsLower(firstLetter))
                {
                    int abcPosition = (int)(firstLetter - 96);
                    currentNum = currentNum * abcPosition;
                }
                else
                {
                    int abcPosition = (int)(firstLetter - 64);
                    if(abcPosition!=0) currentNum = currentNum / abcPosition;
                }
                if (char.IsLower(lastLetter))
                {
                    int abcPosition = (int)(lastLetter - 96);
                    currentNum = currentNum + abcPosition;
                }
                else
                {
                    int abcPosition = (int)(lastLetter - 64);
                    currentNum = currentNum - abcPosition;
                }

                sum = sum + currentNum;

            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
