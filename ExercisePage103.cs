using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // 1. Add user input to array of strings
        string[] strArr = { "First input:", "Second input:", "Third input:" };
        for(int i=0; i < strArr.Length; i++)
        {
            Console.WriteLine("Please input some text.");
            string userText = Console.ReadLine();
            strArr[i] = strArr[i] + " " + userText;
        }
        for(int j=0; j<strArr.Length; j++)
        {
            Console.WriteLine(strArr[j]);
        }
        Console.ReadLine();


        //// 2. Infinite loop
        //int k = 1;
        //while(k>0) 
        //{
        //    Console.WriteLine("This was a bad idea...");
        //}


        // 3. Fix infinite loop
        int k = 1;
        while(k>0)
        {
            k++;
            Console.WriteLine("This was a bad idea...");
            if(k>15)
            {
                Console.WriteLine("Phew.");
                break;
            }
        }


        // 4. Create loop with <
        for(int l=0; l<10; l++)
        {
            Console.WriteLine(l);
        }


        // 5. Create loop with <=
        for(int m=10; m<=20; m++)
        {
            Console.WriteLine("The value of m is: " + m + ".");
        }


        // 6-8.
        // Create List of strings where each item unique. Ask user to select text to search for in List. Create loop 
        // that iterates through list and displays index of array that contains matching text.
        List<string> Colors = new List<string>() { "green", "yellow", "blue", "gold" };
        Console.WriteLine("Please choose a color.");
        string userColor = Console.ReadLine();
        int idx = -1;
        for(int c=0; c<Colors.Count; c++)
        {
            if (Colors[c] == userColor)
            {
                Console.WriteLine("The color is located at index " + c + ".");
                idx = c;
                break;
            }
        }
        if (idx == -1)
        {
            Console.WriteLine("The color does not exist in the list.");
        }


        // 9-10.
        // Create list with non-unique values, search list for user input, 
        // and return indices of array that matches input.
        List<string> Monsters = new List<string>() { "Gnoll", "Demon", "Demon", "Demon", "Gnoll", "Devil", "Devil", "Werewolf", "Goblin" };
        Console.WriteLine("Input a monster: ");
        string userMonster = Console.ReadLine();
        List<int> monsterIndex = new List<int>();
        for (int m = 0; m < Monsters.Count; m++)
        {
            if (Monsters[m] == userMonster)
            {
                monsterIndex.Add(m);
            }
        }
        if(monsterIndex.Count>0)
        {
            Console.WriteLine("That monster exists at the following location(s):");
            foreach(int index in monsterIndex)
            {
                Console.WriteLine(index);
            }
        }
        else
        {
            Console.WriteLine("That monster does not exist in the list.");
        }


        // 11. Create list with >= 2 identical strings. 
        // Use foreach to evaluate each item in the list and dispaly message showing string
        // and whether or not it has already appeared in the list. 
        List<string> Animals = new List<string>() { "cat", "cat", "dog", "dragon", "dragon", "narwhal", "unicorn", "narwhal" };

        // create list of items that have already been displayed
        List<string> DisplayedAnimals = new List<string>();

        // iterate through list
        foreach(string animal in Animals)
        {

            // display item
            Console.WriteLine(animal);

            // check if value has already been displayed
            bool alreadyDisplayed = false;
            foreach (string displayedAnimal in DisplayedAnimals)
            {
                if(displayedAnimal==animal)
                {
                    alreadyDisplayed = true;
                }
            }

            // display whether item has already been displayed
            Console.WriteLine("Animal already displayed? " + alreadyDisplayed + ".");

            // update alreadyDisplayed list
            if(!alreadyDisplayed)
            {
                DisplayedAnimals.Add(animal);
            }

        }
        Console.ReadLine();
    }
}