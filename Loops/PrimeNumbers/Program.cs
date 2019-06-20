using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int prime = 0;
            int i = 1;
            while(prime<=50)
            {
                bool isPrimeNumber = true;
                for (int j = i / 2; j >= 2; j--)
                {
                    if (i % j == 0) isPrimeNumber = false;
                }
                if (isPrimeNumber == true)
                {
                    if (prime % 5 == 0) Console.WriteLine();
                    Console.Write(String.Format("{0,5}",i));
                    prime++;
                }
                i++;
            }
        }
    }
}
