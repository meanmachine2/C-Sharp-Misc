using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("  ");
            for (int i = 1; i < 10; i++) Console.Write(String.Format("{0,5}", i));
            Console.WriteLine("\n ----------------------------------------------");
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i+"|");
                for (int j = 1; j < 10; j++) Console.Write(String.Format("{0,5}", i * j));
                Console.WriteLine();
            }
        }
    }
}
