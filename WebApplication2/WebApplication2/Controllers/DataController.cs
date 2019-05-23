using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DataController : Controller
    {

        public IActionResult Index()
        {
            return View(GetData());
        }

        List<News> news = new List<News>();

        public IActionResult NewsDetails()
        {
            return View(GetData());
        }

        public IActionResult NewsList(int? id)
        {
            //var find = news.Where(x => x.ID == id);
            News list = GetData().SingleOrDefault(x => x.ID == id);

            return View(list);
        }


        public List<News> GetData()
        {
           List<News> news = new List<News>()
            {
            new News(1, "Huvudnyhet om Stockholm","Stockholms börsen har gått ner med 10%! Detta var inte bra, för nu går både banker och bostädsbetalare i konkurrs. AJAJAJAJA!!!!!!!!!"),

            new News(2, "TITEEEEEEEEEEL", "text om nyhet! text om nyhet! text om nyhet! text om nyhet! text om nyhet! text om nyhet! text om nyhet! text om nyhet! text om nyhet! text om nyhet! text om nyhet! text om nyhet!  text om nyhet!  text om nyhet!  text om nyhet!  text om nyhet!  text om nyhet! ")

           };

            return news;
        }
    }
}