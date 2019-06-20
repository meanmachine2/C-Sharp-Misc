using System;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite godinu: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Unesite mjesec: ");
            int month = int.Parse(Console.ReadLine());
            if (month == 1)
            {
                month = 13;
                year--;
            }
                if (month == 2) 
            {
                month = 14;
                year--;
            }
            Console.Write("Unesite dan: ");
            int day = int.Parse(Console.ReadLine());
            int century = year / 100;
            string[] dayOfWeekS = new string [] { "Saturday", "Sunday", "Monday", "Tuseday", "Wenseday", "Thursday", "Friday" };
            int dayOfWeek = (day+((26*(month+1))/10)+(year%100)+((year%100)/4)+(century/4)+(5*century)) % 7;
            Console.WriteLine("Day is {0}", dayOfWeekS[dayOfWeek]);
        }
    }
}
