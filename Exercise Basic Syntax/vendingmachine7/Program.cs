using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingmachine7
{
    class Program
    {
        static void Main(string[] args)
        {
            string c;
            double sum = 0;
            while(true)
            {
                c = Console.ReadLine();
                if (c == "Start") break;
                else { double q = double.Parse(c);
                    if (q == 0.1 || q == 0.2 || q == 0.5 || q == 1 || q == 2) sum = sum + q;
                    else Console.WriteLine("Cannot accept {0}",q);
                }
            }
            string nap;
            while(true)
            {
                nap = Console.ReadLine();
                if (nap == "End") break; 
                else if (nap == "Nuts")
                {
                    if (sum >= 2.00) { Console.WriteLine("Purchased nuts"); sum = sum - 2.0; }
                    else Console.WriteLine("Sorry, not enough money");
                }
                else if (nap == "Water")
                {
                    if (sum >= 0.70)
                    {
                        Console.WriteLine("Purchased water"); sum = sum - 0.70;
                    }
                    else Console.WriteLine("Sorry, not enough money");
                }
                else if (nap == "Crisps")
                {
                    if (sum >= 1.50)
                    {
                        Console.WriteLine("Purchased crisps"); sum = sum - 1.50;
                    }
                    else Console.WriteLine("Sorry, not enough money");
                }
                else if (nap == "Soda")
                {
                    if (sum >= 0.80)
                    {
                        Console.WriteLine("Purchased soda"); sum = sum - 0.80;
                    }
                    else Console.WriteLine("Sorry, not enough money");
                }
                else if (nap == "Coke")
                {
                    if (sum >= 1.00)
                    {
                        Console.WriteLine("Purchased coke"); sum = sum - 1.00;
                    }
                    else Console.WriteLine("Sorry, not enough money");
                }
                else Console.WriteLine("Invalid product");
            }
            Console.WriteLine("Change: {0:f2}",sum);
        }
    }
}
