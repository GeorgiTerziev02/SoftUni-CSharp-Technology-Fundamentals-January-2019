using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> paintings = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] currentCommand = command.Split().ToArray();
                if (currentCommand[0] == "Change")
                {
                    int paintingNumber = int.Parse(currentCommand[1]);
                    int changedNumber = int.Parse(currentCommand[2]);
                    if (paintings.Contains(paintingNumber))
                    {
                        int index1 = paintings.IndexOf(paintingNumber);
                        paintings[index1] = changedNumber;
                    }
                }
                else if (currentCommand[0] == "Hide")
                {
                    int paintingNumber = int.Parse(currentCommand[1]);
                    if (paintings.Contains(paintingNumber))
                    { paintings.Remove(paintingNumber); }
                }
                else if (currentCommand[0] == "Switch")
                {
                    int paintingNumber1 = int.Parse(currentCommand[1]);
                    int paintingNumber2 = int.Parse(currentCommand[2]);
                    if (paintings.Contains(paintingNumber1) && paintings.Contains(paintingNumber2))
                    {
                        int index1 = paintings.IndexOf(paintingNumber1);
                        int index2 = paintings.IndexOf(paintingNumber2);

                        paintings.Insert(index1, paintingNumber2);
                        paintings.RemoveAt(index1 + 1);

                        paintings.Insert(index2, paintingNumber1);
                        paintings.RemoveAt(index2+1);

                    }
                }
                else if (currentCommand[0] == "Reverse")
                {
                    paintings.Reverse();
                }
                else if (currentCommand[0] == "Insert")
                {
                    int index = int.Parse(currentCommand[1]);
                    int paintingNumber = int.Parse(currentCommand[2]);
                    if (index + 1 < paintings.Count)
                    { paintings.Insert(index + 1, paintingNumber); }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", paintings));
        }
    }
}
