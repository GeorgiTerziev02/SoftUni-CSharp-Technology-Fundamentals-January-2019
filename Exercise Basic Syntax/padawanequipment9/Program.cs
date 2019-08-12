using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padawanequipment9
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int br = int.Parse(Console.ReadLine());
            double lights = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());
            double q = br * 110.00 / 100.00;
            q = Math.Ceiling(q);
            int k = br - br / 6;
            double suma = 0;
            suma = lights * q + robes * br + k * belts;
            if (suma <= money) Console.WriteLine("The money is enough - it would cost {0:f2}lv.",suma);
            else Console.WriteLine("Ivan Cho will need {0:f2}lv more.",suma-money);
        }
    }
}
