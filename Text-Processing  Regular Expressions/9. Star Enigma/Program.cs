using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _9._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<StringBuilder> decryptedMessages = new List<StringBuilder>();
            //to collect all the DECRYPTED strings
            for (int i = 0; i < lines; i++)
            {
                string message = Console.ReadLine();
                string pattern = @"[sStTrRaA]";
                //using this regex in order to see how much will the key be
                Regex regex = new Regex(pattern);
                //regex
                MatchCollection matches = regex.Matches(message);
                //collection which collect all of the successful matches
                int key = matches.Count;
                //its length is the key
                StringBuilder decrypted = new StringBuilder();
                //to collect every symbol after it is changed
                for (int j = 0; j < message.Length; j++)
                {
                    char newSymbol = message[j];
                    newSymbol =(char)( newSymbol - key);
                    decrypted.Append(newSymbol);
                    //adding the symbol
                }
                decryptedMessages.Add(decrypted);
                //adding the decrypted message to the list
            }
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            //creating two lists for the planets
            string decrPattern = @"@(?<name>[A-Z][a-z]+)[^@\-!:>]*:(?<poplation>[0-9]+)![^@\-!:>]*(?<type>[AD])![^@\-!:>]*->(?<soldier>[0-9]+)";
            //regex pattern for the decrypted messages
            var reg = new Regex(decrPattern);
            foreach (var item in decryptedMessages)
            {
                if (reg.IsMatch(item.ToString()))
                    //to string because we cant use stringBuilders
                {
                    string planetName = reg.Match(item.ToString()).Groups["name"].Value;
                    //the match of the planet name
                    if (reg.Match(item.ToString()).Groups["type"].Value == "D")
                        //the match A/D
                    { destroyed.Add(planetName); }
                    else attacked.Add(planetName);                   
                }
            }
            if(attacked.Count==0)
            {
                Console.WriteLine("Attacked planets: 0");
            }
            else
            {
                Console.WriteLine($"Attacked planets: {attacked.Count}");
                foreach (var planet in attacked.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
            if (destroyed.Count == 0)
            {
                Console.WriteLine("Destroyed planets: 0");
            }
            else
            {
                Console.WriteLine($"Destroyed planets: {destroyed.Count}");
                foreach (var planet in destroyed.OrderBy(x=>x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
