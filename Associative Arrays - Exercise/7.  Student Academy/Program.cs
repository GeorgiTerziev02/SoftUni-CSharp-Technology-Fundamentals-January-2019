using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.__Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new Dictionary<string, double>();
            var numberOfGrades = new Dictionary<string, int>();
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <=input; i++)
            {
                string name = Console.ReadLine();
                double grade =double.Parse(Console.ReadLine());
                if(!studentGrades.ContainsKey(name))
                {
                    studentGrades[name] = grade;
                    numberOfGrades[name] = 1;
                }
                else
                {
                    studentGrades[name] += grade;
                    numberOfGrades[name]++;
                }

            }
            var average = new Dictionary<string, double>();
            foreach (var stud in studentGrades)
            {
                double grades = stud.Value;
                string name = stud.Key;
                int del = numberOfGrades[name];
                average[name] = grades / del;
            }
            foreach (var kvp in average.OrderByDescending(x=>x.Value).Where(x=>x.Value>=4.50))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");

            }

        }
    }
}
