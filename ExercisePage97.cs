using System;
using System.Text;

class Program
{
    static void Main()
    {
        // concatenate 3 strings together
        string str1 = "This is ";
        string str2 = "a concatenated ";
        string str3 = "string.";
        string strConc = str1 + str2 + str3;
        Console.WriteLine(strConc);

        // convert string to uppercase
        string STRCONC = strConc.ToUpper();
        Console.WriteLine(STRCONC);

        // Create Stringbuilder to build paragraph of text, one sentence at a time.
        StringBuilder quote = new StringBuilder();
        quote.Append("Listeners, listeners out there, listeners out in the vacant night clinging to my voice as a simulacrum of companionship. ");
        quote.Append("Remember: fear is just consciousness, plus life. ");
        quote.Append("Regret is an attempt to avoid what has already happened. ");
        quote.Append("Toast is bread, held under direct heat until crisp. ");
        quote.Append("The present tense of regret is indecision. ");
        quote.Append("The future tense of fear is either comedy or tragedy. ");
        quote.Append("And the past tense of toast is toasted. ");
        quote.Append(" --Welcome to Night Vale");
        Console.WriteLine(quote);

        Console.Read();
    }
}