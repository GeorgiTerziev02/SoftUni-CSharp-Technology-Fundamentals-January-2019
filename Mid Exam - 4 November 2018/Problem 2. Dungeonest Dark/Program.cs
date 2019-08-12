using System;

namespace Problem_2._Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|");
            int health = 100;
            int coins = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] command = rooms[i].Split();
                if(command[0]=="potion")
                {
                    int bonusHealth =int.Parse(command[1]);

                    if (health + bonusHealth >= 100) { Console.WriteLine("You healed for {0} hp.", 100-health); Console.WriteLine("Current health: 100 hp.");health = 100; }
                    else { Console.WriteLine("You healed for {0} hp.", bonusHealth); Console.WriteLine("Current health: {0} hp.", health + bonusHealth);health += bonusHealth; }
                }
                else if(command[0]=="chest")
                {
                    int coinsFound = int.Parse(command[1]);
                    coins += coinsFound;
                    Console.WriteLine("You found {0} coins.",coinsFound);
                }
                else
                {
                    int attact = int.Parse(command[1]);
                    if(health-attact<=0)
                    { health -= attact; Console.WriteLine($"You died! Killed by {command[0]}."); Console.WriteLine($"Best room: {i+1}");break; }
                    else { health -= attact; Console.WriteLine("You slayed {0}.",command[0]); }
                }
            }
            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
