using System;

namespace PrimeNumbersBetwen2and1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int prime = 0;
            for (int i = 1; i <= 1000; i++)
            {
                bool isPrimeNumber = true;
                for (int j = i / 2; j >= 2; j--)
                {
                    if (i % j == 0) isPrimeNumber = false;
                }
                if (isPrimeNumber == true)
                {
                    if (prime % 8 == 0) Console.WriteLine();
                    Console.Write(String.Format("{0,5}", i));
                    prime++;
                }
            }
        }
    }
}
