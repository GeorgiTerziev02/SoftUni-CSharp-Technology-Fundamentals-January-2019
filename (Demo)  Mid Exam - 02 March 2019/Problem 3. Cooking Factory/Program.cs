using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Cooking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();


            int bestQuality = int.MinValue;
            List<string> best = new List<string>();
            int bestAverage = 0;
            int bestLength = 0;
            while(command!="Bake It!")
            {
                int quality = 0;
                int average = 0;
                
                string[] bread = command.Split("#").ToArray();
                int length = bread.Length;
                for (int i = 0; i < bread.Length; i++)
                {
                    quality = quality +int.Parse(bread[i]);
                }
                average = quality /length;

                if (bestQuality < quality)
                {
                    bestQuality = quality;
                    bestAverage = average;
                    bestLength = length;
                    best.Clear();
                    for (int i = 0; i < bread.Length; i++)
                    {
                        best.Add(bread[i]);
                    }
                }
                else if(bestQuality==quality)
                {
                    if(average>bestAverage)
                    {
                        bestAverage = average;
                        bestLength = length;
                        best.Clear();
                        for (int i = 0; i < bread.Length; i++)
                        {
                            best.Add(bread[i]);
                        }
                    }
                    else if (average==bestAverage)
                    {
                        if(bestLength > length)
                        {
                            bestLength = length;
                            best.Clear();
                            for (int i = 0; i < bread.Length; i++)
                            {
                                best.Add(bread[i]);
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best Batch quality: {bestQuality}");
            Console.WriteLine(string.Join(" ",best));


        }
    }
}
