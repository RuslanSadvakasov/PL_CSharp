using System;
using System.Collections.Generic;
using System.Text;
using IOUtilsNms;

namespace menuClass
{
    class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("===== Menu =====");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("[1] Hello, World!");
            Console.WriteLine("[2] Calculate a formula: (X+sqrt(Y)) / Z ");
        }
        public static int GetMenuNumber() 
        {
            Console.Write("Insert a menu option: ");
            int menuOption = IOUtils.SafeReadInteger(Console.ReadLine());
            return menuOption;
        }
        public static void CalcFormula()
        {
            double dValue, x, y, z;
            Console.WriteLine("Input X,Y,Z values");
            Console.WriteLine("Enter a value of X");
            x = IOUtils.SafeReadDouble(Console.ReadLine());
            
            Console.WriteLine("Enter a value of Y");
            Console.WriteLine("Y's value can't be negative");
            y = IOUtils.SafeReadDouble(Console.ReadLine());
            while (y < 0.0)
            {
                Console.WriteLine("ERROR: Y's value can't be negative");
                y = IOUtils.SafeReadDouble(Console.ReadLine());
            }
            
            Console.WriteLine("Enter a value of Z");
            Console.WriteLine("Z's value can't equals 0");
            z = IOUtils.SafeReadDouble(Console.ReadLine());
            while (z == 0)
            {
                Console.WriteLine("ERROR: Z's value can't equals 0");
                z = IOUtils.SafeReadDouble(Console.ReadLine());
            }
            
            dValue = (x + Math.Sqrt(y)) / z;
            Console.WriteLine("Value of formula equals " + dValue);
        }
        

    }
}
