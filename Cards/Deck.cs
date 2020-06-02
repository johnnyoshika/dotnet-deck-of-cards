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
            Cards = Enumerable
                .Range(1, count)
                .Select(i => new Card(i))
                .ToList();
        }

        public List<Card> Cards { get; private set; }

        public void Cut() =>
            Cards = Cards.Skip(Midpoint)
                .Concat(Cards.Take(Midpoint))
                .ToList();

        internal int Midpoint => (int)Math.Ceiling((decimal)Cards.Count() / 2);
    }
}
