using System;
using System.Collections.Generic;
using System.Text;

namespace IOUtilsNms
{
    public static class IOUtils
    {
        public static int SafeReadInteger(string sValue)
        {
            
            while (true)
            {
                int iValue = 0;
                if (Int32.TryParse(sValue, out iValue))
                {
                    return iValue;
                }
                if (string.IsNullOrEmpty(sValue))
                {
                    Console.WriteLine("ERROR: Value is null or empty. Enter a value...");
                }
                else
                {
                    Console.WriteLine("ERROR: Incorrect format. Enter a integer value...");
                }
                sValue = Console.ReadLine();
            }
        }
        public static double SafeReadDouble(string sValue)
        {
            while (true)
            {
                double dValue = 0.0;
                if (Double.TryParse(sValue, out dValue))
                {
                    return dValue;
                }
                if (string.IsNullOrEmpty(sValue))
                {
                    Console.WriteLine("ERROR: Value is null or empty. Enter a value...");
                }
                else
                {
                    Console.WriteLine("ERROR: Incorrect format. Enter a double value...");
                }
                sValue = Console.ReadLine();
            }
        }
    }
}
