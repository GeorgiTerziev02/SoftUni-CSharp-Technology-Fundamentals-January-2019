using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spice_Must_flow9
{
    class Program
    {
        static void Main(string[] args)
        {
            int syield = int.Parse(Console.ReadLine());
            int dni = 0;
            int produced = 0;
            while (syield >= 100)
            {
                dni++;
                produced = produced + syield - 26;


                if (syield - 10 < 100) { produced = produced - 26; syield = syield - 10; }
                else if (syield!=0) syield = syield - 10;
            }

            Console.WriteLine(dni);
            Console.WriteLine(produced);

        }
    }
}