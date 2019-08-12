using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string com = Console.ReadLine();
            while (com != "3:1")
            {
                string[] command = com.Split().ToArray();
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    endIndex = Math.Min(int.Parse(command[2]), input.Count - 1);
                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        input[startIndex] = input[startIndex] + input[startIndex + 1];
                        input.RemoveAt(startIndex + 1);
                    }
                }

                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);


                    Divide(input, index, partitions);
                    break;


                }

                com = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }

        private static void Divide(List<string> input, int indexOfElementToDivide, int partitions)
        {
            string elementToDivide = input[indexOfElementToDivide];
            string dividedElement = "";
            if (elementToDivide.Length % partitions != 0)
            {
                // when division CANNOT make equal parts
                int lengthOfPartitions = elementToDivide.Length / partitions;
                int lengthOfLastPartition = lengthOfPartitions + (elementToDivide.Length % partitions);
                for (int i = 0; i < partitions - 1; i++)
                {
                    dividedElement += elementToDivide.Substring(0, lengthOfPartitions);
                    dividedElement += " ";
                    elementToDivide = elementToDivide.Remove(0, lengthOfPartitions);
                }

                dividedElement += elementToDivide;
            }
            else
            {
                // when division CAN make equal parts
                int lengthOfPartitions = elementToDivide.Length / partitions;
                for (int i = 0; i < partitions; i++)
                {
                    dividedElement += elementToDivide.Substring(0, lengthOfPartitions);
                    dividedElement += " ";
                    elementToDivide = elementToDivide.Remove(0, lengthOfPartitions);
                }
            }

        }
    }
}