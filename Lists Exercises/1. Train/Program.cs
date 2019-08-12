using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int wagonsCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] x = input.Split();
                if (x.Length == 1)
                {

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(x[0]) <= wagonsCapacity)
                        {
                            wagons[i] = wagons[i] + int.Parse(x[0]);

                            break;
                        }
                    }

                }
                if (x.Length == 2)
                {
                    wagons.Add(int.Parse(x[1]));
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}