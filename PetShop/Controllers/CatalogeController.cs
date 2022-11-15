using Microsoft.AspNetCore.Mvc;
using PetShop.Model;
using PetShop.Repositories;

namespace PetShop.Controllers
{
    public class CatalogeController : Controller
    {
        private IRepository _repository;

        public CatalogeController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
             
            ViewBag.Categories = _repository.GetCategories();
            return View(_repository.GetAllAnimals());
        }
        public IActionResult Filter(Category category)
        {
            return View("Index", _repository.GetAnimalsByCategory(category));
        }

        public IActionResult ShowDetail(string name)
        {
            Animal animal = _repository.GetAnimalByName(name);
            ViewBag.Animal = animal;
            ViewBag.Category = _repository.GetCategoryByAnimal(animal);
            ViewBag.Comments = _repository.GetCommentsByAnimal(animal);
            return View();
        }




        public IActionResult AddComment(string text, Animal animal)
        {
            if (ModelState.IsValid)
            {
                Comments newComment = new Comments() { AnimalId = animal.Id, Comment = text };
                _repository.AddComment(newComment);
                return View("Index");
            }
            return View("Index");
        }
    }
}
