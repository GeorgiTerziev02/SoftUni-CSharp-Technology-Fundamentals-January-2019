using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            string firstWord = input[0];
            string secondWord = input[1];

            string longerWord = string.Empty;
            string shorterWord = string.Empty;
            int sum = 0;

            if (firstWord.Length>=secondWord.Length)
            {
                longerWord = firstWord;
                shorterWord=secondWord;
            }
            else
            {
                longerWord = secondWord;
                shorterWord = firstWord;
            }

            for (int i = 0; i < shorterWord.Length; i++)
            {
                sum = sum + shorterWord[i] * longerWord[i];
            }
            for (int i = shorterWord.Length; i < longerWord.Length; i++)
            {
                sum = sum + longerWord[i];
            }
            Console.WriteLine(sum);

        }
    }
}
