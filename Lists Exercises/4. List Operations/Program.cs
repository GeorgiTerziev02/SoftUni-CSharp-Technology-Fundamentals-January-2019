using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string[] s = Console.ReadLine().Split();
            int number = int.Parse(s[0]);
            int power = int.Parse(s[1]);
            int br = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (number == numbers[i])
                {
                    br = i;//3
                    if (br - power < 0&&br+power<numbers.Count)
                    {
                        for (int j = 0; j < 2 * power + 1; j++)
                        {
                            numbers.RemoveAt(j);
                        }

                    }
                    else
                    {
                        for (int j = br-power; j < br+2*power+1; j++)
                        {
                            numbers.RemoveAt(j);
                        }
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}