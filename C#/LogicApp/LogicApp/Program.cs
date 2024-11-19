

int month = 4;
string monthName;

if (month == 1)
{
    monthName = "January";
    month = 2;
}
else if (month == 2)
    monthName = "February";
//month = 3; -> This code is incorrect, because it works only with one line.
else if (month == 3)
    monthName = "March";
else
    monthName = "Unknown";


//switch (month)
//{
//    case 1:
//        monthName = "January";
//        break;
//    case 2:
//        monthName = "February";
//        break;
//    case 3:
//        monthName = "March";
//        break;
//    default:
//        monthName = "Unknown";
//        break;
//}

Console.WriteLine($"The month is {monthName}");

Console.ReadKey();


//-------------------------------------------------------------------------------------


// relational operator < <= > >=
/*
int num1 = 0;
int num2 = 0;
int age;
string address;
*/

/*
bool isEqual = num1 == num2;

bool isNotEqual = num1 != num2;

bool inGreater = num1 > num2;
*/

/*
Console.WriteLine("Please enter a whole number");

if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal!");

    Console.WriteLine("Please enter your age");
    age = int.Parse(Console.ReadLine());

    if (age >= 18)
    {
        Console.WriteLine("Please enter your address");
        address = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Sorry");
    }
}
else
{
    Console.WriteLine("numbers aren't equal!");
}

age = 0;
*/

/*
Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine());
bool isWithParents;

if (age >= 18)
{
    Console.WriteLine("Go Party!");
}
else if (age >= 13)
{
    Console.WriteLine("Are you with your parents?");
    string isWithParentsString = Console.ReadLine();

    if (isWithParentsString == "yes")
    {
        Console.WriteLine("Go party with your parents!");
    }
    else
    {
        Console.WriteLine("Go home");
    }
}
else if (age > 6)
{
    Console.WriteLine("Go to school!");
}
else
{
    Console.WriteLine("Go to kindergarden!");
}


//Console.WriteLine(inGreater);

Console.ReadKey();
*/


//-------------------------------------------------------------------------------------


//bool isRainy = true;
//bool hasUmbrella = true;

//if (isRainy && hasUmbrella)
//{
//    Console.WriteLine("I'm protected");
//}

//Console.ReadKey();
