using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class FormularController : Controller
    {
        public List<Question> quest = new List<Question>();

        public IActionResult Index()
        {
            RegisterViewModel model = new RegisterViewModel();

            List<SelectListItem> country = new List<SelectListItem>()
            {
                new SelectListItem { Value = "1", Text = "Sweden" },
                new SelectListItem { Value = "2", Text = "Norway" },
                new SelectListItem { Value = "3", Text = "Denmark" }
            };


            List<SelectListItem> userType = new List<SelectListItem>()
            {
                 new SelectListItem { Value = "1", Text = "Normal" },
                 new SelectListItem { Value = "2", Text = "Premium" },
                 new SelectListItem { Value = "3", Text = "VIP" }
            };

            model.Country = country;
            model.UserType = userType;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(RegisterViewModel reg)
        {
            return View("Index2");
        }



        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel();

            List<SelectListItem> country = new List<SelectListItem>()
            {
                new SelectListItem { Value = "1", Text = "Sweden" },
                new SelectListItem { Value = "2", Text = "Norway" },
                new SelectListItem { Value = "3", Text = "Denmark" }
            };


            List<SelectListItem> userType = new List<SelectListItem>()
            {
                 new SelectListItem { Value = "1", Text = "Normal" },
                 new SelectListItem { Value = "2", Text = "Premium" },
                 new SelectListItem { Value = "3", Text = "VIP" }
            };

            model.Country = country;
            model.UserType = userType;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register info)
        {

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult AddQuestion()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddQuestion([Bind("Email,QuestionText")]Question quests)
        {
            quest.Add(quests);

            return View("Question", quests);
        }

        public IActionResult Click()
        {
            return View();
        }


    }
}