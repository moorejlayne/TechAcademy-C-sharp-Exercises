using System;
using System.Collections.Generic;

namespace EmployeeExercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            // for Exercise Page 131
            Employee<string> employee1 = new Employee<string>() { FirstName = "John", LastName = "Doe", Id = 394 };
            List<string> EmployeeThings1 = new List<string>() { "cat", "dog", "hamster" };
            employee1.Things = EmployeeThings1;

            Employee<int> employee2 = new Employee<int>() { FirstName = "Jane", LastName = "Doe", Id = 235 };
            List<int> EmployeeThings2 = new List<int>() { 9, 145, 42 };
            employee2.Things = EmployeeThings2;

            employee1.SayName();
            Console.WriteLine("Things:");
            foreach(string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            employee2.SayName();
            Console.WriteLine("Things:");
            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }

        }
    }
}
