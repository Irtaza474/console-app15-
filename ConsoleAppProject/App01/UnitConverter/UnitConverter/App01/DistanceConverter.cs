using System;
namespace UnitConverter.App01;


/// <summary>
/// Please describe the main features of this App
/// </summary>
/// <author>
/// Irtaza Qayyum
/// 22136251
/// </author>
public class DistanceConverter
{
    public int choice1, choice2;
    public double fromVariable, toVariable;
    public string choiceName1, choiceName2;
    public void Run()
    {
        choice1 = unitchoice();
        choice2 = unitchoice();
        choiceName1 = unitName(choice1);
        choiceName2 = unitName(choice2);
        Console.WriteLine($"You are converting from {choiceName1} to {choiceName2}");
        input();
        calculate();
        output();
    }

    public int unitchoice()
    {
        
        Console.WriteLine("Please Select your from unit");
        Console.WriteLine("1. Miles");
        Console.WriteLine("2. Metres");
        Console.WriteLine("3. Feet");
        Console.WriteLine("4. Nautical Mile");
        Console.WriteLine("5. Yard");
        Console.WriteLine("6. Centimeter");
        Console.Write("Please Enter your Choice > ");
        int choice = Convert.ToInt32(Console.ReadLine());
        while (!(choice >= 1 && choice <=6))
        {
            Console.WriteLine("Enter a choice between 1 and 6!");
            Console.Write("Please Enter your Choice > ");
            choice = Convert.ToInt32(Console.ReadLine());
        }

        return choice;
    }

    public string unitName(int choice)
    {
        if (choice == 1)
            return "Miles";
        else if (choice == 2)
            return "Metres";
        else if(choice == 3)
            return "Feet";
        else if (choice == 4)
            return "Nautical Mile";
        else if (choice == 5)
            return "Yard";
        return "Centimeter";
    }

    public void input()
    {
        try
        {
            do {
                Console.Write("Enter the distance in " + choiceName1 + " : ");
                fromVariable = Convert.ToDouble(Console.ReadLine());
                if(fromVariable < 0 )
                    Console.WriteLine("Error! Distance can't be negative!");
            } while (fromVariable < 0);
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Invalid Input");
            input();
        }
    }
    public void calculate()
    {
        
        if (choice1 == 1 && choice2 == 2)
        {
            toVariable = fromVariable * 1609.34;
        }
        else if (choice1 == 2 && choice2 == 1)
        {
            toVariable = fromVariable / 1609.34;
        }
        else if (choice1 == 1 && choice2 == 3)
        {
            toVariable = fromVariable * 5280.0;
        }
        else if (choice1 == 3 && choice2 == 1)
        {
            toVariable = fromVariable / 5280.0;
        }
        else if (choice1 == 1 && choice2 == 4)
        {
            toVariable = fromVariable / 1.151;
        }
        else if (choice1 == 4 && choice2 == 1)
        {
            toVariable = fromVariable * 1.151;
        }
        else if (choice1 == 1 && choice2 == 5)
        {
            toVariable = fromVariable * 1760.0;
        }
        else if (choice1 == 5 && choice2 == 1)
        {
            toVariable = fromVariable / 1760.0;
        }
        else if (choice1 == 1 && choice2 == 6)
        {
            toVariable = fromVariable * 160934.0;
        }
        else if (choice1 == 6 && choice2 == 1)
        {
            toVariable = fromVariable / 160934.0;
        }
        
        else if (choice1 == 2 && choice2 == 3)
        {
            toVariable = fromVariable * 3.28;
        }
        else if (choice1 == 3 && choice2 == 2)
        {
            toVariable = fromVariable / 3.28;
        }
        else if (choice1 == 2 && choice2 == 4)
        {
            toVariable = fromVariable / 1852.0;
        }
        else if (choice1 == 4 && choice2 == 2)
        {
            toVariable = fromVariable * 1852.0;
        }
        else if (choice1 == 2 && choice2 == 5)
        {
            toVariable = fromVariable * 1.094;
        }
        else if (choice1 == 5 && choice2 == 2)
        {
            toVariable = fromVariable / 1.094;
        }
        else if (choice1 == 2 && choice2 == 6)
        {
            toVariable = fromVariable * 100.0;
        }
        else if (choice1 == 6 && choice2 == 2)
        {
            toVariable = fromVariable / 100.0;
        }
        
        else if (choice1 == 3 && choice2 == 4)
        {
            toVariable = fromVariable / 6076.0;
        }
        else if (choice1 == 4 && choice2 == 3)
        {
            toVariable = fromVariable * 6076.0;
        }
        else if (choice1 == 3 && choice2 == 5)
        {
            toVariable = fromVariable / 3.0;
        }
        else if (choice1 == 5 && choice2 == 3)
        {
            toVariable = fromVariable * 3.0;
        }
        else if (choice1 == 3 && choice2 == 6)
        {
            toVariable = fromVariable * 30.48;
        }
        else if (choice1 == 6 && choice2 == 3)
        {
            toVariable = fromVariable / 30.48;
        }
        
        else if (choice1 == 4 && choice2 == 5)
        {
            toVariable = fromVariable * 2025.37;
        }
        else if (choice1 == 5 && choice2 == 4)
        {
            toVariable = fromVariable / 2025.37;
        }
        else if (choice1 == 4 && choice2 == 6)
        {
            toVariable = fromVariable * 185200.0;
        }
        else if (choice1 == 6 && choice2 == 4)
        {
            toVariable = fromVariable / 185200.0;
        }
        
        else if (choice1 == 5 && choice2 == 6)
        {
            toVariable = fromVariable * 91.44;
        }
        else if (choice1 == 6 && choice2 == 5)
        {
            toVariable = fromVariable / 91.44;
        }
        
        
    }

    public void output()
    {
        Console.WriteLine($"Conversion Complete!\n{fromVariable} {choiceName1} = {toVariable} {choiceName2}");
    }
}
