using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PetShop.Data;
using PetShop.Model;
using System.Collections.Generic;

namespace PetShop.Repositories
{
    public class PetRepository : IRepository
    {
        private StoreContext _context;

        public PetRepository(StoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Animal> GetAllAnimals() => _context.Animals!;
        public IEnumerable<Category> GetCategories() => _context.Categories!;
        public IEnumerable<Comments> GetComments() => _context.Comments!;
        public Animal GetAnimalByName(string name) => _context.Animals!.First(a => a.Name == name);
        public Animal GetAnimalById(int id) => _context.Animals!.First(a => a.Id == id);
        public IEnumerable<Comments> GetCommentsByAnimal(Animal animal) => _context.Comments.Where(t => t.AnimalId == animal.Id).ToList();
        public IEnumerable<Animal> GetTop()
        {
            return _context.Animals!.Include(c => c.Comments).OrderByDescending(c => c.Comments!.Count()).Take(2).ToList();
            
        }

        public void RemoveComment(Comments comment)
        {
            Comments removableComment = _context.Comments!.First(c => c == comment);

            _context.Comments!.Remove(removableComment);
        }

        public void AddComment(Comments newComment)
        {
            _context.Comments.Add(newComment);
            _context.SaveChanges();
        }


        public void Insert(Animal animal)
        {
            _context.Animals.Add(animal);
            _context.SaveChanges();
        }

        public void Update(int id, Animal animal)
        {
            var animalInDb = _context.Animals!.Single(a => a.Id == id);

            animalInDb.Age = animal.Age;
            animalInDb.Category = animal.Category;
            animalInDb.PictureName = animal.PictureName;
            animalInDb.Discription = animal.Discription;
            animalInDb.CategoryId = animal.CategoryId;
            animalInDb.Category = animal.Category;

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var animal = _context.Animals!.Single( a => a.Id == id);
            _context.Animals.Remove(animal);
            _context.SaveChanges();
        }

        public IEnumerable<Animal> GetAnimalsByCategory(Category category)
        {
            return _context.Animals!.Where(c => c.CategoryId == category.Id);
        }

        public Category GetCategoryByAnimal(Animal animal)
        {
            return _context.Categories!.First(c => c.Id == animal.CategoryId);
        }
    }
}
