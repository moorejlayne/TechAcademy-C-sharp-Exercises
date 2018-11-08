using System;

class Program
{
    static void Main()
    {
        // The user sees a monster!
        Console.WriteLine("You are walking down a path. Ahead, you see a monster.");
        Console.Write("Would you like to attack the monster? Y/N: ");
        bool attackMonster = (Console.ReadLine() == "Y") ? true : false;

        // While the user chooses not to attack the monster, continue presenting the user with new monsters.
        while(!attackMonster)
        {
            Console.WriteLine("You sneak past the monster and continue down the path. After some time, you see another monster ahead.");
            Console.Write("Would you like to attack the monster? Y/N: ");
            attackMonster = Console.ReadLine() == "Y" ? true : false;
        }

        // The user attacks! 
        Random rnd = new Random();
        int monsterHP = rnd.Next(1, 50);
        int strike = rnd.Next(1, 20);

        // This could easily have been written as a regular while loop, but this works too, and I can't think of a better example.
        do
        {
            monsterHP -= strike;
            Console.WriteLine("Your strike dealt " + strike + " damage!");
            Console.WriteLine("The monster is at " + monsterHP + " hit points.");
            Console.WriteLine("Press a key to continue!");
            Console.ReadLine();
            strike = rnd.Next(1, 20);
        } while (strike < monsterHP);
        Console.WriteLine("Your final strike slayed the monster!");

        Console.ReadLine();
    }
}