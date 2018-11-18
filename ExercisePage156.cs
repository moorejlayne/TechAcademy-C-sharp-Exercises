using System;
using System.Globalization;

namespace CsharpExercises
{
    public class ExercisePage156
    {
        public static void Main(string[] args)
        {
            // print current date and time to console
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentDateTime);

            // ask user for number
            Console.Write("Please enter a number of hours: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // add user number to datetime from when program began, and print. 
            DateTime futureDateTime = currentDateTime.AddHours(userInput);
            Console.WriteLine("In {0} hours it will be: " + futureDateTime, userInput);

            Console.ReadLine();
        }
    }
}
