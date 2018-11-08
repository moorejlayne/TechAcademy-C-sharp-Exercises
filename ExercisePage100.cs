using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // display value of string array at user selected index
        string[] beasts = { "dragon", "griffon", "manticore", "pegasus", "goblin" };
        Console.Write("Please select a number between 1 and " + beasts.Length + ": ");
        int userIndex = Convert.ToInt32(Console.ReadLine());
        if(userIndex > beasts.Length || userIndex <=0)
        {
            Console.WriteLine("You have chosen an inappropriate value.");
        }
        else
        {
            Console.WriteLine("You chose a " + beasts[userIndex - 1] + "!");
        }

        // display value of int array at user selected index
        int[] arr1 = { 1, 5, 6, 2, 36, 89, 1939 };
        Console.Write("Please select an index between 0 and " + (arr1.Length - 1) + ": ");
        int userIndex2 = Convert.ToInt32(Console.ReadLine());
        if (userIndex2 >= arr1.Length || userIndex2 <0)
        {
            Console.WriteLine("You have chosen an inappropriate value.");
        }
        else
        {
            Console.WriteLine("The value at the chosen index is " + arr1[userIndex2] + ".");
        }


        // create and access List of strings
        List<string> strList = new List<string>() { "green", "yellow", "blue", "gold" };
        Console.Write("Please select an index between 0 and " + (strList.Count - 1) + ": ");
        int userIndex3 = Convert.ToInt32(Console.ReadLine());
        if(userIndex3 >= strList.Count || userIndex3<0)
        {
            Console.WriteLine("You have chosen an inappropriate value.");
        }
        else
        {
            Console.WriteLine("The color at the chosen index is " + strList[userIndex3] + ".");
        }

        Console.Read();
    }
}