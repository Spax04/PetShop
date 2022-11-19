using PetShop.Model;
using PetShop.Repositories;

namespace PetStore.Tests
{
    [TestClass]
    public class FakeRepository : IRepository
    {

        private IEnumerable<Animal> _animals;
        private IEnumerable<Category> _category;
        private IEnumerable<Comments> _comments;
        public FakeRepository()
        {
            _category = new List<Category>() 
            { 
                new Category() { Id = 1, Name = "CategoryOne" }, 
                new Category() { Id = 2, Name = "CategoryTwo" } 
            };

            _animals = new List<Animal>() 
            { 
                new Animal() { Id = 1 , CategoryId = 1, Age = 1 , Name = "AnimalOne", PictureName="PictureURl",Discription = "AnimalOneDiscription"},
                new Animal() { Id = 2, CategoryId = 2, Age = 2, Name = "AnimalTwo", PictureName = "PictureURl", Discription = "AnimalTwoDiscription" },
                new Animal() { Id = 3 , CategoryId = 3, Age = 3 , Name = "AnimalThree", PictureName="PictureURl",Discription = "AnimalThreeDiscription"},
                new Animal() { Id = 4 , CategoryId = 4, Age = 4 , Name = "AnimalFour", PictureName="PictureURl",Discription = "AnimalFourDiscription"}
            };

            _comments = new List<Comments>() 
            {
                new Comments{ Id = 1, AnimalId = 1, Comment="CommentCommnetComment"},
                new Comments{ Id = 2, AnimalId = 1, Comment="CommentCommnetComment"},
                new Comments{ Id = 3, AnimalId = 2, Comment="CommentCommnetComment"},
                new Comments{ Id = 4, AnimalId = 2, Comment="CommentCommnetComment"},
                new Comments{ Id = 5, AnimalId = 3, Comment="CommentCommnetComment"},
                new Comments{ Id = 6, AnimalId = 4, Comment="CommentCommnetComment"}
            };
        }
        #region Repository Methods
        public void AddComment(Comments newComment)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Animal> GetAllAnimals()
        {
            return _animals;
        }

        public Animal GetAnimalById(int id)
        {
            throw new NotImplementedException();
        }

        public Animal GetAnimalByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Animal> GetAnimalsByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _category;
        }

        public Category GetCategoryByAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comments> GetCommentsByAnimal(Animal t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Animal> GetTop()
        {
            throw new NotImplementedException();
        }

        public void Insert(Animal a)
        {
            throw new NotImplementedException();
        }

        public void RemoveComment(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Animal a)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
