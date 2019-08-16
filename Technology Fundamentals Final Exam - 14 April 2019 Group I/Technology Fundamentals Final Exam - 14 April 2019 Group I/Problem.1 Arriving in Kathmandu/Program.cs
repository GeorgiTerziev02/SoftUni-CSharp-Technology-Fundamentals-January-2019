using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem._1_Arriving_in_Kathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<name>[A-Za-z!@#$?0-9]+)\=(?<length>[0-9]+)\<\<(?<geohashcode>[^<]+)$";
            string input = Console.ReadLine();
            while(input!="Last note")
            {
                Regex mountain = new Regex(pattern);
                if(mountain.IsMatch(input))
                {
                    string name = mountain.Match(input).Groups["name"].ToString();
                    int length = int.Parse(mountain.Match(input).Groups["length"].ToString());
                    string geohashcode = mountain.Match(input).Groups["geohashcode"].ToString();

                    if(length==geohashcode.Length)
                    {
                        StringBuilder currentMountain = new StringBuilder();
                        for (int i = 0; i < name.Length; i++)
                        {
                            char symbol = name[i];
                            if (char.IsLetterOrDigit(symbol))
                            {
                                currentMountain.Append(symbol);
                            }
                        }
                        Console.WriteLine($"Coordinates found! {currentMountain} -> {geohashcode}");
                    }
                    
                    else Console.WriteLine("Nothing found!");
                }
                else Console.WriteLine("Nothing found!");
                input = Console.ReadLine();
            }
        }
    }
}
