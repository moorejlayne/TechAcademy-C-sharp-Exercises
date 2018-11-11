using System;

namespace ExercisePage117
{
    class Program
    {
        public static void Main(string[] args)
        {
            // instantiate class
            ManipulateNumbers manipulateNumbers = new ManipulateNumbers();

            // call method that outputs integer and display to screen
            Console.WriteLine("First method:");
            Console.Write("Please input a whole number: ");
            int inputValue1 = Convert.ToInt32(Console.ReadLine());
            manipulateNumbers.DivideBy2(inputValue1, out int returnedValue1);
            Console.WriteLine("The value given was " + inputValue1 + ".");
            Console.WriteLine("The value divided by 2 is " + returnedValue1 + ".");

            // call method with output parameters
            Console.WriteLine("Second method:");
            Console.Write("Please input a whole number: ");
            int inputValue2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please input a whole number: ");
            int inputValue3 = Convert.ToInt32(Console.ReadLine());
            manipulateNumbers.ReturnSumAndMultiplication(inputValue2, inputValue3, out int returnSum, out int returnMultiplication);
            Console.WriteLine("You entered " + inputValue2 + " and " + inputValue3 + ".");
            Console.WriteLine(inputValue1 + " + " + inputValue2 + " = " + returnSum);
            Console.WriteLine(inputValue1 + " * " + inputValue2 + " = " + returnMultiplication);

            // call overloaded methoded
            Console.WriteLine("Third method:");
            Console.Write("Please input a whole number: ");
            int inputValue4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please input a whole number: ");
            int inputValue5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please input a whole number: ");
            int inputValue6 = Convert.ToInt32(Console.ReadLine());
            manipulateNumbers.ReturnSumAndMultiplication(inputValue4, inputValue5, inputValue6, out int returnSum2, out int returnMultiplication2);
            Console.WriteLine("You entered " + inputValue4 + ", " + inputValue5 + " and " + inputValue6 + ".");
            Console.WriteLine(inputValue4 + " + " + inputValue5 + " + " + inputValue6 + " = " + returnSum2);
            Console.WriteLine(inputValue4 + " * " + inputValue5 + " * " + inputValue6 + " = " + returnMultiplication2);

            // call static class method
            Console.WriteLine("Static class:");
            StaticClassExample.TestPassiveVoice("This code was written"); // passive voice
            StaticClassExample.TestPassiveVoice("I wrote the code"); // active voice


            Console.ReadLine();
        }
    }
}
