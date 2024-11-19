using System.Diagnostics;

namespace TryCatchExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            void HandleMultipleExceptions(string numberString, int index)
            {
                int[] numbers = { 1, 2, 3 };

                try
                {
                    int number = int.Parse(numberString);
                    Console.WriteLine(numbers[index]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index out of range.");
                }
            }
            */


            /*
            Console.WriteLine("App running before the try block");
            try
            {
                LevelOne();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in Main: " + ex.Message);
            }

            Console.WriteLine("App is still running!");

            //Console.WriteLine("Enter your age");
            //GetUserAge(Console.ReadLine());

            /*
            int result = 0;

            Debug.WriteLine("Main method is running");

            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = int.Parse(Console.ReadLine());

                //int num1 = 0;
                int num2 = 2;

                result = num2 / num1;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Don't divide by zero! " + ex.Message);
                result = 10;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("I told you to enter a number! " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Number too high!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                //Debug.WriteLine(ex.StackTrace);
                //Debug.WriteLine(ex.ToString());

            }
            finally
            {
                // Code to cleanup or finalize
                // Ideal for cleaning up resources
                // like closing file streams or database connections

                Console.WriteLine("This always executes");
            }

            Console.WriteLine("Result: " + result);
            */

            Console.ReadKey();
        }

        /*
        static void LevelOne()
        {
            LevelTwo();
        }

        static void LevelTwo()
        {
            throw new Exception("Something went wrong!");
        }

        /*
        static int GetUserAge(string input)
        {
            int age;
            if (!int.TryParse(input, out age))
            {
                throw new Exception("You didn't enter a valid age.");
            }
            if (age < 0 || age > 120)
            {
                throw new Exception("Your age must be between 0 and 120.");
            }

            return age;
        }
        */
    }
}
