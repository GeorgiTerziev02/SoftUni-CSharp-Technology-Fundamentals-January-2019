using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            var registeredUsers = new Dictionary<string, string>();
            for (int i = 1; i <= numberOfCommands; i++)
            {
                string[] currentCommand = Console.ReadLine().Split().ToArray();
                string username = currentCommand[1];
                if (currentCommand.Length==2)
                {
                    if (!registeredUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registeredUsers.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
                else
                {
                    string license = currentCommand[2];

                    if(!registeredUsers.ContainsKey(username))
                    {
                        registeredUsers[username] = license;
                        Console.WriteLine($"{username} registered {license} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {license}");
                    }

                }

            }
            foreach (var kvp in registeredUsers)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }

        }
    }
}
