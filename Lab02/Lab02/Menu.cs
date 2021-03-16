using System;
using System.Collections.Generic;
using System.Text;
using IOUtilsNms;

namespace mainClass
{
    class Menu
    {
        public static int Factorial(int iValue)
        {
            if (iValue == 0)
            {
                return 1;
            }
            else
            {
                return iValue * Factorial(iValue - 1);
            }
        }
        public static void FactorialMenu()
        {
            Console.WriteLine("Factorial of N, Enter a natural number");
            int factValue = IOUtils.SafeReadInteger(Console.ReadLine());
            Console.WriteLine("Factorial of " + factValue + " equals: " + Menu.Factorial(factValue));
        }
        public static void ShowMenu()
        {
            Console.WriteLine("===== Menu =====");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("[1] Hello, World!");
            Console.WriteLine("[2] Calculate a formula (Factorial)");
            Console.WriteLine("[3] Recursion date:");
        }

        public static void EnterDate()
        {
            Console.WriteLine("=ENTER A DATE=");
            Console.WriteLine("Enter a year");
            
        }
    }
}
