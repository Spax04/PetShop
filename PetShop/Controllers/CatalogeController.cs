using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetShop.Model;
using PetShop.Repositories;

namespace PetShop.Controllers
{
    [Authorize]
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

        public IActionResult Filter(int id)
        {
            if(id == 0)
            {
                ViewBag.Categories = _repository.GetCategories();
                return View("Index", _repository.GetAllAnimals());
            }
            ViewBag.Categories = _repository.GetCategories();
            return View("Index", _repository.GetAnimalsByCategoryId(id));
        }

        public IActionResult ShowDetail(string name)
        {
            Animal animal = _repository.GetAnimalByName(name);
            ViewBag.Animal = animal;
            ViewBag.Category = _repository.GetCategoryByAnimal(animal);
            ViewBag.Comments = _repository.GetCommentsByAnimal(animal);
            return View();
        }

        public IActionResult AddComment( string newComment, int animalId, string name)
        {
            if (ModelState.IsValid)
            {
                _repository.AddComment(new Comments { AnimalId = animalId, Comment = newComment});
                return Redirect(url: $"/Cataloge/ShowDetail?name={name}");
            }
            Animal animal = _repository.GetAnimalByName(name);
            ViewBag.Animal = animal;
            ViewBag.Category = _repository.GetCategoryByAnimal(animal);
            ViewBag.Comments = _repository.GetCommentsByAnimal(animal);
            return View("ShowDetail");
        }

        public IActionResult RemoveComment(int id)
        {
            _repository.RemoveComment(id);
            return RedirectToAction("Index");
        }
    }
}
