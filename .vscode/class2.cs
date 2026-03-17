
using System;

class Student
{
    int rollNo;
    string name;
    int marks;


    public Student()
    {
        rollNo = 11;
        name = "Anushka";
        marks = 24;
    }
    public Student(int rollNo, string name, int marks)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.marks = marks;
    }


    public string CalculateGrade()
    {
        if (marks >= 90)
            return 'A';
        else if (marks >= 80)
            return 'B';
        else if (marks >= 70)
            return 'C';
        else if (marks >= 60)
            return 'D';
        else
            return 'F';
    }


    public void DisplayDetails()
    {
        Console.WriteLine($"Roll No: {rollNo}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Marks: {marks}");
        Console.WriteLine($"Grade: {CalculateGrade()}");
    }
}