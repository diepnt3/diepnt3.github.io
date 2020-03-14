using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2Registation.Models
{
    public class CreateCard
    {
        public List<Card> Create()
        {
            List<Card> listCard = new List<Card>();
            foreach(Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for(int i = 2; i <= 14; i++)
                {
                    if (i == 11)
                    {
                        listCard.Add(new Card("J", suit));
                    }
                    else if (i == 12)
                    {
                        listCard.Add(new Card("Q", suit));
                    }
                    else if (i == 13)
                    {
                        listCard.Add(new Card("K", suit));
                    }
                    else if (i == 14)
                    {
                        listCard.Add(new Card("A", suit));
                    }
                    else
                    {
                        listCard.Add(new Card(i.ToString(), suit));
                    }
                }
            }
            return ShuffleCard(listCard);
        }
        public List<Card> ShuffleCard(List<Card> cards)
        {
            Random r = new Random();
            for(int i = cards.Count-1; i>0 ; i--)
            {
                int k = r.Next(i + 1);
                Card tmp = cards[k];
                cards[i] = cards[k];
                cards[k] = tmp;
            }
            return cards;
        }
    }
}
