using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] houses = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int placement = 0;
            while (command != "Merry Xmas!")
            {
                string[] commandjump = command.Split().ToArray();
                int jump = int.Parse(commandjump[1]);

                if (placement + jump < houses.Length)
                {
                    placement = placement + jump;
                    if (houses[placement] <= 0) Console.WriteLine($"House {placement} will have a Merry Christmas.");
                    else houses[placement] -= 2;
                }
                else if (placement + jump >= houses.Length)
                {
                    placement = (placement + jump) % houses.Length;
                    if (houses[placement] <= 0) Console.WriteLine($"House {placement} will have a Merry Christmas.");
                    else houses[placement] = houses[placement] - 2;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Santa's last position was {placement}.");
            int br = 0;
            for (int i = 0; i < houses.Length; i++)
            {
                if (houses[i] > 0) br++;
            }
            if (br == 0) Console.WriteLine("Mission was successful.");
            else { Console.WriteLine($"Santa has failed {br} houses."); }
        }
    }
}
