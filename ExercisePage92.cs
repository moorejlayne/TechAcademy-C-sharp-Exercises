using System;

namespace TechAcademy_Practice6
{
    class Program
    {
        static void Main()
        {
            // header
            Console.WriteLine("Welcome to Package Express. Please folow the instructions below." + Environment.NewLine);

            // get weight
            Console.Write("Please enter the package weight: ");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // check that within weight requirements
            if (weight>50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                // get dimensions
                Console.Write("Please enter the package width: ");
                decimal width = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Please enter the package height: ");
                decimal height = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Please enter the package length: ");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                // check dimensions
                decimal dims = width + length + height;
                if (dims>50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    decimal quote = (dims * weight / 100.00m);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00") + Environment.NewLine + "Thank you.");
                }
            }
            Console.ReadLine();
        }
    }
}
