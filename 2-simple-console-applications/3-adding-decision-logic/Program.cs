// ADD DECISION LOGIC TO YOUR CODE USING 'IF', 'ELSE', AND 'ELSE IF' STATEMENTS IN C# 

//EXERCISE: CREATE DECISION LOGIC WITH IF STATEMENTS
Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// EXERCISE: CREATE NESTED DECISION LOGIC WITH IF, ELSE IF, AND ELSE
// Evaluating for doubles and triple dice rolls
if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        total +=6;
        Console.WriteLine("You rolled triples! +6 bonus to total!");
    }
    else
    {
        total += 2;
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
    }

}

// Evaluating the score
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >=10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total ==7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}


// EXERCISE: COMPLETE A CHALLENGE ACTIVITY TO APPLY BUSINESS RULES
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

daysUntilExpiration = 11;

// Check discount percentage
if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
}
else if (daysUntilExpiration > 1)
{
    discountPercentage = 10;
}

// Print renewal message
if (daysUntilExpiration <= 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}