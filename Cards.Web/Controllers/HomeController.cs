using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cards.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        [HttpGet("load")]
        public IActionResult Load(int number) => Json(new Deck(number).ToJson());

        [HttpGet("cut")]
        public IActionResult Cut(int number)
        {
            var deck = new Deck(number);
            deck.Cut();
            return Json(deck.ToJson());
        }
    }

    public static class CardJson
    {
        public static object ToJson(this Card card) =>
            new
            {
                number = card.Number
            };

        public static object ToJson(this Deck deck) =>
            deck.Cards.Select(c => c.ToJson());
    }
}
