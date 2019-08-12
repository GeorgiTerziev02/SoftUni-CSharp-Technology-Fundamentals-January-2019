using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var registeredStudents = new Dictionary<string, string>();
            var courses = new Dictionary<string, int>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" : ").ToArray();
                string lang = command[0];
                string name = command[1];
                if (!courses.ContainsKey(lang))
                {
                    courses[lang] = 0;
                }
                courses[lang]++;
                registeredStudents[name] = lang;

            }

            foreach (var kvp in courses.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                foreach (var stud in registeredStudents.OrderBy(x=>x.Key))
                {
                    if (stud.Value == kvp.Key)
                        Console.WriteLine($"-- {stud.Key}");
                }

            }
        }
    }
}
