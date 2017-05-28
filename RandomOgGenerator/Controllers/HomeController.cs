using System;
using System.Web.Mvc;
using RandomOgGenerator.Helpers;

namespace RandomOgGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var quotes = ListHelper.QuoteList();

            Random randNum = new Random();
            int randomIndex = randNum.Next(quotes.Count);

            string quote = quotes[randomIndex];
            ViewBag.Quote = quote;

            return View();
        }

        public ActionResult SafeQuote()
        {
            var quotes = ListHelper.SafeQuoteList();

            Random randNum = new Random();
            int randomIndex = randNum.Next(quotes.Count);

            string quote = quotes[randomIndex];
            ViewBag.Quote = quote;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}