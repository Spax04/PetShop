using Microsoft.EntityFrameworkCore;
using PetShop.Model;

namespace PetShop.Repositories
{
    public interface IRepository
    {
        void Insert(Animal a);
        void Update(int id, Animal a);
        void Delete(int id);

        IEnumerable<Animal> GetTop();
        IEnumerable<Animal> GetAllAnimals();
        IEnumerable<Category> GetCategories();
        IEnumerable<Comments> GetCommentsByAnimal(Animal t);
        IEnumerable<Animal> GetAnimalsByCategory(Category category);

        Animal GetAnimalByName(string name);
        void AddComment(Comments newComment);
        void RemoveComment(Comments comment);
        Animal GetAnimalById(int id);

        Category GetCategoryByAnimal(Animal animal);


    }
}
