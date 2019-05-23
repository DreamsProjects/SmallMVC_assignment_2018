using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class NewsController : Controller
    {
        private readonly NewsContext _context;


        public NewsController(NewsContext context)
        {
            _context = context;
        }
 

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetData()
        {
            var result = _context.News.Include(x => x.Kategori);

            return View(result.ToList());
        }

        public IActionResult Clicked(int id)
        {
            var result = _context.Kategori.Where(x => x.Id == id);

            return View(result.ToList());
        }
    }
}