using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rageexpenses10
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = int.Parse(Console.ReadLine());
            double hprice = double.Parse(Console.ReadLine());
            double mprice = double.Parse(Console.ReadLine());
            double kprice = double.Parse(Console.ReadLine());
            double dprice = double.Parse(Console.ReadLine());
            double price = 0;
            price = g / 2 * hprice + g / 3 * mprice + g / 6 * kprice + g / 12 * dprice;
            Console.WriteLine("Rage expenses: {0:f2} lv.", price);
        }
    }
}
