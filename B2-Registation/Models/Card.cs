using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2Registation.Models
{
    public enum Suit
    {
        Clubs,
        Diamonds,
        Spades,
        Hearts
    }
    public class Card
    {
        public string DisplayName { get; set; }
        public Suit Suit { get; set; }
        public int Value { get; set; }
        public Card() { }
        public Card(string display, Suit suit)
        {
            DisplayName = display;
            Suit = suit;
        }
    }
}
