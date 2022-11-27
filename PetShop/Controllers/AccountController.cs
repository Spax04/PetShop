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
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IdentityRole adminRole;

        public  AccountController(IRepository repository, UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _repository = repository;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;

            adminRole = new IdentityRole()
            {
                Name = "Admin"
            };

             
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


        [HttpGet]
        public  IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Login newUser)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = newUser.UserName,

            };

            var result = await _userManager.CreateAsync(user, newUser.Password); /*"123qwe!@#QWE"*/
            await _roleManager.CreateAsync(adminRole);
            if (newUser.isAdmin == true)
                await _userManager.AddToRoleAsync(user, adminRole.Name);


            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
