using System;
namespace ExercisePage124
{
    public class Employee : Person
    {

        // implement SayName method
        public override void SayName()
        {
            Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");
        }
    }
}
