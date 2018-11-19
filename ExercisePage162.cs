using System;
using System.Collections.Generic;

namespace CsharpExercises
{

    public class ExercisePage162
    {
        public static void Main(string[] args)
        {
            const string heroName = "Link";
            var numberOfMonsters = 100;

            List<string> goblinDiet = new List<string>() { "rats", "chickens" };
            List<string> dragonDiet = new List<string>() { "sheep", "knights", "goblins" };
            Monster goblin = new Monster("Goblin", goblinDiet, false, 20);
            Monster dragon = new Monster("Dragon", dragonDiet);

            Console.WriteLine("The hero, {0}, is off to fight {1} monsters! \n", heroName, numberOfMonsters);

            List<Monster> Monsters = new List<Monster> { goblin, dragon };
            foreach (Monster monster in Monsters) 
            {
                Console.WriteLine("The hero finds a {0}.", monster.Name);
                Console.WriteLine("{0}s eat these things:", monster.Name);
                foreach(string item in monster.Eats)
                {
                    Console.WriteLine(item);
                }
                string currentlyAsleep = (monster.IsSleeping)? "is currently" : "is not currently";
                Console.WriteLine("This {0} {1} sleeping and has an energy level of {2}. \n", monster.Name, currentlyAsleep, monster.EnergyLevel);
            }
        }
    }


    public class Monster
    {
        // constructor
        public Monster(string name, List<string> eats, bool isSleeping, int energyLevel)
        {
            Name = name;
            Eats = eats;
            IsSleeping = isSleeping;
            EnergyLevel = energyLevel;
        }

        // chained constructor
        public Monster(string name, List<string> eats) : this(name, eats, true, 100) { }

        // properties
        public string Name { get; set; }
        public List<string> Eats { get; set; }
        public bool IsSleeping { get; set; }
        public int EnergyLevel { get; set; }

    }
}
