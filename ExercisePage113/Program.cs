using System;

namespace ExercisePage113
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // instantiate class
            ManipulateNumbers manipulateNumbers = new ManipulateNumbers();
           
            // call method
            manipulateNumbers.ModifyAndDisplay(25, 4020);

            // call method using parameter names
            manipulateNumbers.ModifyAndDisplay(inputValue1: 30, inputValue2: 400400);


            Console.ReadLine();
        }
    }
}
