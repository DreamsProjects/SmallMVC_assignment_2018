using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MyFormsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoadPage()
        {
            ModelState.Clear();
            Message mess = new Message();
            return View(mess);
        }
    }
}