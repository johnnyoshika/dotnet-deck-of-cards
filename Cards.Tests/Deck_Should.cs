using System;
using System.Linq;
using Xunit;

namespace Cards.Tests
{
    public class Deck_Should
    {
        [Fact]
        public void Generate_Cards_With_Numbers()
        {
            var deck = new Deck(8);

            Assert.Equal(8, deck.Cards.Count());
            Assert.Equal(1, deck.Cards[0].Number);
            Assert.Equal(2, deck.Cards[1].Number);
            Assert.Equal(3, deck.Cards[2].Number);
            Assert.Equal(4, deck.Cards[3].Number);
            Assert.Equal(5, deck.Cards[4].Number);
            Assert.Equal(6, deck.Cards[5].Number);
            Assert.Equal(7, deck.Cards[6].Number);
            Assert.Equal(8, deck.Cards[7].Number);
        }

        [Fact]
        public void Calculate_Midpoint_For_Odd_Number_Of_Cards()
        {
            var deck = new Deck(7);
            var midpoint = deck.Midpoint;

            Assert.Equal(4, midpoint);
        }

        [Fact]
        public void Calculate_Midpoint_For_Even_Number_Of_Cards()
        {
            var deck = new Deck(8);
            var midpoint = deck.Midpoint;

            Assert.Equal(4, midpoint);
        }

        [Fact]
        public void Cut_At_Midpoint_For_Odd_Number_Of_Cards()
        {
            var deck = new Deck(7);
            deck.Cut();

            Assert.Equal(7, deck.Cards.Count());
            Assert.Equal(5, deck.Cards[0].Number);
            Assert.Equal(6, deck.Cards[1].Number);
            Assert.Equal(7, deck.Cards[2].Number);
            Assert.Equal(1, deck.Cards[3].Number);
            Assert.Equal(2, deck.Cards[4].Number);
            Assert.Equal(3, deck.Cards[5].Number);
            Assert.Equal(4, deck.Cards[6].Number);
        }

        [Fact]
        public void Cut_At_Midpoint_For_Even_Number_Of_Cards()
        {
            var deck = new Deck(8);
            deck.Cut();

            Assert.Equal(8, deck.Cards.Count());
            Assert.Equal(5, deck.Cards[0].Number);
            Assert.Equal(6, deck.Cards[1].Number);
            Assert.Equal(7, deck.Cards[2].Number);
            Assert.Equal(8, deck.Cards[3].Number);
            Assert.Equal(1, deck.Cards[4].Number);
            Assert.Equal(2, deck.Cards[5].Number);
            Assert.Equal(3, deck.Cards[6].Number);
            Assert.Equal(4, deck.Cards[7].Number);
        }
    }
}
