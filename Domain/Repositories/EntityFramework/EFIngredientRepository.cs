using System;
using System.Collections.Generic;
using System.Linq;
using CourseWork.Domain.Entities;
using CourseWork.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Domain.Repositories.EntityFramework
{
    public class EFIngredientRepository : IIngredientRepository
    {
        private readonly ApplicationDbContext _context;

        public EFIngredientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Ingredient> GetRecipes()
        {
            return _context.Ingredients.ToList();
        }

        public Ingredient Get(Guid id)
        {
            return GetRecipes().FirstOrDefault(x => x.Id == id);
        }

        public Ingredient Get(string name)
        {
            return GetRecipes().FirstOrDefault(x => x.Name == name);
        }

        public void Save(Ingredient ingredient)
        {
            _context.Entry(ingredient).State = ingredient.Id == default ? EntityState.Added : EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _context.Ingredients.Remove(new Ingredient { Id = id });
            _context.SaveChanges();
        }
    }
}