using System;

namespace Mid_Exam___4_November_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int money = 0;
            for (int i = 1; i <= days; i++)
            {
                money = money + 50;
                if (i%15==0)
                {
                    partySize = partySize + 5;
                }
                if (i % 10 == 0)
                {
                    partySize = partySize - 2;
                }
                money = money - 2 * partySize;

                if(i%3==0)
                {
                    money = money - 3 * partySize;
                }
                if(i%5==0)
                {
                    money = money + 20 * partySize;
                    if(i%3==0)
                    { money -= 2 * partySize; }
                }
            }
            Console.WriteLine($"{partySize} companions received {money/partySize} coins each.");

        }
    }
}
