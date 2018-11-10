using System;

namespace ExercisePage115
{
    class Program
    {
        public static void Main(string[] args)
        {
            // instantiate class
            ManipulateNumbers manipulateNumbers = new ManipulateNumbers();

            // get values from user
            Console.WriteLine("Please enter an integer.");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a value to add to the first number. Leave blank if you do not wish to add anything.");
            string userInput2 = Console.ReadLine();

            // check if entered second number
            bool input2 = true;
            try
            {
                Convert.ToInt32(userInput2);
            }
            catch
            {
                input2 = false;
            }

            // call method and display output
            if (input2)
            {
                int returnedValue = manipulateNumbers.AddNumbers(userInput1, Convert.ToInt32(userInput2));
                Console.WriteLine("Your first value was " + userInput1 + ". Your second value was " + userInput2 + ".");
                Console.WriteLine("The sum of the two numbers is " + returnedValue + ".");
            }
            else
            {
                int returnedValue = manipulateNumbers.AddNumbers(userInput1);
                Console.WriteLine("Your first value was " + userInput1 + ". Your did not enter a second number.");
                Console.WriteLine("The final value is " + returnedValue + ".");
            }

        }
    }
}


