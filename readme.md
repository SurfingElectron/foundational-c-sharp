# Get started with C#
This is a repo to store my progress through Microsoft's foundational C# certification.

## Topics
### Part 1: Write your first code using C#
- Get started by writing code examples to learn the basics of the C# syntax. 
- Use data in your applications by creating literal values and variable values of different data types. 
- Combine literal and variable text data that contain special characters, formatting, and Unicode into meaningful messages for the end user. 
- Learn the operators and techniques used to perform basic math operations on numeric data.
- Projects: Learn to develop an application that will calculate and display results based on given data. Gain experience developing an application that will calculate and display results based on given data.

### Part 2: Create and run simple C# console applications
### Part 3: Add logic to C# console applications
### Part 4: Work with variable data in C# console applications
### Part 5: Create methods in C# console applications
### Part 6: Debug C# console applications

## Notes
### Floating-point, double, and decimal data type precision
Float Type  |  Precision     |    Suffix
------------|----------------|----------
float       | ~6-9 digits    |    f
double      | ~15-17 digits  |  (none)
decimal     |  28-29 digits  |    m

### Var
In C#, variables are assigned a type by the compiler regardless of whether you use the actual data type name or allow the compiler to imply the data type. In other words, the type is locked in at the time of declaration and therefore will never be able to hold values of a different data type.

### File paths
C# uses the backslash for escape sequences, so file paths need to use a double backslash. For example:

```
Console.WriteLine("c:\\source\\repos");
```

would output 

```
c:\source\repos
```

## Resources
- https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/