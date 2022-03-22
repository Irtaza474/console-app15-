namespace App03;

public class main
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine();
        Console.WriteLine(" =================================================");
        Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
        Console.WriteLine("                 Irtaza Qayyum                               \n " +
                          "                    22136251 ");
        Console.WriteLine(" =================================================");
        Console.WriteLine();
        StudentGrades obj = new StudentGrades();
        obj.Start();
    }
}