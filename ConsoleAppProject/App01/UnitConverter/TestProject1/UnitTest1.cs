using System;
using NUnit.Framework;
using UnitConverter.App01;

namespace TestProject1;

public class Tests
{
    

    [Test]
    public void MilesToFeet()
    {
        DistanceConverter converter = new DistanceConverter();
        converter.fromVariable = 2.0;
        converter.choice1 = 1;
        converter.choice2 = 3;
        converter.calculate();
            
        Assert.AreEqual(10560.0, Math.Round(converter.toVariable));
    }
    [Test]
    public void FeetToMiles()
    {
        DistanceConverter converter = new DistanceConverter();
        converter.fromVariable= 10560.0;
        converter.choice1 = 3;
        converter.choice2 = 1;
        converter.calculate();
            
        Assert.AreEqual(2.0, converter.toVariable);
    }
    [Test]
    public void MilesToMetres()
    {
        DistanceConverter converter = new DistanceConverter();
        converter.fromVariable= 2.0;
        converter.choice1 = 1;
        converter.choice2 = 2;
        converter.calculate();
            
        Assert.AreEqual(Math.Round(3218.69, 1), Math.Round(converter.toVariable,1));
    }
    [Test]
    public void MetresToMiles()
    {
        DistanceConverter converter = new DistanceConverter();
        converter.fromVariable= 3218.69;
        converter.choice1 = 2;
        converter.choice2 = 1;
        converter.calculate();
            
        Assert.AreEqual(2.0, Math.Round(converter.toVariable));
    }
    [Test]
    public void MetresToFeet()
    {
        DistanceConverter converter = new DistanceConverter();
        converter.fromVariable= 2.0;
        converter.choice1 = 2;
        converter.choice2 = 3;
        converter.calculate();
            
        Assert.AreEqual(Math.Round(6.56168, 2), Math.Round(converter.toVariable,2));
    }
    [Test]
    public void FeetToMetres()
    {
        DistanceConverter converter = new DistanceConverter();
        converter.fromVariable= 6.56168;
        converter.choice1 = 3;
        converter.choice2 = 2;
        converter.calculate();
            
        Assert.AreEqual(2.0, Math.Round(converter.toVariable, 2));
    }
}