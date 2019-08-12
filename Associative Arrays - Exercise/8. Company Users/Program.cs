using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new Dictionary<string,List<string>>();
            string input = string.Empty;
            while((input=Console.ReadLine())!="End")
            {
                string[] command = input.Split(" -> ").ToArray();
                string lang = command[0];
                string id = command[1];
                if(!employees.ContainsKey(lang))
                {
                    var list = new List<string>();
                    list.Add(id);
                    employees.Add(lang, list);
                }
                else
                {
                    var people = employees[lang];
                    if (!people.Contains(id))
                    {
                        people.Add(id);
                        employees[lang] = people;
                    }
                }
            }
            foreach (var kvp in employees.OrderBy(x=>x.Key))
            {
                Console.WriteLine(kvp.Key);
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    Console.WriteLine($"-- {kvp.Value[i]}");
                }
            }
        }
    }
}
