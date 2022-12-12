﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore;

using PetShop.Data;
using PetShop.Model;
using System.Collections.Generic;

namespace PetShop.Repositories
{
    public class PetRepository : IRepository
    {
        private StoreContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public PetRepository(StoreContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IEnumerable<Animal> GetAllAnimals() => _context.Animals!;
        public Task<IEnumerable<Animal>> GetAllAnimalsAsync() => Task.Run(() => GetAllAnimals());

        public IEnumerable<Category> GetCategories() => _context.Categories!;
        public IEnumerable<Comments> GetComments() => _context.Comments!;
        public Animal GetAnimalByName(string name) => _context.Animals!.First(a => a.Name == name);

        public Animal GetAnimalById(int id) => _context.Animals!.First(a => a.Id == id);
        public IEnumerable<Comments> GetCommentsByAnimal(Animal animal) => _context.Comments.Where(t => t.AnimalId == animal.Id).ToList();

        public IEnumerable<Animal> GetTop() => _context.Animals!.Include(c => c.Comments).OrderByDescending(c => c.Comments!.Count()).Take(2).ToList(); 
        public async Task<IEnumerable<Animal>> GetTopAsync() =>  await Task.Run(() => GetTop());

        public void RemoveComment(int id)
        {
            Comments removableComment = _context.Comments!.First(c => c.Id == id);

            _context.Comments!.Remove(removableComment);
            _context.SaveChanges();
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
        public Task InsertAsyinc(Animal a) =>  Task.Run(() => Insert(a));


        public void Update(int id, Animal animal)
        {
            var animalInDb = _context.Animals!.Single(a => a.Id == id);

            animalInDb.Name = animal.Name;
            animalInDb.Age = animal.Age;
            animalInDb.PictureName = animal.PictureName;
            animalInDb.Discription = animal.Discription;
            animalInDb.CategoryId = animal.CategoryId;
            
            _context.SaveChanges();
        }

        public Task UpdateAsync(int id, Animal animal) => Task.Run(()=> Update(id,animal));

        public void Delete(int id)
        {
            var animal = _context.Animals!.Single( a => a.Id == id);
            _context.Animals.Remove(animal);
            _context.SaveChanges();
        }

        public Task DeleteAsync(int id) => Task.Run(()=> Delete(id));


        public IEnumerable<Animal> GetAnimalsByCategoryId(int id)
        {
            return _context.Animals!.Where(c => c.CategoryId == id);
        }

        public Category GetCategoryByAnimal(Animal animal)
        {
            return _context.Categories!.First(c => c.Id == animal.CategoryId);
        }

        public async void AddNewUser(Login newUser)
        {
            IdentityUser user = new IdentityUser()
            {
                UserName = newUser.UserName,
            };

            var result = await _userManager.CreateAsync(user, newUser.Password);

            _context.SaveChanges();
        }
    }
}
