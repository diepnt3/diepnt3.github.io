using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2Registation.Models
{
    public static class DeckCreate
    {
        public static Queue<Card> CreateCards()
        {
            Queue<Card> cards = new Queue<Card>();
            for(int i = 2; i<= 14; i++)
            {
                foreach(Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    cards.Enqueue(new Card()
                    {
                        Suit = suit,
                        Value = i,
                        DisplayName = GetShortName(i, suit)
                    });
                }
            }
            return Shuffle(cards);
        }
        public static Queue<Card> Shuffle(Queue<Card> cards)
        {
            List<Card> transformedCards = cards.ToList();
            Random r = new Random(DateTime.Now.Millisecond);
            for(int n = transformedCards.Count - 1; n > 0; n--)
            {
                int k = r.Next(n + 1);
                Card tmp = transformedCards[n];
                transformedCards[n] = transformedCards[k];
                transformedCards[k] = tmp;
            }
            Queue<Card> shuffledCards = new Queue<Card>();
            foreach(var card in transformedCards)
            {
                shuffledCards.Enqueue(card);
            }
            return shuffledCards;
        }
        public static string GetShortName(int value, Suit suit)
        {
            string valueDisplay = "";
            if(value >=2 && value <= 10)
            {
                valueDisplay = value.ToString();
            }
            else if(value == 11)
            {
                valueDisplay = "J";
            }
            else if(value == 12)
            {
                valueDisplay = "Q";
            }
            else if(value == 13)
            {
                valueDisplay = "K";
            }
            else if(value == 14)
            {
                valueDisplay = "A";
            }
            return valueDisplay + Enum.GetName(typeof(Suit), suit);
        }
    }
}
