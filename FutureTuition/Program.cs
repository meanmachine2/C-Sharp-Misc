using System;
/*
Financial application: compute future tuition) Suppose that the tuition for a university
is $10,000 this year and increases 5% every year. Write a program that
computes the tuition in ten years and the total cost of four years’ worth of tuition
starting ten years from now.
 */
namespace FutureTuition
{
    class Program
    {
        static void Main(string[] args)
        {
            double tuition = 10000;
            double sumFourYears = 0;
            for (int i = 1; i <= 14; i++)
            {    
                tuition += (tuition * 0.05);
                if (i == 10) Console.WriteLine("Tutition after ten years of increase is {0} USD", tuition);
                if (i > 10) sumFourYears += tuition;
            }
            Console.Write("Tuition sum ten years from now and after four years and 5% increase is " + sumFourYears);
        }
    }
}
