using System;

namespace Mid_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double fuelPerKM = double.Parse(Console.ReadLine());
            double foodPerP = double.Parse(Console.ReadLine());
            double hotelRoom = double.Parse(Console.ReadLine());

            double hotelExpenses = hotelRoom * days * people;
            if (people > 10) hotelExpenses = hotelExpenses * 0.75;
            double foodExpenses = days * people * foodPerP;
            double totalExpenses = hotelExpenses + foodExpenses;
           // double travellExpenses = 0;

            for (int i = 1; i <= days; i++)
            {
                double travelledDistance = double.Parse(Console.ReadLine());
                //travellExpenses += travelledDistance * fuelPerKM;
                totalExpenses = totalExpenses + travelledDistance * fuelPerKM;

                if (i % 3 == 0 || i % 5 == 0) { totalExpenses = totalExpenses * 1.4; }
                if (i % 7 == 0) { totalExpenses = totalExpenses - totalExpenses / people; }
                if (budget < totalExpenses) { Console.WriteLine($"Not enough money to continue the trip. You need {totalExpenses - budget:f2}$ more."); break; }

            }
            if (budget >= totalExpenses) Console.WriteLine($"You have reached the destination. You have {budget - totalExpenses:f2}$ budget left.");
        }
    }
}
