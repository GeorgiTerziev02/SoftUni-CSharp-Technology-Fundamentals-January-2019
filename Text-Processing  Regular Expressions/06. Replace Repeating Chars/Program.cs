﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder noDuplicate = new StringBuilder();
            noDuplicate.Append(input[0]);
            for (int i = 0; i < input.Length-1; i++)
            {
                if(input[i]!=input[i+1])
                {
                    noDuplicate.Append(input[i+1]);
                }
            }
            Console.WriteLine(noDuplicate);
        }
    }
}
