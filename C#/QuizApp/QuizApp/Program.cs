

Random random = new Random();
int randomNumber = random.Next(1, 11);

Console.WriteLine("Guess the number");

string inputString = Console.ReadLine();
int num = 0;

bool isNumber = int.TryParse(inputString, out num);

if (isNumber)
{
    if (num == randomNumber)
    {
        Console.WriteLine("You guessed right!");
    }
    else
    {
        Console.WriteLine("You guessed wrong!");
    }
}
else
{
    Console.WriteLine("No");
}

//num++;
//Console.WriteLine("num + 1 = " + num);


Console.ReadKey();


//-------------------------------------------------------------------------------------


/*
string question1 = "What is the capital of Germany?";
string answer1 = "Berlin";

string question2 = "What is 2 + 2?";
string answer2 = "4";

string question3 = "What color do you get by mixing blue and yellow?";
string answer3 = "Green";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();

if (userAnswer1.Trim().ToLower() == answer1.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Wrong!");
}


Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();

if (userAnswer2.Trim().ToLower() == answer2.ToLower())
{
    Console.WriteLine("Correct!");
    score += 1;
}
else
{
    Console.WriteLine("Wrong!");
}

Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();

if (userAnswer3.Trim().ToLower() == answer3.ToLower())
{
    Console.WriteLine("Correct!");
    score += 1;
}
else
{
    Console.WriteLine("Wrong!");
}

Console.WriteLine($"Your final score is {score}/3");

if (score == 3)
{
    Console.WriteLine("Excellent!");
}
else if (score > 0)
{
    Console.WriteLine("Good job!");
}
else
{
    Console.WriteLine("Try again!");
}

Console.ReadKey();
*/
