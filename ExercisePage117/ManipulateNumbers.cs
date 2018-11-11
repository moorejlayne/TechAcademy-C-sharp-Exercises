using System;
namespace ExercisePage117
{
    public class ManipulateNumbers
    {
        // void method that outputs an integer
        public void DivideBy2(int inputValue, out int returnValue)
        {
            returnValue = inputValue / 2;
        }

        // method with multiple output parameters
        public void ReturnSumAndMultiplication(int inputValue1, int inputValue2, out int returnSum, out int returnMultiplication)
        {
            returnSum = inputValue1 + inputValue2;
            returnMultiplication = inputValue1 * inputValue2; 
        }

        // overload a method
        public void ReturnSumAndMultiplication(int inputValue1, int inputValue2, int inputValue3, out int returnSum, out int returnMultiplication)
        {
            returnSum = inputValue1 + inputValue2 + inputValue3;
            returnMultiplication = inputValue1 * inputValue2 * inputValue3;
        }

    }
}
