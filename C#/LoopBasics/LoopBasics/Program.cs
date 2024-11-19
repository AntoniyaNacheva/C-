
int[,] intArray =
          {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
          };


int sum = 0;

for (int i = 0; i < 3; i++)
{
    sum = intArray[i, 0] + intArray[i, 1] + intArray[i, 2];
    Console.WriteLine(sum);
}

Console.ReadKey();


/*
int[,,] array3DDeclaration = new int[3, 3, 3];

string[,,] simple3DArray =
{
    {
         {"000", "001"},
         {"010", "011"}
    },
    {
         {"100", "101"},
         {"110", "111"}
    },
     {
         {"200", "201"},
         {"210", "211"}
    }
};

simple3DArray[2, 1, 0] = "Hi, what's up?";

Console.WriteLine(simple3DArray[2,1,0]);

Console.ReadKey();
*/



/*
int[,] array2DDeclaration = new int[3, 3];
// [0] [0] [0]
// [0] [0] [0]
// [0] [0] [0]

int[,,] array3DDeclaration = new int[3, 3, 3];
// cube -> x, y, z

int[,] array2DInizilized = { {1, 2}, {3, 4} };
// [1] [2]
// [3] [4]

//Console.WriteLine(array2DInizilized[1, 0]);

//array2DInizilized[1,0] = 5;
//Console.WriteLine(array2DInizilized[1, 0]);

string[,] ticTacToeField =
{
    {"O", "X", "X" },
    {"O", "O", "X" },
    {"X", "X", "O" }
};

//Console.WriteLine(ticTacToeField[1, 2]);

string[,] understandingIndexes =
{
    {"0,0", "0,1", "0,2" },
    {"1,0", "1,1", "1,2" },
    {"2,0", "2,1", "2,2" }
};

Console.WriteLine(understandingIndexes[1, 2]);


Console.ReadKey();
*/



/*
string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

foreach (string day in weekDays)
{
    Console.WriteLine(day);
}

Console.ReadKey();
*/


/*
int[] myIntArray = new int[5];
int[] myIntArray1 = {5, 6, 7, 8};

string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

Console.WriteLine("Today is " + weekDays[0]);


myIntArray[0] = 5;
myIntArray[1] = 12;
myIntArray[2] = 13;
myIntArray[3] = 14;
myIntArray[4] = 15;

Console.WriteLine(myIntArray[0]);

Console.ReadKey();
*/


/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);

    if (i == 3)
    {
        //Console.WriteLine("Enough");
        //break;
        continue;
    }
    Console.WriteLine(i);
    //Console.WriteLine("If not continued");
}

Console.ReadKey();
*/


/*
int currentScore;
int sum = 0;
int counter = 0;

do
{
    Console.WriteLine("Enter your students score. Enter -1 to finish.");
    currentScore = int.Parse(Console.ReadLine());

    if (currentScore != -1)
    {
        sum += currentScore;
        counter++;
    }
}
while (currentScore != -1);

int average = sum / counter;

Console.WriteLine("The average is: " + average);

Console.ReadKey();
*/


/*
int number;

do
{
    Console.WriteLine("Enter a positive whole number");
    number = int.Parse(Console.ReadLine());
}
while (number <= 0);

Console.WriteLine("Finally!");
Console.ReadKey();
*/


/*
Console.WriteLine("Welcome to the Adventure Game!");

Console.WriteLine("Enter your character's name: ");
string playerName = Console.ReadLine();

Console.WriteLine("Choose your character type (Warrior, Wizard, Archer)");
string characterType = Console.ReadLine();

Console.WriteLine($"You, {playerName} the {characterType} find yourself at the edge of a dark forest!");
Console.WriteLine("Do you enter the forest or camp outside? (Enter/Camp)");

string choice1 = Console.ReadLine();

if (choice1.ToLower() == "enter")
{
    Console.WriteLine("You bravely enter the forest.");
}
else
{
    Console.WriteLine("You decide to camp out and wait for daylight.");
}

bool gameContinues = true;

while (gameContinues)
{
    Console.WriteLine("You come to a fork in the road. Go left or right?");

    string direction = Console.ReadLine();

    if (direction.ToLower() == "left")
    {
        Console.WriteLine("You find a treasure chest!");
        gameContinues = false;
    }
    else
    {
        Console.WriteLine("You encounter a wild beast!");
        Console.WriteLine("Fight or flee? (fight/flee)");

        string fightChoice = Console.ReadLine();

        if (fightChoice.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);

            if (luck > 5)
            {
                Console.WriteLine("You beat the wild beast!");
                if (luck > 8)
                {
                    Console.WriteLine("The wild beast dropped a tresure!");
                }
            }
            else
            {
                Console.WriteLine("The beast attacked you where you didn't expect it!");
                Console.WriteLine("It rammed it's tusks into your chest and you bleed out!");
                gameContinues = false;
            }
        }
    }
}
Console.WriteLine("Game over!");
Console.WriteLine("Thank you for playing the game!");

Console.ReadKey();
*/



/*
Random random = new Random();

int secretNumber = random.Next(1, 101);
int userGuess = 0;
int counter = 0;

Console.WriteLine("Guess the number between 1 and 100");

while (userGuess != secretNumber)
{
    counter++;

    Console.WriteLine("Enter your guess");
    userGuess  = int.Parse(Console.ReadLine());

    if(userGuess < secretNumber)
    {
        Console.WriteLine("Too low, try again!");
    }
    else if (userGuess > secretNumber)
    {
        Console.WriteLine("Too high, try again!");
    }
    else
    {
        Console.WriteLine("You guessed the number (" + counter + " tries)");
    }
}

Console.ReadKey();
*/



/*
Console.WriteLine("Enter go or stayo");

string userChoice = Console.ReadLine();

while (userChoice == "go")
{
    Console.WriteLine("OK");
    userChoice = Console.ReadLine();

}

Console.WriteLine("NO");

Console.ReadKey();
*/



/*
int counter = 0;

while (counter < 10)
{
    Console.WriteLine(counter);
    counter++;
}

Console.ReadKey();
*/



/*
string rocket = "     |\r\n     |\r\n    / \\\r\n   / _ \\\r\n  |.o '.|\r\n  |'._.'|\r\n  |     |\r\n ,'|  | |`.\r\n/  |  | |  \\\r\n|,-'--|--'-.|";

for (int counter = 10; counter >= 0; counter--)
{
    Console.Clear();
    Console.WriteLine("Counter is " + counter);
    Console.WriteLine(rocket);
    rocket = "\r\n" + rocket;
    Thread.Sleep(1000);
}

Console.WriteLine("The rocket has landed!");

Console.ReadKey();  
*/

