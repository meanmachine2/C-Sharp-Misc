using System;

namespace Probelm_Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of the side of the ground: ");
            int groundLength = int.Parse(Console.ReadLine());
            Console.Write("Enter width per tile: ");
            double widthTile = double.Parse(Console.ReadLine());
            Console.Write("Enter length per tile: ");
            double lengthTile = double.Parse(Console.ReadLine());
            Console.Write("Enter bench width: ");
            int benchWidth = int.Parse(Console.ReadLine());
            Console.Write("Enter bench length: ");
            int benchLength = int.Parse(Console.ReadLine());
            double areaToCover = (groundLength * groundLength) - (benchLength*benchWidth);
            double tilesNumber = areaToCover/ (widthTile * lengthTile);
            double workTime = tilesNumber * 0.2;
            Console.WriteLine("Total tiles necessery are {0}, and work time is {1}", tilesNumber, workTime);        
        }
    }
}
