using System;

namespace ExercisePage114
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 1-2
            int number1 = 12;
            ManipulateNumbers manipulateNumbers = new ManipulateNumbers();
            int returnedValue = manipulateNumbers.ModifyNumber(number1);
            Console.WriteLine("The integer is " + number1 + ". The new integer is " + returnedValue + ".");

            // 3-4
            decimal number2 = 12.0m;
            ManipulateNumbers manipulateNumbers2 = new ManipulateNumbers();
            int returnedValue2 = manipulateNumbers2.ModifyNumber(number2);
            Console.WriteLine("The decimal is " + number2 + ". The new integer is " + returnedValue2 + ".");

            // 5-6
            string number3 = "12";
            ManipulateNumbers manipulateNumbers3 = new ManipulateNumbers();
            int returnedValue3 = manipulateNumbers3.ModifyNumber(number3);
            Console.WriteLine("The string is \"" + number3 + "\". The new integer is " + returnedValue3 + ".");

        }
    }
}
