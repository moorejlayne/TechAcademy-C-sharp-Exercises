using System;
using System.Collections.Generic;

namespace EmployeeExercises
{
    public class Employee<T>: Person, IQuittable
    {
        // porperties
        public int Id { get; set; }
        public List<T> Things { get; set; }


        // implement SayName method
        public override void SayName()
        {
            Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");
        }

        // implement IQuittable interface method
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has given their two weeks notice.");
        }

        //// overload == and != operator to test if Ids equal
        //public static bool operator== (Employee employee1, Employee employee2)
        //{
        //    return employee1.Id == employee2.Id;
        //}

        //public static bool operator!= (Employee employee1, Employee employee2)
        //{
        //    return employee1.Id != employee2.Id;
        //}
    }
}
