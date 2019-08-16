using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _12._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern= @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[0-9]+\.?[0-9]+)\$";
            string input = string.Empty;
            double totalPrice = 0;
            while ((input=Console.ReadLine())!="end of shift")
            {
                Regex order = new Regex(pattern);
                if (order.IsMatch(input))
                {
                    string customerName = order.Match(input).Groups["customer"].Value;
                    string productName = order.Match(input).Groups["product"].Value;
                    int count = int.Parse(order.Match(input).Groups["count"].Value);
                    double price = double.Parse(order.Match(input).Groups["price"].Value);

                    totalPrice += price * count;
                    Console.WriteLine($"{customerName}: {productName} - {price*count:f2}");
                }

            }
            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
