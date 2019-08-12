using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string metal = Console.ReadLine();
            var resources = new Dictionary<string, int>();
            while (metal != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if(!resources.ContainsKey(metal))
                {
                    resources[metal] = 0;
                }
                resources[metal]+=quantity;
                metal = Console.ReadLine();
            }
            foreach (var metals in resources)
            {
                Console.WriteLine($"{metals.Key} -> {metals.Value}");
            }
        }
    }
}
