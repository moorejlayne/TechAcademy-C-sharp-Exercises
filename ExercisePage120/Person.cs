using System;
namespace ExercisePage120
{
    public class Person
    {
        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // methods
        public void SayName()
        {
            Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");
        }
    }
}
