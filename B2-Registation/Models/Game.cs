using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2Registation.Models
{
    public class Game
    {
        public Player Player1;
        public Player Player2;
        private int TurnCount;
        public Game(string player1name, string player2name)
        {
            Player1 = new Player(player1name);
            Player2 = new Player(player2name);
            var cards = DeckCreate.CreateCards();
            var deck = Player1.Deal(cards);
            Player2.Deck = deck;
        }
    }
}
