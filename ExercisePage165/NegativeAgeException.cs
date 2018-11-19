using System;
namespace ExercisePage165
{
    public class NegativeAgeException : Exception
    {
        public NegativeAgeException() 
            : base() { }
        public NegativeAgeException(string message) 
            : base(message) { }
    }
}
