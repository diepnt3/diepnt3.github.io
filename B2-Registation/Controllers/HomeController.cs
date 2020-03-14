using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using B2_Registation.Models;
using B2Registation.Models;

namespace B2_Registation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<String> result = new List<string>();
            Game game = new Game("Holly", "Nick");
            string holly = "Holly";
            string nick = "Nick";
            for (int i = 0; i < game.Player1.Deck.Count; i++)
            {
                holly = holly + " " + (game.Player1.Deck).ToList()[i].DisplayName + " " + (game.Player1.Deck).ToList()[i].Suit;
            }
            for (int i = 0; i < game.Player2.Deck.Count; i++)
            {
                nick = nick + " " + (game.Player2.Deck).ToList()[i].DisplayName + " " + (game.Player2.Deck).ToList()[i].Suit;
            }
            result.Add(String.Format($"{holly}"));
            result.Add(String.Format($"{nick}"));
            List<Card> cards = CreateCard.Create();
            Player pl1, pl2;
            pl1 = new Player();
            pl2 = new Player();
            var deck = pl1.shareC(cards);
            pl2.Listcard = deck;
            string PL1 = "PL1: ";
            for (int i = 0; i < pl1.Listcard.Count; i++)
            {
                PL1 = PL1 + " " + (pl1.Listcard).ToList()[i].DisplayName + (pl1.Listcard).ToList()[i].Suit;
            }
            string PL2 = "PL2: ";
            for (int i = 0; i < pl2.Listcard.Count; i++)
            {
                PL2 = PL2 + " " + (pl2.Listcard).ToList()[i].DisplayName + (pl2.Listcard).ToList()[i].Suit;
            }
            result.Add(String.Format($"{PL1}"));
            result.Add(String.Format($"{PL2}"));
            return View(result);
        }
        public string Index2()
        {
            return "index2 is me";
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Student student)
        {
            if(ModelState.IsValid)
            {
                Reponsetory.AddStudent(student);
                return View("myView", student);

            } else {
                return View();
            }
        }
        public IActionResult StudentList()
        {
            return View(Reponsetory.GetStudents());
        }
    }
}
