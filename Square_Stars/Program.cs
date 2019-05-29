using System;

namespace Square_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int z = 1; z <= n; z++)
            {
                if (z==1 ||z==n)
                {
                    Console.Write(new String('*', n));
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new String(' ', n-2));
                    Console.Write("*");
                }
                Console.WriteLine();
            };
        }
    }
}
