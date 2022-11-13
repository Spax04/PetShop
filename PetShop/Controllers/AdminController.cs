using Microsoft.AspNetCore.Mvc;
using PetShop.Model;
using PetShop.Repositories;

namespace PetShop.Controllers
{
    public class AdminController : Controller
    {
        private IRepository _repository;

        public AdminController(IRepository repository)
        {
            this._repository = repository;
        }

        public IActionResult Index()
        {
            ViewBag.Animals = _repository.GetAllAnimals();
            ViewBag.Categories = _repository.GetCategories();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Animal animal)
        {
            if (ModelState.IsValid)
            {
                _repository.Insert(animal);
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(Animal animal)
        {

        }
    }
}
