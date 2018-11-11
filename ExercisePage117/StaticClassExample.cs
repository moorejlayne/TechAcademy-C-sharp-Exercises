using System;
namespace ExercisePage117
{
    public static class StaticClassExample
    {
        // outputs string to console for user to determine whether 
        // the sentence they input is written in the passive voice. 
        // usually, if you can add "by zombies" to a sentence and still 
        // have it make sense, the sentence is in passive voice
        public static void TestPassiveVoice(string userInput)
        {
            Console.WriteLine(userInput + " by zombies.");
        }

    }
}
