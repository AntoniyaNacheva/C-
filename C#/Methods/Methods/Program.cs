
int myResult;

int AddTwoValues(int value1, int value2)
{
    int result = value1 + value2;   
    return result;
}
int SubstractTwoValues(int value1, int value2)
{
    int result = value1 - value2;
    return result;
}

Console.WriteLine("Enter a number, I'll add 10 to it!");
int num1 = int.Parse(Console.ReadLine());

//myResult = AddTwoValues(num1, 10);
myResult = SubstractTwoValues(num1, 10);

Console.WriteLine(myResult);

Console.ReadKey();  