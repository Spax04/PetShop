using Microsoft.EntityFrameworkCore;
using PetShop.Model;

namespace PetShop.Repositories
{
    public interface IRepository
    {
        Task InsertAsyinc(Animal a);
        Task UpdateAsync(int id, Animal a);
        Task DeleteAsync(int id);

        Task<IEnumerable<Animal>> GetTopAsync();
        Task<IEnumerable<Animal>> GetAllAnimalsAsync();

        IEnumerable<Category> GetCategories();
        IEnumerable<Comments> GetCommentsByAnimal(Animal t);
        IEnumerable<Animal> GetAnimalsByCategoryId(int id);

        Animal GetAnimalByName(string name);
        void AddComment(Comments newComment);
        void RemoveComment(int id);
        Animal GetAnimalById(int id);

        Category GetCategoryByAnimal(Animal animal);

         void AddNewUser(Login newUser);


    }
}
