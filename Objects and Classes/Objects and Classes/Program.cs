using System;

namespace Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[] Phrases = { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };
            string[] Events = { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };
            string[] Authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random number = new Random();

            for (int i = 0; i < input; i++)
            {
                int phrasesIndex = number.Next(0, Phrases.Length);
                int eventIndex = number.Next(0, Events.Length);
                int authorIndex = number.Next(0, Authors.Length);
                int townIndex = number.Next(0, Cities.Length);

                Console.WriteLine($"{Phrases[phrasesIndex]} {Events[eventIndex]} {Authors[authorIndex]} - {Cities[townIndex]}");


            }



        }
    }
}
