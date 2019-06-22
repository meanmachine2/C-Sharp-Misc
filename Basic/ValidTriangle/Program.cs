using System;

namespace ValidTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int []numbers = new int[3] ;
            for (int i = 0; i < numbers.Length; i++) numbers[i] = int.Parse(Console.ReadLine());
            if (numbers[0] + numbers[1] > numbers[2] || numbers[1] + numbers[2] > numbers[0] || numbers[2] + numbers[0] > numbers[1])
            {
                Console.WriteLine("Valid Triangle");
            }
            else Console.WriteLine("Invalid Triangle");
        }
    }
}
