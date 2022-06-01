namespace BMICalculator.App02;

 /// <summary>
    /// This class contains methods for calculating 
    /// the user's BMI (Body Mass Index) using 
    /// imperial or metric units.
    /// </summary>
    /// <Author>
    /// Derek Peacock App02: Version 1.0
    /// </Author>
    public class BMI
    {
        private double index;

        // Metric Details
        
        private double kilograms;
        private double metres;

        // Imperial Details
        
        private double pounds;
        private int inches;
        
        private string[] choices = new[]
        {
            "Metric Units",
            "Imperial Units"
        };

        private string[] categories = new[]
        {
            "Pregnant Woman",
            "Children",
            "BAME: Black, Asian and other minority ethnic groups",
            "None of the Above"
        };

        private int categoryChoice = 4;

        private Tuple<int, string, string, double, double>[] range =
        {
            Tuple.Create(1, "Pregnant Woman", "Underweight", 0.0 , 22.4),
            Tuple.Create(1, "Pregnant Woman", "Normal", 22.5, 28.3),
            Tuple.Create(1, "Pregnant Woman", "Overweight", 28.4 , 32.4),
            Tuple.Create(1, "Pregnant Woman", "Obese I" , 32.5 , 37.5),
            Tuple.Create(1, "Pregnant Woman", "Obese II" , 37.6, 42.5),
            Tuple.Create(2, "Children", "Underweight", 0.0 , 15.4),
            Tuple.Create(2, "Children", "Normal", 15.5, 17.0),
            Tuple.Create(2, "Children", "Overweight", 17.1, 19.3),
            Tuple.Create(2, "Children", "Obese I", 19.4, 22.6),
            Tuple.Create(2, "Children", "Obese II", 22.6, 28.4),
            Tuple.Create(2, "Children", "Obese III", 28.4, 100.0),
            Tuple.Create(3, "BAME", "Underweight", 0.0 , 19.1),
            Tuple.Create(3, "BAME", "Normal", 19.2 , 25.6),
            Tuple.Create(3, "BAME", "Overweight", 25.7 , 31.0),
            Tuple.Create(3, "BAME", "Obese I", 31.1, 36.5),
            Tuple.Create(3, "BAME", "Obese II", 36.6, 42.0),
            Tuple.Create(3, "BAME", "Obese III", 42.1, 100.0),
            Tuple.Create(4, "General" , "Underweight", 0.0 , 18.5),
            Tuple.Create(4, "General" , "Normal",18.6 , 24.9),
            Tuple.Create(4, "General" , "Overweight", 25.0 , 29.9),
            Tuple.Create(4, "General" , "Obese I", 30.0, 34.9),
            Tuple.Create(4, "General" , "Obese II", 35.0, 39.9),
            Tuple.Create(4, "General" , "Obese III", 39.9, 100.0),
        };

        private string status = "";
        

        public void Start()
        {
            Console.WriteLine("WHO Weight Status\t\tBMI kg/m2\n" +
                              "Underweight\t\t< 18.50\n" +
                              "Normal\t\t\t18.5 - 24.9\n" +
                              "Overweight\t\t25.0 - 29.9\n" +
                              "Obese Class I\t\t30.0 - 34.9\n" +
                              "Obese Class II\t\t35.0 - 39.9\n" +
                              "Obese Class III\t\t>= 40.0");
            
            
            Console.WriteLine("\n Choose Your category: ");
            categoryChoice = Utilities.SelectChoice(categories);
            
            int choice = Utilities.SelectChoice(choices);
            CalculateIndex(choice);
            OutputMessage();
        }
        
        public void CalculateIndex(int choice)
        {

            if(choice == 1)
            {
                MetricInput();
                MetricCalc();
            }
            else if(choice == 2)
            {
                ImperialInput();
                ImperialCalc();
            }
        }
        
        private void ImperialInput()
        {
            Console.WriteLine(" Enter your height in feet and inches ");
            double feet = Utilities.Input("\nEnter your height in feet > ", 0.0, 8);
            inches = (int)Utilities.Input("Enter your height in inches > ", 0.0, 12);

            inches += (int)feet * 12;

            Console.WriteLine("Enter your weight in stones and pounds");
            double stones = Utilities.Input("Enter your weight in stones > ", 0.0, 1400);
            pounds = Utilities.Input("Enter your weight in pounds > ", 0.0, 14);

            pounds += stones * 14;
        }
        
        public double ImperialCalc()
        {
            index = pounds * 703 / (inches * inches);
            return index;
        }

        private void MetricInput()
        {
            metres = Utilities.Input("\nEnter your height in metres > ", 0.0, 3.0);
            kilograms = Utilities.Input("Enter your weight in kilograms > ", 0.0, 600);
        }

        public double MetricCalc()
        {
            index = kilograms / (metres * metres);
            return index;
        }
        
        private void OutputMessage()
        {
            foreach (var i in range)
            {
                if (i.Item1 == categoryChoice)
                {
                    if (index >= i.Item4 && index <= i.Item5)
                    {
                        status = i.Item3;
                        Console.WriteLine($"Your BMI is {index}. You are {i.Item3}!");
                    }
                }
            }
            HealthTip();
        }
        
        private void HealthTip()
        {
            Console.WriteLine("\nHealth Tips\n");
            
            if (status == "Underweight")
            {
                Console.WriteLine("1. Consume More Carbs" +
                                  "\n2. Don't skip meals" +
                                  "\n3. Don't avoid veggies");
            }
            else if (status == "Normal")
            {
                Console.WriteLine("You are doing a great job" +
                                  "\n Keep exercising and eating Healthy" );
            }
            else if (status == "Overweight")
            {
                Console.WriteLine("1. Consume less fat" +
                                  "\n2.Consume less sugary foods" +
                                  "\n3.Eat more vegetables and fruits.");
            }
            else if (status == "Obese I")
            {
                Console.WriteLine("1. Reduce calories\n" +
                                  "2. Start Exercising\n" +
                                  "3. Eat Fruits and Veggies");
            }
            else if (status == "Obese II" || status == "Obese III")
            {
                Console.WriteLine("1.Seek Supervision from a Doctor\n" +
                                  "2.Consider Medication\n" );
            }
        }     
        
        
    }
    
    
    
    