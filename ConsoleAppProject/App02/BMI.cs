using System;


namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Two unit systems measuring weight and height 
    /// </summary>
    public class BMI
    {
        public const string IMPERIAL = "Imperial";
        public const string METRIC = "Metric";

        public const string FEET = "Feet";
        public const string INCHES = "Inches";

        public const int INCHES_IN_FEET = 12;
        public const int POUNDS_IN_STONE = 14;
        public const int IMPERIAL_FACTOR = 703;
        public double BMI_Index { get; set; }
        public BMI_Status Status { get; set; }

        private double height;
        private double weight;

        private string unitChoice;
        public void Run()
        {
            ConsoleHelper.OutputHeading("BMI Calculator");
            ConvertBMI();
        }
        public void ConvertBMI()
        {
            Console.WriteLine("\n Selecting units");

            string[] choices = new string[]
            {
                IMPERIAL,METRIC
            };

            Console.WriteLine($"\n Please select a unit to convert from \n ");
            int choice = ConsoleHelper.SelectChoice(choices);
            unitChoice = choices[choice - 1];

            Console.WriteLine($"\n You have selected {unitChoice} !");

            if (unitChoice == IMPERIAL)
            {
                InputImperial();
                CalculateImperial();


            }
            else if (unitChoice == METRIC)
            {
                InputMetric();
                CalculateMetric();
            }

            OutputBMI_Index();
            string input = Console.ReadLine();
        }

        internal void CalculateIndex()
        {
            throw new NotImplementedException();
        }

        private void InputImperial()
        {
            Console.WriteLine($"\n Please enter your height" +
                    " to the nearest feet and inches: ");

            height = ConsoleHelper.InputNumber($"\n Enter your height in feet >");
            int inches = (int)ConsoleHelper.InputNumber($"\n Enter your height in inches >", 0, INCHES_IN_FEET);
            height = height * INCHES_IN_FEET + inches;

            Console.WriteLine($"\n Please enter your weight" +
                " to the nearest stones and pounds: ");

            weight = ConsoleHelper.InputNumber($"\n Enter your weight in stone >");
            int pounds = (int)ConsoleHelper.InputNumber($"\n Enter your weight in pounds >", 0, POUNDS_IN_STONE);
            weight = weight * POUNDS_IN_STONE + pounds;
        }

        private void InputMetric()
        {
            Console.WriteLine($"\n Please enter your height" +
                    " in metres: \n ");
            height = ConsoleHelper.InputNumber($"\n Enter your height in metres > ");


            Console.WriteLine($"\n Please enter your weight" +
                "  to the nearest kilogram: ");
            weight = ConsoleHelper.InputNumber($"\n Enter your weight in kilograms > ");

        }
       
        private void CalculateImperial()
        {
            BMI_Index = weight * IMPERIAL_FACTOR / (height * height);
        }

        
        private void CalculateMetric()
        {
            BMI_Index = weight / (height * height);
        }
        private void OutputBMI_Index()
        {
            if (BMI_Index < 18.50)
            {
                Status = BMI_Status.UnderWeight;
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Your BMI Status is Underweight ");
            }
            else if (BMI_Index < 24.9 && BMI_Index > 18.5)
            {
                Status = BMI_Status.NormalWeight;
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Your BMI Status is Normal weight ");
            }
            else if (BMI_Index < 29.9 && BMI_Index > 25.0)
            {
                Status = BMI_Status.OverWeight;
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Your BMI Status is Overweight ");
            }
            else if (BMI_Index < 34.9 && BMI_Index > 30.0)
            {
                Status = BMI_Status.Obeseone;
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Your BMI Status is Obese Class one ");
            }
            else if (BMI_Index < 39.9 && BMI_Index > 35.0)
            {
                Status = BMI_Status.Obesetwo;
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Your BMI Status is Obese Class two ");
            }
            else if (BMI_Index >= 40.0)
            {
                Status = BMI_Status.Obesethree;
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Your BMI Status is Obese Class three ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black; 
            Console.WriteLine("--------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Your BMI Index is {BMI_Index: 0.00}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--------------------------");


        }
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"1.{IMPERIAL}");
            Console.WriteLine($"2.{METRIC}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;

        }

        public BMI_Status BMI_Status
        {
            get => default;
            set
            {
            }
        }
    }
}