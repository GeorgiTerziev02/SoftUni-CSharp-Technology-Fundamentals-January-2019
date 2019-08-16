using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Extract_File
{
    class Program
    {

        static void Main(string[] args)
        {
           string[] address = Console.ReadLine().Split('\\');
            string[] file = address[address.Length - 1].Split('.');

            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}
