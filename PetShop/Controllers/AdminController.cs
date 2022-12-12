using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetShop.Model;
using PetShop.Repositories;
using System.Runtime.InteropServices;

namespace PetShop.Controllers
{
    [Authorize(Roles = "Admin")]
    // // Cant get in because of this
    public class AdminController : Controller
    {
        private IRepository _repository;

        public AdminController(IRepository repository)
        {
            this._repository = repository;
        }

        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Index()
        {
            ViewBag.Categories = _repository.GetCategories();
            return View(await _repository.GetAllAnimalsAsync());
        }

        public async Task<IActionResult> Filter(int id)
        {
            if (id == 0)
            {
                ViewBag.Categories = _repository.GetCategories();
                return View("Index",await _repository.GetAllAnimalsAsync());
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
        public async Task<IActionResult> Create(Animal animal)
        {
            
            if (ModelState.IsValid)
            {
                await _repository.InsertAsyinc(animal);
                return RedirectToAction("Index");
            }
            ViewBag.Categories = _repository.GetCategories();
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _repository.GetCategories();
            Animal animal = _repository.GetAnimalById(id);
            

            return View(animal);
        }

        [HttpPost] 
        public async Task<IActionResult> Edit(int id,Animal animal)
        {
            if (ModelState.IsValid)
            {
                await _repository.UpdateAsync(id,animal);
                return RedirectToAction("Index");
            }

            ViewBag.Categories = _repository.GetCategories();
            return View(animal);
        }

        public async Task<IActionResult> Delete(string name)
        {
            Animal animal = _repository.GetAnimalByName(name);
            IEnumerable<Comments> aComments = _repository.GetCommentsByAnimal(animal);

            foreach (Comments comment in aComments)
            {
                _repository.RemoveComment(comment.Id);
            }

            await _repository.DeleteAsync(animal.Id);
            return RedirectToAction("Index");
        }
    }
}
