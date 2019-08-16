using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] divided = input.Split('>');
            //split by >
            int explosion = 0;

            //how many you have to delete
            int remaining = 0;

            //if it is bigger than the length you add it to the next explosion

            for (int i = 1; i < divided.Length; i++)
            //i=1 because every explosion happens after >
            {
                explosion = int.Parse("" + divided[i][0]) + remaining;
                // "" to make the char and string so you can convert it into int 

                remaining = explosion - divided[i].Length;
                //remaining if the explosion is bigger than the length

                if (explosion > divided[i].Length)
                { explosion = divided[i].Length; }
                //because you would have to remove every element in the current string


                divided[i] = divided[i].Substring(explosion);
                //changes the current string and leaves only the remain part from the index of the explosion(length) to the end
                //if it happens to delete the whole string the string isnt deleted it is left like "" so later there could be put>
                if (remaining < 0)//if explosion is smaller than the length remainin is <0 so it should be 0

                { remaining = 0; }
            }
            Console.WriteLine(string.Join('>', divided));
        }
    }
}
