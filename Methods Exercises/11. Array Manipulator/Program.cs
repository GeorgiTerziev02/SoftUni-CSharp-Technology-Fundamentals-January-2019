using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringArray = Console.ReadLine();
            int[] array = stringArray.Split().Select(int.Parse).ToArray();
            int arrayLength = array.Length;
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandMethod = command.Split();
                if (commandMethod[0] == "exchange")
                {
                    int index = int.Parse(commandMethod[1]);
                    if (index > arrayLength || index < 0) { Console.WriteLine("Invalid index"); }
                    else ExchangeAfterIndex(index, array);
                }
                else if (commandMethod[0] == "max")
                {
                    if (commandMethod[1] == "even") { MaxEven(array); }
                    else if (commandMethod[1] == "odd") { MaxOdd(array); }

                }
                else if (commandMethod[0] == "min")
                {
                    if (commandMethod[1] == "even") { MinEven(array); }
                    else if (commandMethod[1] == "odd") { MinOdd(array); }
                }
                else if (commandMethod[0] == "first")
                {
                    if (commandMethod[2] == "even")
                    {
                        int count = int.Parse(commandMethod[1]);
                        if (count > arrayLength || count < 0) Console.WriteLine("Invalid count");
                        else FirstnEven(array, count);
                    }
                    else if (commandMethod[2] == "odd")
                    {
                        int count = int.Parse(commandMethod[1]);
                        if (count > arrayLength || count < 0) Console.WriteLine("Invalid count");
                        else FirstnOdd(array, count);
                    }
                }
                else
                {
                    PrintLastElements(array, commandMethod[2], commandMethod[1]);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        private static void PrintLastElements(int[] arr, string comand, string count)
        {
            List<int> currentList = new List<int>();
            int currentCount = int.Parse(count);
            if (comand == "even")
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 0)
                    {
                        currentList.Add(arr[i]);
                        currentCount--;
                        if (currentCount < 1)
                        {
                            break;
                        }
                    }
                }
                currentList.Reverse();
                Console.WriteLine("[{0}]", string.Join(", ", currentList));
            }
            else
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 != 0)
                    {
                        currentList.Add(arr[i]);
                        currentCount--;
                        if (currentCount < 1)
                        {
                            break;
                        }
                    }
                }
                currentList.Reverse();
                Console.WriteLine("[{0}]", string.Join(", ", currentList));
            }
        }

        private static void FirstnOdd(int[] array, int count)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (counter == 0) { Console.Write("[{0}", array[i]); }
                    else Console.Write(", {0}", array[i]);
                    counter++;
                }
                if (counter == count) break;
            }
            if (counter == 0) Console.WriteLine("[]");
            else Console.WriteLine("]");

        }

        private static void FirstnEven(int[] array, int count)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (counter == 0) { Console.Write("[{0}", array[i]); }
                    else Console.Write(", {0}", array[i]);
                    counter++;
                }

                if (counter == count) break;
            }
            if (counter == 0) Console.WriteLine("[]");
            else Console.WriteLine("]");

        }

        private static void MinOdd(int[] array)
        {
            int minIndex = int.MaxValue;
            int minNumber = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (minNumber >= array[i] && array[i] % 2 != 0) { minNumber = array[i]; minIndex = i; }
            }
            if (minIndex == int.MaxValue) { Console.WriteLine("No matches"); }
            else Console.WriteLine(minIndex);
        }

        private static void MinEven(int[] array)
        {
            int minIndex = int.MaxValue;
            int minNumber = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (minNumber >= array[i] && array[i] % 2 == 0) { minNumber = array[i]; minIndex = i; }
            }
            if (minIndex == int.MaxValue) { Console.WriteLine("No matches"); }
            else Console.WriteLine(minIndex);
        }

        private static void MaxEven(int[] array)
        {
            int maxIndex = int.MinValue;
            int maxNumber = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxNumber <= array[i] && array[i] % 2 == 0) { maxNumber = array[i]; maxIndex = i; }
            }
            if (maxIndex == int.MinValue) { Console.WriteLine("No matches"); }
            else Console.WriteLine(maxIndex);
        }

        private static void MaxOdd(int[] array)
        {
            int maxIndex = int.MinValue;
            int maxNumber = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxNumber <= array[i] && array[i] % 2 != 0) { maxNumber = array[i]; maxIndex = i; }
            }
            if (maxIndex == int.MinValue) { Console.WriteLine("No matches"); }
            else Console.WriteLine(maxIndex);
        }

        private static string ExchangeAfterIndex(int index, int[] array)
        {
            for (int i = 0; i < array.Length - 1 - index; i++)
            {
                int lastElement = array[array.Length - 1];
                for (int j = array.Length - 1; j >= 1; j--)
                { array[j] = array[j - 1]; }
                array[0] = lastElement;
            }

            return string.Join(" ", array);
        }
    }
}