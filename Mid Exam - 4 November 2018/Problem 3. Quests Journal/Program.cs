using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = Console.ReadLine().Split(", ").ToList();
            string commandos=Console.ReadLine();
            while(commandos!="Retire!")
            {
                string[] command = commandos.Split(" - ");
                if(command[0]=="Start")
                { if (!phrases.Contains(command[1])) phrases.Add(command[1]); }
                else if(command[0]=="Complete")
                { if (phrases.Contains(command[1])) phrases.Remove(command[1]); }
                else if(command[0]=="Renew")
                { if (phrases.Contains(command[1])) { phrases.Add(command[1]);phrases.Remove(command[1]); } }
                else if(command[0]=="Side Quest")
                {
                    string[] sideQuest = command[1].Split(":");
                    if(phrases.Contains(sideQuest[0]))
                    {
                        if (!phrases.Contains(sideQuest[1]))
                        {
                            int index = phrases.IndexOf(sideQuest[0]);
                            phrases.Insert(index + 1, sideQuest[1]);
                        }
                    }

                }
                commandos = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", phrases));

        }
    }
}
