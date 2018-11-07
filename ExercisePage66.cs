using System;

namespace TechAcademy_Practice3
{
    class Program
    {
        static void Main()
        {
            // 1. Multiply user input by 50
            Console.WriteLine("Please enter a number: ");
            double userNum1 = Convert.ToDouble(Console.ReadLine());
            double result1 = userNum1 * 50.0;
            Console.WriteLine("Your number multipled by 50 is " + result1.ToString());

            // 2. Add 25 to user input 
            Console.WriteLine("Please enter a number: ");
            double userNum2 = Convert.ToDouble(Console.ReadLine());
            double result2 = userNum2 + 25.0;
            Console.WriteLine("Your number plus 25 is " + result2.ToString());

            // 3. Divide user input by 12.5
            Console.WriteLine("Please enter a number: ");
            double userNum3 = Convert.ToDouble(Console.ReadLine());
            double result3 = userNum3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + result3.ToString());

            // 4. Check if user input greater than 50
            Console.WriteLine("Please enter a number: ");
            double userNum4 = Convert.ToDouble(Console.ReadLine());
            bool result4 = userNum4 > 50.0;
            if(result4)
            {
                Console.WriteLine("Your number is greater than 50");
            }
            else
            {
                Console.WriteLine("Your number is not greater than 50");
            }
           
            // 5. Remainder of user input divided by 7
            Console.WriteLine("Please enter a number: ");
            double userNum5 = Convert.ToDouble(Console.ReadLine());
            double result5 = userNum5 % 7;
            Console.WriteLine("The remainder of your number divided by 7 is " + result5.ToString());

            Console.ReadLine();
        }
    }
}