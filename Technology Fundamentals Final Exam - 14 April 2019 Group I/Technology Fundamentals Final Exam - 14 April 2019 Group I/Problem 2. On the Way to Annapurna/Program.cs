using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._On_the_Way_to_Annapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var store = new Dictionary<string,List<string>>();
            

            while (input!="END")
            {
                string[] currentCommand = input.Split("->").ToArray();
                if(currentCommand[0]=="Remove")
                {
                    string currentStore = currentCommand[1];
                    if (store.ContainsKey(currentStore))
                    {
                        store.Remove(currentStore);
                    }
                }
                else if (currentCommand[0]=="Add")
                {
                    string currentStore = currentCommand[1];
                    if (currentCommand[2].Contains(","))
                    {
                        List<string> list = currentCommand[2].Split(",").ToList();
                        if (!store.ContainsKey(currentStore))
                        {
                            store.Add(currentStore, list);
                        }
                        else
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                store[currentStore].Add(list[i]);
                            }
                        }
                    }
                    else
                    {
                        if (!store.ContainsKey(currentStore))
                        {
                            var list = new List<string>();
                            list.Add(currentCommand[2]);
                            store.Add(currentStore, list);
                        }
                        else store[currentStore].Add(currentCommand[2]);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Stores list:");
            foreach (var kvp in store.OrderByDescending(x=>x.Value.Count).ThenByDescending(x=>x.Key))
            {
                Console.WriteLine(kvp.Key);
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
