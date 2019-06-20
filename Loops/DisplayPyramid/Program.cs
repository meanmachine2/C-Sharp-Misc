using System;

namespace DisplayPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numer up to 10: ");
            int number = int.Parse(Console.ReadLine());
            int space = (number * 2)+2;
            for (int i = 1; i <= number; i++)
            {
                for (int z = 0; z < space; z++) Console.Write(" ");
                for (int j = i; j >= 1; j--) Console.Write(j+" ");
                if (i!=1)
                {
                    for (int k = 2; k <= i; k++) Console.Write(k + " ");
                }
                Console.WriteLine();
                space -= 2;
            }
        }
    }
}
