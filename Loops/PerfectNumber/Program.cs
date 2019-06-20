﻿using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10000; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0) sum += j;
                }
                if (sum == i) Console.WriteLine("Perfect number is " + i);
            }
        }
    }
}
