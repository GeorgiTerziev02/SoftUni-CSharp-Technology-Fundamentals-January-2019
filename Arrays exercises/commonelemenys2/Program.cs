using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commonelemenys2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string[] c = a.Split(' ');
            string[] d = b.Split(' ');
            for (int i = 0; i < d.Length; i++)
                for (int j = 0; j < c.Length; j++)
                { if (d[i] == c[j]) Console.Write("{0} ",c[j]); }

        }
    }
}
