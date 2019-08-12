using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace snowballs11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxsnow = 0;
            int maxtime = 0;
            int maxquality = 0;
            BigInteger maxvalue = 0;
            while (n > 0)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                
                int p = snow / time;
                BigInteger value = 1;
                for(int i=1;i<=quality;i++)
                { value = value * p; }
                if (value > maxvalue) { maxvalue = value;maxsnow = snow; maxtime = time;maxquality = quality; }
                n--;
            }
            Console.WriteLine("{0} : {1} = {2} ({3})",maxsnow,maxtime,maxvalue,maxquality);
        }
    }
}
