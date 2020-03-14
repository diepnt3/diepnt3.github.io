using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2Registation.Models
{
    public class Player
    {
        public string Name { get; set; }
        public Queue<Card> Deck {get; set;}
        public List<Card> Listcard { get; set; }

        public Player() { }

        public Player(string name)
        {
            Name = name;
        }

        public Queue<Card> Deal(Queue<Card> cards)
        {
            Queue<Card> player1cards = new Queue<Card>();
            Queue<Card> player2cards = new Queue<Card>();

            int counter = 2;
            while (cards.Any())
            {
                if (counter % 2 == 0) //Card etiquette says the player who is NOT the dealer gets first card
                {
                    player2cards.Enqueue(cards.Dequeue());
                }
                else
                {
                    player1cards.Enqueue(cards.Dequeue());
                }
                counter++;
            }

            Deck = player1cards;
            return player2cards;
        }
        public List<Card> shareC(List<Card> cards)
        {
            List<Card> list1 = new List<Card>();
            List<Card> list2 = new List<Card>();
            int count = 2;
            int i = 51;
            while(i >= 0)
            {
                if(i%2 == 0)
                {
                    list2.Add(cards.ToList()[i]);
                } else
                {
                    list1.Add(cards.ToList()[i]);
                }
                i--;
            }
            Listcard = list1;
            return list2;
        }
    }
}
