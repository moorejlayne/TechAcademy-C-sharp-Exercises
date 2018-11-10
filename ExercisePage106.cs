using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            // Create list of integers
            List<int> Numbers = new List<int>() { 1, 6, 20, 542, 3, 14 };

            // Get number from user
            Console.Write("Enter an integer number to divide the list by: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Display division of each number in list to the screen
            foreach (int number in Numbers)
            {
                double result = Convert.ToDouble(number) / Convert.ToDouble(userNumber);
                Console.WriteLine(number + " divided by " + userNumber + " = " + result.ToString("0.00") + ".");
            }

            // If user inputs 0, don't get an error message, but result is infinity.
            // After some Google-ing, this is because the DivideByZeroException is only for
            // integers and decimal types. Since I'm using double for my final result, 
            // it returns infinity instead of throwing an exception. 

            // If user inputs a string,
            // error is "System.FormatException: Input string was not in correct format."
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Please enter an integer number. Re-run the program to try again.");
        }

        // Since there isn't a "return" in the try-catch block, this will work here.
        // If there was a "return", the following code would need to be in a "finally"
        Console.WriteLine("We are now outside of the try catch block.");

    }
}