using System;

namespace paramaterTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] polje = new int[] { 1, 2, 3 };
            for (int i = 0; i <=2; i++)
            {
                Console.WriteLine("Unesite kut broj {0}:",i);
                polje[i] = int.Parse(Console.ReadLine());
            }
            int sum1 = polje[0] + polje[1];
            int sum2 = polje[1] + polje[2];
            int sum3 = polje[2] + polje[0];
            if ((sum1 > polje[2]) && (sum2 > polje[0]) && (sum3 > polje[1])) Console.WriteLine("unos je ispravan");
            else Console.WriteLine("unos nije ispravan");
        }
    }
}
