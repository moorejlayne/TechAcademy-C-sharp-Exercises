using System;

namespace TechAcademy_Practice2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            double hoursStudied = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}

