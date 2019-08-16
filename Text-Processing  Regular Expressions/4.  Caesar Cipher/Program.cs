using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.__Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder caesarCipher=new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char newSymbol = (char)(input[i]+3);
                caesarCipher.Append(newSymbol);
                
            }
            Console.WriteLine(caesarCipher);
        }
    }
}
