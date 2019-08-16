using System;

namespace _Demo___Mid_Exam___02_March_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceFlour = double.Parse(Console.ReadLine());
            double priceEgg = double.Parse(Console.ReadLine());
            double priceApron = double.Parse(Console.ReadLine());
            int freeFlour = students / 5;
            double price = (students - freeFlour) * priceFlour +Math.Ceiling(students * 1.2) * priceApron + students * priceEgg * 10;
            if (budget - price >= 0) Console.WriteLine($"Items purchased for {price:f2}$.");
            else Console.WriteLine($"{price - budget:f2}$ more needed.");
        }
    }
}
