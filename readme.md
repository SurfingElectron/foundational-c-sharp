# Get started with C#
This is a repo to store my progress through Microsoft's foundational C# certification.

## Topics
### Part 1: Write your first code using C#
- Get started by writing code examples to learn the basics of the C# syntax. 
- Use data in your applications by creating literal values and variable values of different data types. 
- Combine literal and variable text data that contain special characters, formatting, and Unicode into meaningful messages for the end user. 
- Learn the operators and techniques used to perform basic math operations on numeric data.
- Guided projects: Learn to develop an application that will calculate and display results based on given data. Gain experience developing an application that will calculate and display results based on given data.

### Part 2: Create and run simple C# console applications
- Use functionality in the .NET Class Library by calling methods that return values, accept input parameters, and more.
- Learn to branch your code's execution path by evaluating Boolean expressions.
- Work with sequences of related data in data structures known as arrays. Then, learn to iterate through each item in the sequence.
- Write code that is easier to read, update and support using naming conventions, comments and whitespace.
- Guided project: Gain experience developing a console app that implements arrays, foreach loops, and if statements to achieve app specifications.
- Challenge project: Demonstrate your ability to update a console app that implements arrays, foreach loops, and if statements in response to a user requested feature update.


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

### Iteration Loops
- The *for* statement: executes its body while a specified Boolean expression evaluates to true.
- The *foreach* statement: enumerates the elements of a collection and executes its body for each element of the collection.
- The *do-while* statement: conditionally executes its body one or more times.
- The *while* statement: conditionally executes its body zero or more times.

## Resources
- https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/