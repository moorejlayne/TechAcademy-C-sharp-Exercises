using System;
namespace ExercisePage165
{
    public class ZeroAgeException : Exception
    {
        public ZeroAgeException()
            : base() { }
        public ZeroAgeException(string message)
            : base() { }
    }
}
