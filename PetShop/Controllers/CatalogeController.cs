using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetShop.Model;
using PetShop.Repositories;
using System.Text.Encodings.Web;

namespace PetShop.Controllers
{
    [Authorize]
    [AutoValidateAntiforgeryToken]
    public class CatalogeController : Controller
    {
        private IRepository _repository;
        private UrlEncoder _urlEncoder;

        public CatalogeController(IRepository repository,UrlEncoder encoder)
        {
            _repository = repository;
            _urlEncoder = encoder;
        }

        public async Task<IActionResult> Index()
        {   
            ViewBag.Categories = await _repository.GetCategoriesAsync();
            return View( await _repository.GetAllAnimalsAsync());
        }

        public async Task<IActionResult> Filter(int id)
        {
            if(id == 0)
            {
                ViewBag.Categories = await _repository.GetCategoriesAsync();
                return View("Index",await _repository.GetAllAnimalsAsync());
            }
            ViewBag.Categories = await _repository.GetCategoriesAsync();
            return View("Index", await _repository.GetAnimalsByCategoryIdAsync(id));
        }

        public async Task<IActionResult> ShowDetail(string name)
        {
            Animal animal = _repository.GetAnimalByName(name);
            ViewBag.Animal = animal;
            ViewBag.Category = _repository.GetCategoryByAnimal(animal);
            ViewBag.Comments = await _repository.GetCommentsByAnimalAsync(animal);
            return View();
        }

        public async Task<IActionResult> AddComment( string newComment, int animalId, string name)
        {
            if (ModelState.IsValid)
            {
                _repository.AddComment(new Comments { AnimalId = animalId, Comment = newComment});
                return Redirect(url: $"/Cataloge/ShowDetail?name={_urlEncoder.Encode(name)}"); // Use Encode here for protaction agenst 
            }
            Animal animal = _repository.GetAnimalByName(name);
            ViewBag.Animal = animal;
            ViewBag.Category = _repository.GetCategoryByAnimal(animal);
            ViewBag.Comments = await _repository.GetCommentsByAnimalAsync(animal);
            return View("ShowDetail");
        }

        public IActionResult RemoveComment(int id)
        {
            _repository.RemoveComment(id);
            return RedirectToAction("Index");
        }
    }
}
