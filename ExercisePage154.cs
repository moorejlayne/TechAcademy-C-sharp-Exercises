using System;
using System.IO;

namespace CsharpExercises
{
    public class ExercisePage154
    {
        public static void Main(string[] args)
        {
            // assign path for saving / loading log file
            string path = "/Users/JLM/Desktop/log.txt";

            // ask user for number
            Console.Write("Please enter a whole number: ");
            string userInput = Console.ReadLine();

            // log number to text file
            File.WriteAllText(path, userInput);

            // print text file back to the user
            string fileContents = File.ReadAllText(path);
            Console.WriteLine("The following was saved to the log file: " + fileContents);

            Console.ReadLine();
        }


    }
}
