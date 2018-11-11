using System;
using System.Collections.Generic;


namespace ExercisePage120
{
    class Program
    {
        public static void Main(string[] args)
        {

            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();

            Console.ReadLine();
        }

    }
}
