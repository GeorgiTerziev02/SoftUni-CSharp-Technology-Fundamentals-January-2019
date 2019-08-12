using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> plone = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> pltwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (plone.Count != 0 && pltwo.Count != 0)
            {
                if (pltwo[0] == plone[0])
                { pltwo.Remove(pltwo[0]); plone.Remove(plone[0]); }
                else if (plone[0] > pltwo[0])
                { int x = pltwo[0]; pltwo.Remove(pltwo[0]);
                    int y = plone[0];
                    plone.Remove(plone[0]);
                    plone.Add(y);
                    plone.Add(x);
                }
                else if(pltwo[0]>plone[0])
                {
                    int x = pltwo[0]; pltwo.Remove(pltwo[0]);
                    int y = plone[0];
                    plone.Remove(plone[0]);
                    pltwo.Add(x);
                    pltwo.Add(y);
                }
            }
            if(plone.Count==0)
            { Console.WriteLine($"Second player wins! Sum: {pltwo.Sum()}"); }
            else { Console.WriteLine($"First player wins! Sum: {plone.Sum()}"); }


        }
    }
}
