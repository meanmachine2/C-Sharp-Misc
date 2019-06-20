using System;

namespace SortIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            Console.WriteLine("Enter number 1. : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2. : ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 3. : ");
            int number3 = int.Parse(Console.ReadLine());
            if (number2 < number1||number3<number1)
            {
                if (number2<number1)
                {
                    temp = number1;
                    number1 = number2;
                    number2 = temp;
                }
                if (number3<number1)
                {
                    temp = number1;
                    number1 = number3;
                    number3 = temp;
                }               
            }
           if (number3 < number2)
            {
                temp = number2;
                number2 = number3;
                number3 = temp;
            }
           Console.WriteLine("{0} {1} {2}",number1,number2,number3);
        }
    }
}
