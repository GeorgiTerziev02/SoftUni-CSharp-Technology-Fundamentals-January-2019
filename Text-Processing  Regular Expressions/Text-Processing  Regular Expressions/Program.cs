using System;
using System.Collections.Generic;
using System.Linq;

namespace Text_Processing__Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split(", ").ToArray();   
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                bool isValid = false;
                if (currentWord.Length <= 16 && currentWord.Length >= 3)
                {
                    for (int j = 0; j < currentWord.Length; j++)
                    {
                        char currentCharacter = currentWord[j];
                        if (char.IsLetterOrDigit(currentCharacter)||currentCharacter=='-'||currentCharacter=='_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }

                }

                if (isValid)
                {
                    Console.WriteLine(currentWord);
                }
            }
        }
    }
}
