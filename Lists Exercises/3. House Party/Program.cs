using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfcommands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < numberOfcommands; i++)
            {
                string[] name = Console.ReadLine().Split();

                if (name.Length == 3)
                {
                    if (!names.Contains(name[0]))
                    {
                        names.Add(name[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{name[0]} is already in the list!");
                    }
                }

                else if (name.Length == 4)
                {
                    if (names.Contains(name[0]))
                    {
                        names.Remove(name[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{name[0]} is not in the list!");
                    }
                }
            }


            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}