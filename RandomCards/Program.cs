using System;

namespace RandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rank = new string[13] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suit = new string[4] { "Clubs", "Diamonds", "Hearts", "Spades" };
            Random rankRandom = new Random();
            int newRank = rankRandom.Next(0, 12);
            int newSuit = rankRandom.Next(0, 3);
            Console.WriteLine(rank[newRank] + " of " + suit[newSuit]);
        }
    }
}
