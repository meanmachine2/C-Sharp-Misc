using System;
using System.Globalization;

namespace Date_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter date in the following format eg. 12-12-2001: ");
            string dateInsert = Console.ReadLine();
            DateTime myDate = DateTime.ParseExact(dateInsert, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime enteredDate = myDate.AddDays(1000);
            Console.WriteLine(enteredDate.ToString("dd-MM-yyyy"));
        }
    }
}
