using System;
using System.Collections.Generic;
using System.Linq;
using CourseWork.Domain.Entities;
using CourseWork.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Domain.Repositories.EntityFramework
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private readonly ApplicationDbContext _context;

        public EFRecipeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Recipe> GetRecipes()
        {
            return _context.Recipes.Include(x => x.IngredientLists).ThenInclude(x => x.Ingredients).ToList();
        }

        public Recipe Get(Guid id)
        {
            return GetRecipes().FirstOrDefault(x => x.Id == id);
        }

        public Recipe Get(string title)
        {
            return GetRecipes().FirstOrDefault(x => x.Title == title);
        }

        public void Save(Recipe recipe)
        {
            _context.Entry(recipe).State = recipe.Id == default ? EntityState.Added : EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _context.Recipes.Remove(new Recipe { Id = id });
            _context.SaveChanges();
        }
    }
}