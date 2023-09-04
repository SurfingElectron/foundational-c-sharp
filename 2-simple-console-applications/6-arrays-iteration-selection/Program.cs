﻿// GUIDED PROJECT: DEVELOP FOREACH AND IF-ELSEIF-ELSE STRUCTURES TO PROCESS ARRAY DATA IN C#
using System;

// Initialize variables
// Number of assignments
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 }; 

int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

// Write the report header to the console
Console.WriteLine("Student\t\tGrade\n");

// Calculates and prints each student's numerical and letter grade
foreach (string name in studentNames)
{
    string currentStudent = name;
    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;

    // Counter for the number of assignments
    int gradedAssignments = 0;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;

    else
        continue;

    // Sum the assignments, including extra credit
    foreach (int score in studentScores)
    {
        gradedAssignments += 1; 

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;

        else
            // Extra credits - equal to 10% of an exam score
            sumAssignmentScores += score / 10; 
    }

    // Calculate the final grade score
    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    // Evalute the letter grade
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    
    else
        currentStudentLetterGrade = "F";

    // Print out the student and their grade to the console
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
