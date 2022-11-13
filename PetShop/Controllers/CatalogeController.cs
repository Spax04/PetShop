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
            ViewBag.AllAnimals = _repository.GetAllAnimals();
            ViewBag.Categories = _repository.GetCategories();
            return View();
        }

        public IActionResult ShowDetail(string name)
        {
            Animal animal = _repository.GetAnimalByName(name);
            ViewBag.Animal = animal;
            ViewBag.Comments = _repository.GetCommentsByAnimal(animal);
            return View();
        }

        public IActionResult AddComment(string text, Animal animal)
        {
            Comments newComment = new Comments() { AnimalId = animal.Id, Comment = text };
            _repository.AddComment(newComment);
            return View("ShowDetail");
        }
    }
}
