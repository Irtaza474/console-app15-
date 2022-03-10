using System;

namespace UnitConverter.App01;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine();
        Console.WriteLine(" =================================================");
        Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
        Console.WriteLine("              by Irtaza Qayyum 22136251           ");
        Console.WriteLine(" =================================================");
        Console.WriteLine();

        DistanceConverter converter = new DistanceConverter();
        converter.Run();
    }
}
