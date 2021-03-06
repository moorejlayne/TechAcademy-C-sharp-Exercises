﻿using System;
namespace ExercisePage126new
{
    public class Employee : Person, IQuittable
    {
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
    }
}
