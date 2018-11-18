using System;
using System.Globalization;

namespace ExercisePage134
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.Write("Please enter the current day of the week: ");
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            string userDay = textInfo.ToTitleCase(Console.ReadLine());

            try
            {
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userDay);
                Console.WriteLine("Today is " + currentDay + ".");
            }
            catch (System.ArgumentException) 
            {
                Console.WriteLine("Please enter a correct day of the week.");
            }

            Console.ReadLine();

        }


        // create enum for days of the week
        public enum DaysOfWeek
        {
            Monday, Tuesday, Wednesday, Thursday, Friday,
            Saturday, Sunday
        }
    }
}
