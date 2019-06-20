using System;

namespace PyramidPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pattern A");
            int number = 6;
            for (int i = 1; i <=number; i++)
            {
                for (int j = 1; j <= i; j++) Console.Write(j + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Pattern B");
            for (int i = number; i > 0; i--)
            {
                for (int j = 1; j <= i; j++) Console.Write(j + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Pattern C");
            int repeat = number * 2;
            for (int i = 1; i <= number; i++)
            {
                for (int z = 0; z < repeat; z++)Console.Write(" ");
                for (int j = i; j >=1; j--) Console.Write(j + " ");
                Console.WriteLine();
                repeat -= 2;
            }
            Console.WriteLine();
            Console.WriteLine("Pattern D");
            number = 6;
            repeat = 0;
            for (int i = number; i > 0; i--)
            {
                for (int z = 0; z < repeat; z++) Console.Write(" ");
                for (int j = 1; j <= i; j++) Console.Write(j + " ");
                Console.WriteLine();
                repeat+=2;
            }

        }
    }
}
