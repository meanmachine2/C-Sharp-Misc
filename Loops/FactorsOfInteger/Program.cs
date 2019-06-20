using System;

namespace FactorsOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer");
            int number = int.Parse(Console.ReadLine());
            int factor = 2;
            while (number>1)
            {
                if (number % factor == 0)
                {
                    Console.Write("{0} ", factor);
                    number /= factor;
                }
                else factor++;
            }
        }
    }
}
