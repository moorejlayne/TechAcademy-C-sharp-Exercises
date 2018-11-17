using System;
namespace ExercisePage126new
{
    public abstract class Person
    {
        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // method
        public abstract void SayName();
    }
}
