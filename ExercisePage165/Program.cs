using System;

namespace ExercisePage165
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter your age: ");
                bool numericAnswer = int.TryParse(Console.ReadLine(), out int userAge);
                // check if numeric answer
                if (!numericAnswer) throw new FormatException();
                // check if 0 or negative
                else
                {
                    if (userAge == 0) throw new ZeroAgeException();
                    if (userAge < 0) throw new NegativeAgeException();
                }
                // if reach this point, can continue

                // check if already had birthday this year
                Console.Write("Has your birthday already occurred this year? y/n: ");
                string alreadyHadBirthday = Console.ReadLine().ToLower();

                // calculate year born
                int currentYear = DateTime.Now.Year;
                if(alreadyHadBirthday=="n" || alreadyHadBirthday=="no")
                {
                    int yearBorn = currentYear - 1 - userAge;
                    Console.WriteLine("You were born in " + yearBorn + ".");
                } 
                else if (alreadyHadBirthday=="y" || alreadyHadBirthday=="yes")
                {
                    int yearBorn = currentYear - userAge;
                    Console.WriteLine("You were born in " + yearBorn + ".");
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("You entered an incorrect value.");
            }
            catch(ZeroAgeException)
            {
                Console.WriteLine("You cannot have an age of 0.");
            }
            catch (NegativeAgeException)
            {
                Console.WriteLine("You cannot have a negative age.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred.");
            }
        }
    }
}
