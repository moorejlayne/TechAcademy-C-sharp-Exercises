using System;
using System.Collections.Generic;

namespace ExercisePage114
{
    public class ManipulateNumbers
    {
        //public ManipulateNumbers()
        //{
        //}

        public int ModifyNumber(int inputValue)
        {
            return inputValue + 10;
        }

        public int ModifyNumber(decimal inputValue)
        {
            return Convert.ToInt32(inputValue + 23.5m);
        }

        public int ModifyNumber(string inputValue)
        {
            return Convert.ToInt32(inputValue) + 8;
        }
    }
}
