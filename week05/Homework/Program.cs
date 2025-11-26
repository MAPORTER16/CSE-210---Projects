using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Matthew Porter", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("William Fitzgerald", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WrittingAssignment a3 = new WrittingAssignment("Kyle Lovato", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWrittingInformation());
    }
}