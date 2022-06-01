using BMICalculator.App02;

namespace BMICalculator;

/// <author>
/// Irtaza Qayyum
/// 22136251
/// </author>
public static class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine(" ================================================");
        Console.WriteLine("  BNU CO453 Applications Programming 2021-2022!");
        Console.WriteLine("             by  Irtaza Qayyum 22136251     ");
        Console.WriteLine(" ================================================");
        Console.WriteLine("");
        
        BMI bmi = new BMI();
        bmi.Start();
    }
}