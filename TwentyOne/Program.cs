using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _21Game game = new _21Game();
            Deck deck = new Deck();
            deck.Shuffle(3);
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " Of " + card.Suit);
            }
            Console.WriteLine("Total of " + deck.Cards.Count + " Card's");
            Console.ReadLine();
        }
    }
}

