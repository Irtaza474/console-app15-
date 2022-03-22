using System;
using NUnit.Framework;
using App03;
namespace TestProject2;

public class Tests
{
    
    public StudentGrades obj = new StudentGrades();



    public void assign()
    {
        obj.size = 10;
        obj.StudentData = new Tuple<string, double, Grades>[]
        {
            Tuple.Create("Student 1", 75.0, Grades.A),
            Tuple.Create("Student 2", 64.0, Grades.B),
            Tuple.Create("Student 3", 53.0, Grades.C),
            Tuple.Create("Student 4", 42.0, Grades.D),
            Tuple.Create("Student 5", 39.0, Grades.F),
            Tuple.Create("Student 6", 88.0, Grades.A),
            Tuple.Create("Student 7", 69.0, Grades.B),
            Tuple.Create("Student 8", 55.0, Grades.C),
            Tuple.Create("Student 9", 48.0, Grades.D),
            Tuple.Create("Student 10", 21.0, Grades.F)
        };
    }

    [Test]
    public void CalculateGradeTest1()
    {
        Assert.AreEqual(obj.CalculateGrade(75.0).ToString(), Grades.A.ToString());
    }

    [Test]
    public void CalculateGradeTest2()
    {
        Assert.AreEqual(obj.CalculateGrade(65.0).ToString(), Grades.B.ToString());
    }

    [Test]
    public void CalculateGradeTest3()
    {
        Assert.AreEqual(obj.CalculateGrade(55.0).ToString(), Grades.C.ToString());
    }
    
    [Test]
    public void CalculateGradeTest4()
    {
        Assert.AreEqual(obj.CalculateGrade(45.0).ToString(), Grades.D.ToString());
    }
    
    [Test]
    public void CalculateGradeTest5()
    {
        Assert.AreEqual(obj.CalculateGrade(35.0).ToString(), Grades.F.ToString());
    }

    [Test]
    public void OutputStatsTest1()
    {
        assign();
        obj.OutputStats();
        Assert.AreEqual(obj.highest.ToString(), (88.0).ToString());
    }
    
    [Test]
    public void OutputStatsTest2()
    {
        assign();
        obj.OutputStats();
        Assert.AreEqual(obj.lowest.ToString(), (21.0).ToString());
    }
    
    [Test]
    public void OutputStatsTest3()
    {
        assign();
        obj.OutputStats();
        Assert.AreEqual(obj.mean.ToString(), (55.4).ToString());
    }

    [Test]
    public void GradeProfileTest()
    {
        int[] arr = {2, 2, 2, 2, 2};
        assign();
        obj.OutputGradeProfile();
        Assert.AreEqual(obj.GradeProfile, arr);
    }
}

