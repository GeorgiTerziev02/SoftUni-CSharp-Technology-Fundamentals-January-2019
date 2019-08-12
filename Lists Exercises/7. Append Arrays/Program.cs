using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers= Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();
            List<string> num = new List<string>();
            for (int i = 0; i < numbers.Count; i++)
            {
                string[] array = numbers[i].Split();

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] != "") num.Add(array[j]);
                }                            
            }


            Console.WriteLine(string.Join(" ", num));

        }
    }
}
