using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator3
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            if (capacity >= people) { Console.WriteLine(1);}
            else
            {
                int courses;
                
                courses = people/capacity;
                if (people%capacity == 0) { Console.WriteLine(courses); }
                else
                {                  
                  Console.WriteLine(courses+1);                  
                }
               
             }

        }
    }
}
