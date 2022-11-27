using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetShop.Data;
using PetShop.Model;
using PetShop.Repositories;

namespace PetShop.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.TopAnimnals = _repository.GetTop();
            return View();
        }
    }
}
