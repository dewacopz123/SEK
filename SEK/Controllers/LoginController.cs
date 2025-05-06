using Microsoft.AspNetCore.Mvc;
using SEK.Models;

namespace SEK.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Dummy check - replace with your own login logic
                if (model.Username == "admin" && model.Password == "admin")
                {
                    // Redirect to home or dashboard
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }

            return View(model);
        }
    }
}
