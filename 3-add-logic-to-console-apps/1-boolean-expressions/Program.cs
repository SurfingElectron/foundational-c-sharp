// EVALUATE BOOLEAN EXPRESSIONS TO MAKE DECISIONS IN C# 

// EXERCISE: EVALUATE AN EXPRESSION
// Equality evaluations: Equal to
Console.WriteLine("Equality evaluations: Equal to");
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Equality evaluations: Not equal to
Console.WriteLine("Equality evaluations: Not equal to");
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");

// Equality evaluations: Greater and lesser than
Console.WriteLine("Equality evaluations: Greater and lesser than");
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

// Equality evaluations: Negation
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

// EXERCISE: IMPLEMENT THE CONDITIONAL OPERATOR

// This takes the form:
// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");


// EXERCISE: COMPLETE A CHALLENGE ACTIVITY USING CONDITIONAL OPERATORS
Random coinFlip = new Random();
int coinResult = coinFlip.Next(0,2);
Console.WriteLine($"Result: {(coinResult == 0 ? "Tails" : "Heads")}");

// EXERCISE: COMPLETE A CHALLENGE ACTIVITY USING BOOLEAN EXPRESSIONS
string permission = "bob";
int level = 100;

if (permission.Contains("Admin"))
    Console.WriteLine(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.");
else if (permission.Contains("Manager"))
    Console.WriteLine(level > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.");
else
    Console.WriteLine("You do not have sufficient privileges.");