using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFQuestion.Models;

namespace EFQuestion.Controllers
{
    public class UserLoginsController : Controller
    {
        private readonly LoginDB _context;

        public UserLoginsController(LoginDB context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLogin kund)
        {
            var account = _context.Users.Where(x => x.Email == kund.Email && x.Password == kund.Password).FirstOrDefault();

            if (account != null)
            {
                return RedirectToAction("Welcome", account);
            }

            var account2 = _context.Users.Where(x => x.UserID == kund.UserID && x.Password == kund.Password).FirstOrDefault();

            if (account2 != null)
            {

                return RedirectToAction("Welcome", account2);
            }

            else
            {
                ModelState.AddModelError("", "Wrong input");
            }

            return View();
        }

        public IActionResult ViewList()
        {
            var people = _context.Users.ToList();

            return View(people.ToList());
        }

        public IActionResult Welcome(UserLogin user)
        {
            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(UserLogin user)
        {
            _context.Users.Where(x => x.UserID == user.UserID);

            _context.Update(user);
            _context.SaveChangesAsync();
            return View();
        }


        [HttpPost]
        public IActionResult Delete(UserLogin user)
        {
            _context.Users.Where(x => x.UserID == user.UserID);
            _context.Remove(user);
            _context.SaveChangesAsync();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("UserID, Name,Password,Email,City")] UserLogin userLogin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userLogin);
                _context.SaveChanges();
            }
            return View(userLogin);
        }
    }
}
