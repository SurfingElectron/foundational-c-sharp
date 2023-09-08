// CONTROL VARIABLE SCOPE AND LOGIC USING CODE BLOCKS IN C# 

// EXERCISE: CODE BLOCKS AND VARIABLE SCOPE
bool flag = true;
int value = 10;

if (flag)
{
    value = 20;
    Console.WriteLine($"Inside of code block: {value}");
}

Console.WriteLine($"Outside of code block: {value}");


// EXERCISE: REMOVE CODE BLOCKS FROM IF STATEMENTS
string name = "steve";
if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");


// EXERCISE: COMPLETE A CHALLENGE ACTIVITY USING VARIABLE SCOPE
int[] numbers = { 4, 8, 15, 16, 23, 42 };

int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
       found = true;
}

if (found) 
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
