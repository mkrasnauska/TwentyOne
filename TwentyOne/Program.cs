﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card cardOne= new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";
            Console.WriteLine(cardOne.Face+ " Of "+cardOne.Suit);
            Console.ReadLine();
        }
    }
}
