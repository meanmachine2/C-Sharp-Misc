using System;
/*
(Count positive and negative numbers and compute the average of numbers) Write
a program that reads an unspecified number of integers, determines how many
positive and negative values have been read, and computes the total and average of
the input values (not counting zeros). Your program ends with the input 0. Display
the average as a floating-point number 
 */

namespace PositiveAndNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0, timesEntry = 0;
            double sum = 0;
            int positive = 0, negative = 0;
            do
            {
                Console.WriteLine();
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());
                if (number != 0 && number > 0) positive++;
                else if (number != 0 && number < 0) negative++;
                if (number != 0) timesEntry++;
                sum += number;
            } while (number != 0);
            Console.WriteLine("Number of positives = {0} \n Number of negatives = {1}", positive, negative);
            Console.WriteLine("Average number is {0} ", sum / timesEntry);
        }
    }
}
