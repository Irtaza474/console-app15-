using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace App03;

/// <summary>
/// At the moment this class just tests the
/// Grades enumeration names and descriptions
/// </summary>
public class StudentGrades
{
    public int MenuChoice;
    public int size;

    public Tuple<String, double, Grades>[] StudentData;
    public double highest, lowest, mean;
    public int[] GradeProfile= {0, 0, 0, 0, 0};
    
    public void Start()
    {
        string[] menu =
        {
            "Input Marks",
            "Output Marks",
            "Output Stats",
            "Output Grade Profile",
            "Quit"
        };
        int choice = 1;
        do
        {
            MenuChoice = Utilities.SelectChoice(menu);
            choiceRouter(MenuChoice);
            Console.Write("Do you wish to continue?\nPress 1 for YES, 0 for NO: ");
            choice = Convert.ToInt32(Console.ReadLine());
        } while (choice == 1);
        
    }

    public void choiceRouter(int MenuChoice)
    {
        switch (MenuChoice)
        {
            case 1: Input();
                break;
            case 2: OutputMarks();
                break;
            case 3: OutputStats();
                break;
            case 4: OutputGradeProfile();
                break;
            case 5:
                Environment.Exit(0); 
                break;
            default: Console.WriteLine("Wrong Option Entered! ");
                break;
        }
            
    }

    public void Input()
    {
        Console.WriteLine("Enter the numbers of students: ");
        size = Convert.ToInt32(Console.ReadLine());
        StudentData = new Tuple<string, double, Grades>[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter name: ");
            String name = Console.ReadLine();
            double marks = Utilities.Input("Enter Marks: ");
            StudentData[i] = Tuple.Create(name, marks, CalculateGrade(marks));
        }
    }

    public Grades CalculateGrade(double marks)
    {
        Grades grade= Grades.F;
        if (marks >= 70 && marks <= 100)
            grade = Grades.A;
        else if(marks >=60 && marks<=69)
            grade =Grades.B;
        else if(marks >=50 && marks<=59)
            grade = Grades.C;
        else if(marks >=40 && marks<=49)
            grade = Grades.D;
        else 
            grade = Grades.F;

        return grade;
    }
    
    

    public void OutputMarks()
    {
        Utilities.printHeading("Detailed Data");
        Console.WriteLine("Name\t\tMarks\t\tGrade\t\tClassification");
        foreach (var i in StudentData)
        {
            Console.WriteLine(i.Item1+ "\t\t" +i.Item2+"\t\t" + i.Item3 + "\t\t" + i.Item3.GetEnumDescription());
        }
    }

    public void OutputStats()
    {
        Utilities.printHeading("Statistics");
        double totalMarks = 0.0;
        highest = StudentData[0].Item2;
        lowest= StudentData[0].Item2;
        String highestName = "", lowestName = "";
        foreach (var i in StudentData)
        {
            totalMarks += i.Item2;
            if (i.Item2 <= lowest)
            {
                lowest = i.Item2;
                lowestName = i.Item1;
            }

            if (i.Item2 >= highest)
            {
                highest = i.Item2;
                highestName = i.Item1;
            }
        }

        mean = totalMarks / size;
        Console.WriteLine($"Mean: {mean}\n" +
                          $"Highest Marks: {highest} Student: {highestName}\n" +
                          $"Lowest Marks: {lowest} Student: {lowestName}");
    }

    public void OutputGradeProfile()
    {
        
        foreach (var i in StudentData)
        {
            if (i.Item3 == Grades.A)
                GradeProfile[0] += 1;
            else if (i.Item3 == Grades.B)
                GradeProfile[1] += 1;
            else if (i.Item3 == Grades.C)
                GradeProfile[2]+= 1;
            else if (i.Item3 == Grades.D)
                GradeProfile[3] += 1;
            else if (i.Item3 == Grades.F)
                GradeProfile[4] += 1;
        }
        Utilities.printHeading("Grade Profile");
        Console.WriteLine($"Grade {Grades.A}: {GradeProfile[0]}");
        Console.WriteLine($"Grade {Grades.B}: {GradeProfile[1]}");
        Console.WriteLine($"Grade {Grades.C}: {GradeProfile[2]}");
        Console.WriteLine($"Grade {Grades.D}: {GradeProfile[3]}");
        Console.WriteLine($"Grade {Grades.F}: {GradeProfile[4]}");
    }
    
}
