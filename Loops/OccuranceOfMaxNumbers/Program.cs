using System;

namespace OccuranceOfMaxNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMax = 0;
            int maxOccurances = 0;
            bool cond = true;
            do
            {
                Console.Write("Enter number : ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (number > numberMax)
                {
                    numberMax = number;
                    maxOccurances = 1;
                }
                else if (number == numberMax) maxOccurances++;
                else if (number < numberMax && number != 0) { }
                else
                {
                    cond = false;
                    Console.WriteLine($"Max number is {numberMax} and number of occurances is {maxOccurances}");
                }
            } while (cond);
          
        }
    }
}
