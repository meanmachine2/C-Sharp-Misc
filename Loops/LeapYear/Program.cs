using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int line=0;
            for (int i = 2001; i <= 2100; i++)
            {
                if (IsLeapYear(i))
                {
                    Console.Write(" " + i);
                    line++;
                }
                if (line % 10 == 0) Console.WriteLine();
            }
        }
        static bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) return true;
            else return false;
        }
    }
}
