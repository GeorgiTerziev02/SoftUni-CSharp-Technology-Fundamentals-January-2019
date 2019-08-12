using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] x = command.Split();
                if (x[0] == "Delete")
                {
                    int num = int.Parse(x[1]);
                    list.RemoveAll(y => y == num);
                }
                else if (x[0] == "Insert")
                {
                    int num = int.Parse(x[1]);
                    int index = int.Parse(x[2]);
                    list.Insert(index, num);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));

        }
    }
}
