using System;

namespace _01._Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int ornamentPrice = 2;
            int skirtPrice = 5;
            int garlandsPrice = 3;
            int lightsPrice = 15;
            int spirit = 0;
            int cost =  0;
            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                { quantity = quantity + 2; }
                if (i % 2 == 0)
                { cost += ornamentPrice * quantity; spirit += 5; }
                if (i % 3 == 0)
                { cost += (skirtPrice + garlandsPrice) * quantity; spirit += 13; }
                if (i % 5 == 0)
                {
                    cost += lightsPrice * quantity; spirit += 17;
                    if (i % 15 == 0)
                    { spirit += 30; }
                }
                if (i % 10 == 0)
                { spirit -= 20; cost = cost + garlandsPrice + lightsPrice + skirtPrice; }
                
                if (days % 10 == 0 && i == days)
                    spirit -= 30;
            }

            Console.WriteLine($"Total cost: {cost}");
            Console.WriteLine($"Total spirit: {spirit}");


        }
    }
}
