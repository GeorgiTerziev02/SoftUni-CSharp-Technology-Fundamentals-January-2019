using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santa_s_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfcommands = int.Parse(Console.ReadLine());
            List<int> houses = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = 0;
            for (int i = 1; i <= numberOfcommands; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "Forward")
                {
                    int steps = int.Parse(command[1]);
                    if (index + steps >= houses.Count) index = index;
                    else
                    {
                        index = index + steps;
                        houses.RemoveAt(index);
                    }
                }
                else if (command[0] == "Back")
                {
                    int steps = int.Parse(command[1]);
                    if (index - steps < 0) index = index;
                    else
                    {
                        index = index - steps;
                        houses.RemoveAt(index);
                    }
                }
                else if (command[0] == "Gift")
                {
                    int insertInindex = int.Parse(command[1]);
                    int houseNumber = int.Parse(command[2]);
                    if (insertInindex >= houses.Count || insertInindex < 0) index = index;
                    else
                    {
                        houses.Insert(insertInindex, houseNumber);
                        index = insertInindex;
                    }
                }
                else if (command[0] == "Swap")
                {
                    int number1 = int.Parse(command[1]);
                    int number2 = int.Parse(command[2]);
                    if (houses.Contains(number1) && houses.Contains(number2))
                    {
                        int index1 = houses.IndexOf(number1);
                        int index2 = houses.IndexOf(number2);

                        houses.Insert(index1, number2);
                        houses.RemoveAt(index1+1);
                        houses.Insert(index2, number1);
                        houses.RemoveAt(index2+1);
                    }
                }
            }
            Console.WriteLine($"Position: {index}");
            Console.WriteLine(string.Join(", ",houses));
        }
    }
}
