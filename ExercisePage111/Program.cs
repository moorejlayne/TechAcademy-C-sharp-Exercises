using System;

namespace ExercisePage111
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an integer value: ");
            int inputValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered " + inputValue + ".");

            // call method 1
            int returnedValue1 = ManipulateNumber.Add10(inputValue);
            Console.WriteLine(inputValue + " + 10 = " + returnedValue1);

            // call method 2
            int returnedValue2 = ManipulateNumber.Subtract2(inputValue);
            Console.WriteLine(inputValue + " - 2 = " + returnedValue2);

            // call method 3
            int returnedValue3 = ManipulateNumber.Multiply5(inputValue);
            Console.WriteLine(inputValue + " * 5 = " + returnedValue3);


            Console.ReadLine();
        }

    }
}
