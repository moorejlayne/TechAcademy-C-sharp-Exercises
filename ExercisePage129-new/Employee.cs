using System;
namespace ExercisePage129new
{
    public class Employee : Person
    {
        // properties
        public int Id { get; set; }

        // implement SayName method
        public override void SayName()
        {
            Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");
        }

        // overload == operator to test if Ids are equal
        public static bool operator== (Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        public static bool operator!= (Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }
}
