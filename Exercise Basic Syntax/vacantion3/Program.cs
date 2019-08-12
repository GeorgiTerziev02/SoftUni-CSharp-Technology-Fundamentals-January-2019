using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacantion3
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string d = Console.ReadLine();
            double sum = 0;
            if(d=="Friday")
            {
                if (s == "Students") sum = br * 8.45;
                else if(s == "Business") sum = br * 10.90;
                else if(s == "Regular") sum = br * 15;
            }
            else if (d=="Saturday")
            {
                if (s == "Students") sum = br * 9.80;
                else if(s == "Business") sum = br * 15.60;
                else if(s == "Regular") sum = br * 20;
            }
            else if (d=="Sunday")
            {
                if (s == "Students") sum = br * 10.46;
                else if(s == "Business") sum = br * 16;
                else if(s == "Regular") sum = br * 22.50;
            }
            if (s == "Students" && br >= 30) sum = sum * 85.00 / 100.00;
            if (s == "Business" && br >= 100) sum = sum/br*(br-10);
            if (s == "Regular" && br >= 10&&br<=20) sum = sum * 95.00 / 100.00;


            Console.WriteLine("Total price: {0:f2}",sum);



        }
    }
}
