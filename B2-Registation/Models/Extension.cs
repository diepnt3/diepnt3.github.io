using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2Registation.Models
{
    public static class Extension
    {
        public static void Enqueue(this Queue<Card> cards, Queue<Card> newCard)
        {
            foreach(var card in newCard)
            {
                cards.Enqueue(card);
            }
        }
    }
}
