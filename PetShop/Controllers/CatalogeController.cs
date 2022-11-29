using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetShop.Model;
using PetShop.Repositories;
using System.Text.Encodings.Web;

namespace PetShop.Controllers
{
    [Authorize]
    [ValidateAntiForgeryToken]
    public class CatalogeController : Controller
    {
        private IRepository _repository;
        private UrlEncoder _urlEncoder;

        public CatalogeController(IRepository repository,UrlEncoder encoder)
        {
            _repository = repository;
            _urlEncoder = encoder;
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
                return Redirect(url: $"/Cataloge/ShowDetail?name={_urlEncoder.Encode(name)}"); // Use Encode here
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
