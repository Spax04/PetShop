using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetShop.Model;
using PetShop.Repositories;

namespace PetShop.Controllers
{
    public class AccountController : Controller
    {
        IRepository _repository;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(IRepository repository, UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            _repository = repository;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Home");
                }
            }
            return View();
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Register()
        {
            IdentityUser user = new IdentityUser
            {
                UserName = "alex",
            };

            var result = await _userManager.CreateAsync(user,"123qwe!@#QWE");


            if (result.Succeeded)
            {
                return Content("Created successfully");
            }

            return Content("Register error");
        }
    }
}
