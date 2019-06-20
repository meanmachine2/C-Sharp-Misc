using System;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int firstDigit = number.Next(1, 9);
            int secondDigit;
            do
            {
                secondDigit = number.Next(1, 9);
            } while (firstDigit==secondDigit);
            Console.WriteLine($"Lottery numbers are {firstDigit}{secondDigit}");
        }
    }
}
