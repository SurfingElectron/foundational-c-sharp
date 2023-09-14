// ADD LOOPING LOGIC TO YOUR CODE USING THE *DO-WHILE* AND *WHILE* STATEMENTS IN C#

//  EXERCISE: CREATE DO AND WHILE ITERATION LOOPS
/*
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

do
{
    current = random.Next(1, 11);

    if (current >= 8)
        continue;
    
    Console.WriteLine(current);
} while (current !=7);

*/

// EXERCISE: COMPLETE A CHALLENGE ACTIVITY USING DO AND WHILE ITERATION STATEMENTS
/*
- The hero and the monster will start with 10 health points.
- All attacks will be a value between 1 and 10.
- The hero will attack first.
- Print the amount of health the monster lost and their remaining health.
- If the monster's health is greater than 0, it can attack the hero.
- Print the amount of health the hero lost and their remaining health.
- Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
- Print the winner.

OUTPUT FORM
Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Hero wins! || Monster wins!


int heroHealth = 10;
int monsterHealth = 10;
Random attack = new Random();

do
{
    int attackDamage = attack.Next(1, 11);
    monsterHealth -= attackDamage;
    Console.WriteLine($"Monster was damaged and lost {attackDamage} health and now has {monsterHealth} health.");
    if (monsterHealth <= 0)
        continue;

    attackDamage = attack.Next(1, 11);
    heroHealth -= attackDamage;
    Console.WriteLine($"Hero was damaged and lost {attackDamage} health and now has {heroHealth} health.");

} while (heroHealth > 0 && monsterHealth > 0);
Console.WriteLine(monsterHealth > heroHealth ? "Monster wins!" : "Hero wins!");
*/
// EXERCISE: COMPLETE A CHALLENGE ACTIVITY TO DIFFERENTIATE BETWEEN DO AND WHILE ITERATION STATEMENTS
// TASK ONE
/*
string? readResult;
string enteredValue;
int numberValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do 
{
    readResult = Console.ReadLine();

    if (readResult != null)
        enteredValue = readResult;

    validNumber = int.TryParse(readResult, out numberValue);
    if (!validNumber)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again.");
        continue;
    }

    if (numberValue < 5 || numberValue > 10)
        Console.WriteLine($"You entered {numberValue}. Please enter a number between 5 and 10.");

} while (numberValue < 5 || numberValue > 10);
Console.WriteLine($"Your input value ({numberValue}) has been accepted");


// TASK TWO 

string? readResult;
string roleEntered = "";
bool validRole = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

    readResult = Console.ReadLine();

    if (readResult != null) 
        roleEntered = readResult.Trim().ToLower();

    if (roleEntered == "administrator" || roleEntered == "manager" || roleEntered == "user")
        validRole = true;
    else
        Console.Write($"The role name that you entered, \"{roleEntered}\" is not valid. ");


} while (!validRole);

Console.WriteLine($"Your input value ({roleEntered}) has been accepted");
*/

// TASK THREE
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation;
string myString;

for (int i = 0; i < myStrings.Length; i++)
{    
    myString = myStrings[i];
    periodLocation =  myString.IndexOf(".");
    string workingSentence;
  
        while (periodLocation != -1)
        {
            workingSentence = myString.Remove(periodLocation);

            myString = myString.Substring(periodLocation + 1).TrimStart();

            periodLocation = myString.IndexOf(".");

            Console.WriteLine(workingSentence);
        }
    Console.WriteLine(myString);
}