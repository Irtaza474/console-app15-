namespace App03;

public class Utilities
{
        public static int SelectChoice(string[] choices)
        {
            int choiceNo;
            int lastChoice = choices.Length;
            bool validChoice;

            //string errorMessage = ;

            DisplayChoice(choices);
            do
            {
                choiceNo = (int)Input("Please enter your choice > ", 1, lastChoice);

                if ((choiceNo < 1) || (choiceNo > lastChoice))
                {
                    validChoice = false;
                }
                else validChoice = true;

            } while (!validChoice);

            Console.WriteLine();

            return choiceNo;
        }
        
        public static void DisplayChoice(string[] choices)
        {
            Console.WriteLine();

            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($" {choiceNo}. {choice}");
            }

            Console.WriteLine();
        }
        
        public static double Input(string prompt)
        {
            double number = 0;
            bool isValid;

            do
            {
                Console.Write(prompt);
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine(" INVALID NUMBER!\n");
                }

            } while (!isValid);

            return number;
        }
        
        public static double Input(string prompt, double min, double max)
        {
            bool isValid;
            double number;

            do
            {
                number = Input(prompt);

                if (number < min || number > max)
                {
                    isValid = false;
                    Console.WriteLine($"INVALID INPUT! Number must be between {min} and {max} ");
                }
                else isValid = true;

            } while (!isValid);

            return number; 
        }

        public static void printHeading(string prompt)
        {
            Console.WriteLine("\n========================================================================");
            Console.WriteLine($"\t\t\t\t{prompt.ToUpper()}");
            Console.WriteLine("========================================================================");
        }
}