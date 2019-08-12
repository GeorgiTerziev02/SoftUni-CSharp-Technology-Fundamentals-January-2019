using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._Order_by_Age
{
    class People
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
           List<People> peoples = new List<People>();
            while (true)
            {
                string inputLine = Console.ReadLine();
                string[] tokens = inputLine.Split();
                if (inputLine == "End")
                {
                    break;
                }
                string name = tokens[0];
                int id = int.Parse(tokens[1]);
                int age = int.Parse(tokens[2]);
                People people = new People()
                {
                    Name = name,
                    Id = id,
                    Age = age
                };
                peoples.Add(people);
            }
            peoples = peoples.OrderBy(x => x.Age).ToList();
            foreach (var people in peoples)
            {
                Console.WriteLine($"{people.Name} with ID: {people.Id} is {people.Age} years old.");
            }
        }
    }
}