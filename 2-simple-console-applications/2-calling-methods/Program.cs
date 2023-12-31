﻿// See https://aka.ms/new-console-template for more information

//
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, C#!");

// EXERCISE - CALL THE METHODS OF A .NET CLASS
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

// EXERCISE: RETURN VALUES AND INPUT PARAMETERS OF METHODS
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

// CHALLENGE: IMPLEMENT A METHOD OF THE MATH CLASS THAT RETURNS THE LARGER OF TWO NUMBERS
int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);