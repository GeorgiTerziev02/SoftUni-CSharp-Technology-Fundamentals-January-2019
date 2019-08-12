using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Fundamenta_Additional_Retake_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());
            int allBoxes = 0;
            for (int i = 1; i <= batches; i++)
            {
                int flour = int.Parse(Console.ReadLine());
                int sugar = int.Parse(Console.ReadLine());
                int cocoa = int.Parse(Console.ReadLine());

                int cupsFlour = flour / 140;
                int spoonsSugar = sugar / 20;
                int spoonsCocoa = cocoa / 10;
                if (cupsFlour <= 0 || spoonsCocoa <= 0 || spoonsSugar <= 0) Console.WriteLine("Ingredients are not enough for a box of cookies.");
                else
                {
                    int min=Math.Min(cupsFlour, spoonsSugar);
                    min = Math.Min(min, spoonsCocoa);
                    int cookies = 170 * min / 25;
                    int boxes = cookies / 5;
                    allBoxes += boxes;
                    Console.WriteLine($"Boxes of cookies: {boxes}");
                }
            }
            Console.WriteLine($"Total boxes: {allBoxes}");
        }
    }
}
