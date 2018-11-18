using System;

class Program
{
    public static void Main(string[] args)
    {
        Number number = new Number { Amount = 1205.02m };
        Console.WriteLine("Number amount is " + number.Amount.ToString("0.00") + ".");
        Console.ReadLine();   
    }

    public struct Number
    {
        public decimal Amount { get; set; }
    }
}
