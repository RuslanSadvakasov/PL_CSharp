using System;
using mainClass;
using IOUtilsNms;

namespace mainClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime FirstDate, SecondDate, ThirdDate, FourthDate;
            while (true)
            {
                Menu.ShowMenu();
                Console.Write("Enter a menu option: ");
                int menuOption = IOUtils.SafeReadInteger(Console.ReadLine());
                switch (menuOption) 
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("Hello, World!"); 
                        break;
                    case 2:
                        Menu.FactorialMenu();
                        break;
                    case 3:


                        break;
                }
            }
        }
    }
}
