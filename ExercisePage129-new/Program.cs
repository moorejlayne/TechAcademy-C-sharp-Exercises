using System;
using System.Collections.Generic;

namespace ExercisePage129new
{
    class Program
    {
        public static void Main(string[] args)
        {
            // insatntiate employees
            Employee employee1 = new Employee { FirstName = "John", LastName = "Does", Id = 123 };
            Employee employee2 = new Employee { FirstName = "Jane", LastName = "Does", Id = 126 };
            Employee employee3 = new Employee { FirstName = "Andrea", LastName = "Firth", Id = 126 };

            // check overridden methods
            Console.WriteLine("Employee1==Employee2: " + (employee1 == employee2)); // should be false
            Console.WriteLine("Employee1!=Employee2: " + (employee1 != employee2)); // should be true
            Console.WriteLine("Employee2==Employee3: " + (employee2 == employee3)); // should be true
            Console.WriteLine("Employee2!=Employee3: " + (employee2 != employee3)); // should be false
        }
    }
}
