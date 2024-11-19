namespace OldStyle
{
    internal class Program
    {
        static int myResult;
        static void Main(string[] args)
        {
            //int myResult;

            Console.WriteLine("Enter a number, I'll add 10 to it!");
            int num1 = int.Parse(Console.ReadLine());

            //Program myProgram = new Program();
            //myResult = myProgram.AddTwoValues(num1, 10);

            myResult = AddTwoValues(num1, 10);
            //myResult = SubstractTwoValues(num1, 10);

            Console.WriteLine(myResult);

            Console.ReadKey();
        }
        static int AddTwoValues(int value1, int value2)
        {
            myResult = value1 + value2;
            return myResult;
        }
        static int SubstractTwoValues(int value1, int value2)
        {
            myResult = value1 - value2;
            return myResult;
        }
    }
}

