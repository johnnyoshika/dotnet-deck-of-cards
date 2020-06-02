using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cards
{
    public class Deck
    {
        public Deck(int count)
        {
            Cards = new List<Card>();
        }

        public List<Card> Cards { get; private set; }

        public void Cut() {}

        internal int Midpoint => 0;
    }
}
