using System;

namespace TechAcademy_Practice5
{
    class Program
    {
        static void Main()
        {
            // Get details
            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Have you ever had a DUI? Enter 'true' or 'false': ");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.Write("How many speeding tickets do you have? ");
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Determine if qualifies
            bool qualifies = age > 15 && DUI == false && tickets <= 3;

            // Print output
            Console.WriteLine("");
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Previous DUI? " + DUI);
            Console.WriteLine("Number of speeding tickets: " + tickets);
            Console.WriteLine("Qualified? " + qualifies);

            Console.ReadLine();
        }
    }
}
