using System;
using System.Linq;

namespace Problem_2._Bread_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] events = Console.ReadLine().Split("|").ToArray();
            int coins = 100;
            int energy = 100;
            for (int i = 0; i < events.Length; i++)
            {
                string[] currentEvent = events[i].Split("-").ToArray();
                if (currentEvent[0] == "rest")
                {
                    int gainedEnergy = int.Parse(currentEvent[1]);

                    if (gainedEnergy + energy >= 100) { Console.WriteLine($"You gained {100 - energy} energy."); Console.WriteLine("Current energy: 100."); energy = 100; }

                    else { Console.WriteLine($"You gained {gainedEnergy} energy."); energy = energy + gainedEnergy; Console.WriteLine("Current energy: {0}.", energy); }
                }
                else if (currentEvent[0] == "order")
                {
                    int earned = int.Parse(currentEvent[1]);
                    if (energy - 30 < 0) { Console.WriteLine("You had to rest!"); energy = energy + 50; }
                    else { coins = coins + earned; Console.WriteLine($"You earned {earned} coins."); energy = energy - 30; }
                }
                else
                {
                    string bought = currentEvent[0];
                    int price = int.Parse(currentEvent[1]);
                    coins -= price;
                    if (coins > 0) { Console.WriteLine($"You bought {bought}."); }
                    else { Console.WriteLine($"Closed! Cannot afford {bought}."); break; }
                }
            }
            if (coins > 0) { Console.WriteLine("Day completed!"); Console.WriteLine($"Coins: {coins}"); Console.WriteLine($"Energy: {energy}"); };
        }
    }
}
