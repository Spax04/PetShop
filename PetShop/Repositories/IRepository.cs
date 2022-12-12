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


        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<IEnumerable<Comments>> GetCommentsByAnimalAsync(Animal t);
        Task<IEnumerable<Animal>> GetAnimalsByCategoryIdAsync(int id);

        Task<Animal> GetAnimalByNameAsync(string name);
        Task<Animal> GetAnimalByIdAsync(int id);
        Task AddCommentAsync(Comments newComment);
        Task RemoveCommentAsync(int id);
        Task<Category> GetCategoryByAnimalAsync(Animal animal);
    }
}
