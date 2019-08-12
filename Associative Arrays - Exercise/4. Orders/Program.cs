using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = new Dictionary<string, double>();
            var quantities = new Dictionary<string, int>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] bought = input.Split().ToArray();

                string product = bought[0];
                double price = double.Parse(bought[1]);
                int quantity = int.Parse(bought[2]);

                if (!prices.ContainsKey(product))
                {
                    prices[product] = price;
                    quantities[product] = quantity;
                }
                else
                {
                    prices[product] = price;
                    quantities[product] += quantity;
                }

            }

            foreach (var kvp in quantities)
            {
                string product = kvp.Key;
                int quantity = kvp.Value;
                double price = prices[product];
                double total = price * quantity;

                Console.WriteLine($"{product} -> {total:f2}");
            }
        }
    }
}
