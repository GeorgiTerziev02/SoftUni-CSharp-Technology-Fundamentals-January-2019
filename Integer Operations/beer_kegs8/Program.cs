using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beer_kegs8
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string max = string.Empty;
            double maxvolume = 0;
            while(number>0)
            {
                string ime = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double vol = Math.PI * h * r * r;
                if (vol > maxvolume) { max = ime;maxvolume = vol; }
                number--;
            }
            
            Console.WriteLine(max);
        }
    }
}
