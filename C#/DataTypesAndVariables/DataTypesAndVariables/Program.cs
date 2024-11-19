//string s1 = "this is a \"string\" with a backslash \\ and a colon : ";
//Console.WriteLine(s1);

//Console.WriteLine("Hello\n\tWorld!");


//Console.ReadKey();

//-------------------------------------------------------------------------------------


//// <Characters and Strings>
//char myfavouriteChar = 'a';

//int num = 10;
//double price = 19.95;
//string name = "Frank";

//Console.WriteLine($"The number is {num}");

//Console.WriteLine("The number is " + num);

//Console.WriteLine("The number is {0}, the price is {1} and the name is {2}", num, price, name);


//Console.ReadKey();

//// </Characters and Strings>


//-------------------------------------------------------------------------------------


//// <Operators and order of Evaluation>

//int num1 = 5;
//int num2 = int.Parse(Console.ReadLine());

//Console.WriteLine("Addition num1 + num2 = " + num1 + num2);
//Console.WriteLine("Subtraction num1 - num2 = " + (num1 - num2));
//Console.WriteLine("Multiplication num1 * num2 = " + num1 * num2);
//Console.WriteLine("Division num1 / num2 = " + num1 / num2);

//double sum = Convert.ToDouble(num1) / Convert.ToDouble(num2);
//Console.WriteLine(sum);


//Console.ReadKey();

//// </Operators and order of Evaluation>


//-------------------------------------------------------------------------------------


//// <implicitely typed variable>

//var myFavouriteGenre = "LitRPGs";

//var myFavouriteNumber = 13;

//var yourFavouriteNumber = 14;

//int ourFavouriteNumber = myFavouriteNumber + yourFavouriteNumber;

//Console.WriteLine(ourFavouriteNumber);

//Console.ReadKey();

//// </implicitely typed variable>


//-------------------------------------------------------------------------------------



//// <conversion helpers Parse and Convert>

//string numberString= "123";
//int myInt = int.Parse(numberString);
//Console.WriteLine($"myInt is {myInt}");


//string myBoolString = "true";
//bool myBoll = Convert.ToBoolean(myBoolString);
//Console.WriteLine($"myBool is {myBoll}");


//Console.ReadKey();

//// </conversion helpers Parse and Convert>


//-------------------------------------------------------------------------------------



//// <explicit conversion>

//long myLong = 5596596;
//int myInt = (int)myLong;

//Console.WriteLine(myInt);

//float myFloat = 123.123f;
//double myDouble = 13.66656565;

//myFloat = (float)myDouble;

//Console.WriteLine(myFloat);


//int myInt1;
//double myDouble1 = 13.5;
//myInt1 = (int)myDouble1;

//Console.WriteLine(myInt1);


//Console.ReadKey();

//// </explicit conversion>


//-------------------------------------------------------------------------------------


//// <implicit conversion>

//// YES
//int myInt = 5596596566;
//double myDouble = myInt;

//long myLong = myInt;

//float myFloat = 123.123f;

//myDouble = myFloat;

//// NO
////myInt = myLong;

////float myFloat1 = myDouble;


//Console.ReadKey();

//// </implicit conversion>


//-------------------------------------------------------------------------------------



//// <calculator>
//using System.Globalization;

//double myNumber1 = 0.0;
//double myNumber2 = 0.0;

//Console.WriteLine("Enter a number!");

//string userInput = Console.ReadLine();

//myNumber1 = double.Parse(userInput, CultureInfo.InvariantCulture);

//Console.WriteLine("Enter a number!");
//userInput = Console.ReadLine();

//myNumber2 = double.Parse(userInput, CultureInfo.InvariantCulture);

//double sum = myNumber1 + myNumber2;
//sum = Math.Round(sum, 2);

//Console.WriteLine($"The result of {myNumber1
//    .ToString(CultureInfo.InvariantCulture)} and {myNumber2
//    .ToString(CultureInfo.InvariantCulture)} is {sum
//    .ToString(CultureInfo.InvariantCulture)}");

//Console.ReadKey();

//// </calculator>


//-------------------------------------------------------------------------------------


//string petName = "Daisy";
//Console.WriteLine($"my pet is {petName}");

//petName = "Barky";
//Console.WriteLine($"my pet is {petName}");

//Console.ReadKey();

////<summary>
//// this is a method
///
//void Check()
//{

//}

//Check();

////</summary>
