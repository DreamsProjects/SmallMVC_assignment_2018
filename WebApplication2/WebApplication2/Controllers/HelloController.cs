using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewHello()
        {
            ViewBag.Message = "Hello MVC - Nu kör vi!!";
            return View();
        }

        public IActionResult RandomNumber()
        {
            Random rand = new Random();
            var first = rand.Next(1, 10);

            if (first >= 1 || first <= 3)
            {
                ViewBag.Random = "Talet är mellan 1 och 3 " + first;
            }

            if (first >= 4 && first <= 6)
            {
                ViewBag.Random = "Talet är mellan 4 och 6 " + first;
            }

            if (first >= 7 || first >= 10)
            {
                ViewBag.Random = "Talet är mellan 7 och 10 " + first;
            }
            return View();
        }

        public IActionResult List()
        {
            List<string> Items = new List<string>();

            Items.Add("Ett");
            Items.Add("Två");
            Items.Add("Tre");
            Items.Add("Fyra");
            Items.Add("fem");

            ViewBag.Names = Items;

            return View();
        }


        public IActionResult UpdateDateTime()
        {
            DateTime time = DateTime.Now;
            ViewBag.Time = time;
            return View();
        }


        public IActionResult SkickaFråga()
        {
            return View();
        }

        public IActionResult TackFråga()
        {
            return View();
        }


    }
}