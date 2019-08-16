using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split("|").ToArray();
            List<double> newPrice = new List<double>();
            double budget = double.Parse(Console.ReadLine());

            for (int i = 0; i < command.Length; i++)
            {
                string[] cloth = command[i].Split("->").ToArray();
                double price = double.Parse(cloth[1]);
                if (cloth[0] == "Clothes")
                {
                    if (budget >= price && price <= 50.00)
                    {
                        budget = budget - price;
                        newPrice.Add(price);
                    }
                }
                else if (cloth[0] == "Shoes")
                {
                    if (budget >= price && price <= 35.00)
                    {
                        budget = budget - price;
                        newPrice.Add(price);
                    }
                }
                else if (cloth[0] == "Accessories")
                {
                    if (budget >= price && price <= 20.50)
                    {
                        budget = budget - price;
                        newPrice.Add(price);
                    }
                }
            }
            double profit = 0;
            double money = 0;
            for (int i = 0; i < newPrice.Count; i++)
            {
                profit = profit + newPrice[i] * 0.40;
                newPrice[i] = newPrice[i] * 1.40;
                money += newPrice[i];
            }

            double total = budget + money;
            if (total >= 150)
            {
                for (int i = 0; i < newPrice.Count; i++)
                {
                    Console.Write($"{newPrice[i]:f2} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Profit: {profit:f2}");
                Console.WriteLine("Hello, France!");
            }
            else
            {
                for (int i = 0; i < newPrice.Count; i++)
                {
                    Console.Write($"{newPrice[i]:f2} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Profit: {profit:f2}");
                Console.WriteLine("Time to go.");
            }
        }
    }
}