using System;

namespace ExercisePage124
{
    class Program
    {
        public static void Main(string[] args)
        {
            // instantiate employee and call SayName
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();


            Console.ReadLine();
        }
    }
}
