using System;
using menuClass;
using IOUtilsNms;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu.ShowMenu();
                int MenuOption = Menu.GetMenuNumber();
                switch (MenuOption)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("Hello, World!");
                        break;
                    case 2:
                        Menu.CalcFormula();
                        break;
                    default:
                        Console.WriteLine("ERROR: Incorrect menu option...");
                        break;
                }
            }
        }
    }
}
