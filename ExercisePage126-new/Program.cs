using System;
using System.Collections.Generic;

namespace ExercisePage126new
{
    class Program
    {
        public static void Main(string[] args)
        {
            // instantiate employee and call SayName
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            employee.Quit();

            // create object of type iQuittable and call Quit method
            IQuittable quittable = new Employee { FirstName = "John", LastName = "Doe" };
            quittable.Quit();

            Console.ReadLine();
        }
    }
}
