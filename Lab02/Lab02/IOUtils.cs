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
    }
}
