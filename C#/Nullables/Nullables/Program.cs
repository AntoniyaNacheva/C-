namespace Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? age = null; // int? is nullable int
            int myAge = 35;

            if (age.HasValue)
            {
                Console.WriteLine("Age is: " + age.Value);
            }
            else
            {
                int sum = age.Value + myAge;

                Console.WriteLine("Age is not specified");
            }

            Console.ReadKey();
        }
    }
}
