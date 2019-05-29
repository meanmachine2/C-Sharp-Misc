using System;

namespace RandomNumberAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
            int unos = 1, zbroj = 0;

            while (unos!=0)
            {
                int i = RandomNumber(1, 100);
                int j = RandomNumber(1, 100);
                Console.WriteLine("Unesite zbroj - {0} + {1}", i, j);
                zbroj = int.Parse(Console.ReadLine());
                while (zbroj != (i + j))
                {
                    Console.WriteLine("pogrešan zbroj, unesite ponovno");
                    zbroj = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Točan unos");
            }         
        }
    }
}
