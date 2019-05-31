using System;

namespace GreatestCommonDivisor2Num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int number2 = int.Parse(Console.ReadLine());
            if (number2>number1)
            {
                int temp = number1;
                number1 = number2;
                number2 = temp;
            }
            int commonDivisor = number2;
            bool greatestDivisor = false;
            while (commonDivisor > 1 && greatestDivisor == false)
            {
                if (number1 % commonDivisor == 0 && number2 % commonDivisor == 0) greatestDivisor = true;
                else commonDivisor--;
            }
            if (commonDivisor > 1) Console.WriteLine("Greatest divisor of two numbers is " + commonDivisor);
            else Console.WriteLine("There is no common divisor");

            
            
        }
    }
}
