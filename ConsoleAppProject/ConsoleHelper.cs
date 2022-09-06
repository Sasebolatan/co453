using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
   public static class ConsoleHelper
    {
        public static void OutputHeading(string title)
        {
            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine($"         {title}                     ");
            Console.WriteLine("        by Samuel Asebolatan                                                   ");              
            Console.WriteLine(" =================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        internal static int SelectChoice(string[] choices)
        {
            throw new NotImplementedException();
        }

        internal static double InputNumber(string v)
        {
            throw new NotImplementedException();
        }

        internal static int InputNumber(string v1, int v2, int iNCHES_IN_FEET)
        {
            throw new NotImplementedException();
        }
    }
}












