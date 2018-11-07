using System;

namespace TechAcademy_Practice4
{
    class Program
    {
        static void Main()
        {
            // Header
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("");

            // Get Person 1 details
            Console.WriteLine("Person 1");
            Console.Write("Hourly rate: ");
            double rateP1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours worked per week: ");
            double hoursP1 = Convert.ToDouble(Console.ReadLine());

            // Get Person 2 details
            Console.WriteLine("Person 2");
            Console.Write("Hourly rate: ");
            double rateP2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours worked per week: ");
            double hoursP2 = Convert.ToDouble(Console.ReadLine());

            // Calculate and compare weekly and annual salary of Person 1 and Person 2 
            // Assumes 50 full weeks worked in a year
            double weeklyP1 = rateP1 * hoursP1;
            double annualP1 = weeklyP1 * 50;
            double weeklyP2 = rateP2 * hoursP2;
            double annualP2 = weeklyP2 * 50;
            bool P1gP2 = annualP1 > annualP2;

            // Display values to the console
            Console.WriteLine(""); 
            Console.WriteLine("Weekly salary of Person 1: " + weeklyP1);
            Console.WriteLine("Annual salary of Person 1: " + annualP1);
            Console.WriteLine("");
            Console.WriteLine("Weekly salary of Person 2: " + weeklyP2);
            Console.WriteLine("Annual salary of Person 2: " + annualP2);
            Console.WriteLine("Does Person 1 make more money than Person 2? " + P1gP2);

            Console.ReadLine();
        }
    }
}