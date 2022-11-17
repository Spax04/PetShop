using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetShop.Model;
using PetShop.Repositories;
using System.Runtime.InteropServices;

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
            ViewBag.Categories = _repository.GetCategories();
            return View(_repository.GetAllAnimals());
        }

        public IActionResult Filter(int id)
        {
            if (id == 0)
            {
                ViewBag.Categories = _repository.GetCategories();
                return View("Index", _repository.GetAllAnimals());
            }
            ViewBag.Categories = _repository.GetCategories();
            return View("Index", _repository.GetAnimalsByCategoryId(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = _repository.GetCategories();
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

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _repository.GetCategories();
            Animal animal = _repository.GetAnimalById(id);
            

            return View(animal);
        }

        [HttpPost]
        public IActionResult Edit(int id,Animal animal)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(id,animal);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(string name)
        {
            Animal animal = _repository.GetAnimalByName(name);
            IEnumerable<Comments> aComments = _repository.GetCommentsByAnimal(animal);

            foreach (Comments comment in aComments)
            {
                _repository.RemoveComment(comment);
            }

            _repository.Delete(animal.Id);
            return RedirectToAction("Index");
        }
    }
}
