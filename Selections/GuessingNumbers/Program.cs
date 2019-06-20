using System;

namespace GuessingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess random number from 0 to 100 ");
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int randomNumber = rand.Next(0, 100);
            while (number != randomNumber)
            {
                if (number>randomNumber)
                {
                    Console.Write("Number is too high, please enter the number again: ");
                    number = int.Parse(Console.ReadLine());
                }
                else if (number<randomNumber)
                {
                    Console.Write("Number is too low, please enter the number again: ");
                    number = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The number is correct!");
        }
    }
}
