using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will prompt the user to input a distance measured in one unit (fromUnit) and it will calculate and output the equivalent distance in another unit.
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </Samuel Asebolatan>
    public class DistanceConverter
    {
        //DISTANCE COVERSION CONSTANTS
        public const int FEET_IN_MILES = 5200;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;


        //Distance Unit Names
        public const string FEET = "Feet";
        public const string MILES = "Miles";
        public const string METRES = "Metres";




        // Distance variables 
        private double fromDistance;
        private double toDistance;



        //Unit variables
        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }



        public void Run()
        {
            OutputHeading();
            do
            {
                fromUnit = SelectUnit(" Please select the from distance unit > ");
                if (fromUnit == null)
                    Console.WriteLine("Please select the correct option  from the list !");

            } while (fromUnit == null);

            do
            {
                toUnit = SelectUnit(" Please select the to distance unit > ");
                if (toUnit == null)
                    Console.WriteLine("Please select the correct option  from the list !");
            } while (toUnit == null);


            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");
            fromDistance = InputDistance($" Please enter the number of {fromUnit} > ");


            CalculateDistance();

            OutputDistance();

        }

        private void CalculateDistance()
        {
            ///BASIC UNITS: MILE, FEET, METRES
            ///miles->feet
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            ///feet-> miles
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            /// miles->metres
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            ///metres->miles
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            ///feet->metres
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            ///metres->feet
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }

        }

        ///<summary>
        ///This mehtod will input the distance measured in miles calculate the same distance in feet, and output the distance in feet.
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen:  -> {unit}");
            return unit;
        }



        public void ConvertDistance()
        {
            fromUnit = SelectUnit("please select the  from  distance unit > ");
            toUnit = SelectUnit("please select distance unit");


            OutputHeading($" Converting {fromUnit} to {toUnit} ");


            fromDistance = InputDistance($"Please enter the number of {fromUnit} > ");




            //CalculateFeet();

            OutputDistance();
        }

        private void OutputHeading(string v)
        {
            throw new NotImplementedException();
        }

       

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }





        ///<summary>
        ///prompt the user to in miles
        ///input miles as a double number.

        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            if (Double.TryParse(value, out double fromDistance))
            {
                fromDistance = Convert.ToDouble(value);
                if (fromDistance < 0)
                {
                    fromDistance = InputDistance(" Wrong Distance! Please Input a valid distance > ");
                }
                return fromDistance;
            }
            else
            {
                fromDistance = InputDistance("Wrong Distance! Please Input a valid distance >");
                return fromDistance;
            }
        }


        /// <summary>
        /// this private method displaying the  result in feets
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($" \n {fromDistance} {fromUnit}" +
                $" is --> {toDistance} {toUnit}!\n");
        }
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("  Distance converter  ");
            Console.WriteLine("        by Samuel Asebolatan                                 ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

    }

}