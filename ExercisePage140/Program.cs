using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeExercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            // create list of 10 employees
            List<Employee> employees = new List<Employee>();
            string[] employeeFirstNames = new string[] { "James", "Joe", "Justine", "Julie", "Jules", "Jeremiah", "Jess", "Joe", "Joe", "Jane" };
            string[] employeeLastNames = new string[] { "Gordon", "Doe", "Kravitz", "Monroe", "Verne", "Robert", "James", "McCarthy", "Smith", "Johnson" };
            int[] employeeIDs = new int[] { 502, 301, 2, 45, 4, 59, 21, 1, 6, 10 };
            for (int i = 0; i < 10; i++)
            {
                Employee employee = new Employee();
                employee.FirstName = employeeFirstNames[i];
                employee.LastName = employeeLastNames[i];
                employee.Id = employeeIDs[i];
                employees.Add(employee);
            }

            // new list of all employees with first name "Joe", using foreach
            List<Employee> employeesNamedJoe = new List<Employee>();
            foreach(Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    employeesNamedJoe.Add(employee);
                }
            }
            // To Check: 
            //Console.WriteLine(employeesNamedJoe.Count()); // 3
            //foreach (Employee employee in employeesNamedJoe)
            //{
            //    employee.SayName();
            //}

            // new list of all employees with first name "Joe", using lambda exp
            List<Employee> employeesNamedJoeLambda = employees.Where(x => x.FirstName == "Joe").ToList();
            // To Check: 
            //Console.WriteLine(employeesNamedJoeLambda.Count()); // 3
            //foreach(Employee employee in employeesNamedJoeLambda)
            //{
            //    employee.SayName();
            //}

            // new list of all employees with Id > 5
            List<Employee> idGreaterThan5 = employees.Where(x => x.Id < 5).ToList();
            // To Check: 
            //Console.WriteLine(idGreaterThan5.Count());
            //foreach (Employee employee in idGreaterThan5)
            //{
            //    employee.SayName();
            //    Console.WriteLine("ID: " + employee.Id);
            //}

            Console.ReadLine();
        }
    }
}
