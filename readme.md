# Foundational C# with Microsoft
This is a repo to store my progress through Microsoft's foundational C# certification.

## Topics
### Write your fmyst C# code
The goal was to write code which displayed simple messages to an output console while familiarizing myself with the syntax. I wrote my first lines of code using basic C# syntax. I learned two techniques for displaying literal-string data to the console. I also learned what to look for when I come across an error in my code. And lastly, I identified C# syntax elements like classes and methods, and the purpose of several special symbols that are known as operators. 

### Store and retrieve data using literal and variable values in C#
My goal was to display a formatted message using a combination of literal and variable values.

Using basic C# syntax, I created literal values of several different data types. I declared variables, and also set and retrieved values from those variables. I also initialized variables, and learned how to use the var keyword to implicitly type a variable by inferring the type from the initialization.

### Perform basic string formatting in C#
My goal was to write code that formats strings with special characters, such as double quotes, new lines, tabs, and other white space, as well as unicode characters. I also combined strings using two different techniques.

Using character escape sequences, I added special characters in my literal strings by either using special escaping sequences or using verbatim strings. I added Unicode characters from other language sets like Japanese Kanji and Russian Cyrillic in my literal strings. I used simple string concatenation with the + symbol, and upgraded to string interpolation for combining values into a string template.

Without the ability to format my output, I would be severely restricted in what kinds of information I could present to the user. However, now I can provide my users with sophisticated instructions and feedback with a wide variety of formatting, symbols, and languages.

### Perform basic operations on numbers in C#
My goal was to perform basic operations on string and numeric data. As a coding challenge, I converted a value from one unit of measure (Fahrenheit) to another (Celsius) and displayed the result in a formatted message.

I used various operators to perform basic string and mathematical operations. I learned how some symbols are reused (overloaded) as different operators, depending on the context. I learned how the data types of the operands influence the meaning of the operators. Finally, I learned how to change the data type of a value using the cast operator.

### Guided project - Calculate and print student grades
My goal was to build an application that takes the assignment scores for students in a class, calculates their grade, and displays the results.

To accomplish this, I declared and assigned values to variables of different data types, performed numeric operations, and used type casting to achieve accurate results. I also used Console.WriteLine() and character escape sequences to format the output. By breaking the problem down, I were able to build a solution using the skills I learned in the previous modules. 

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