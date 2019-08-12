using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {

            int num =int.Parse(Console.ReadLine());
            if (num >= 0 && num <= 2) Console.WriteLine("baby");
            else if(num<=13) Console.WriteLine("child");
            else if(num<=19) Console.WriteLine("teenager");
            else if(num<=65) Console.WriteLine("adult");
            else  Console.WriteLine("elder");
 





        }
    }
}
