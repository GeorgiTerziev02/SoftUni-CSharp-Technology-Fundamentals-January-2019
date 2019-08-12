using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string sempty = string.Empty;

            for (int i = s.Length - 1; i >= 0; i--) { sempty = sempty + s[i]; }
            int br = 0;
            while (true)
            {
                br++;
                string p = Console.ReadLine();
                if (p == sempty) {Console.WriteLine("User {0} logged in.", s); break; }
                else if (br == 4) { Console.WriteLine("User {0} blocked!", s); break; }
                else Console.WriteLine("Incorrect password. Try again.");
                
            }

        }
    }
}
