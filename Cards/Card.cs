using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Cards
{
    public class Card
    {
        public Card(int number)
        {
            Number = number;
        }

        public int Number { get; }
    }
}
