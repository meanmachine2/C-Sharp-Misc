using System;

namespace integerSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int unos = int.Parse(Console.ReadLine());
            int zbroj = 0;
            while (unos>0)
            {
                zbroj += (unos % 10);
                unos /= 10;
            }
            Console.WriteLine(zbroj);

        }
    }
}
