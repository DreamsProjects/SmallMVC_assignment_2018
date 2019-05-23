using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class NorthwindController : Controller
    {

        private readonly NorthwindContext _context;

        public NorthwindController(NorthwindContext context)
        {
            _context = context;
        }

        public IActionResult GetData()
        {
            var items = _context.Products.Where(x => x.CategoryId == 0);

            return View(items.ToList());
        }

        public IActionResult ActionLink()
        {
            var items = _context.Categories.Where(x => x.CategoryId > 0);

            return View(items.ToList());
        }

        public IActionResult Choosen(int? id)
        {
            var items = _context.Products.Where(x => x.CategoryId == id);

            return View(items.ToList());
        }
    }
}