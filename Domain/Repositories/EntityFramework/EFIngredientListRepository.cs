using System;
using System.Collections.Generic;
using System.Linq;
using CourseWork.Domain.Entities;
using CourseWork.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Domain.Repositories.EntityFramework
{
        public class EFIngredientListRepository : IIngredientListRepository
        {
            private readonly ApplicationDbContext _context;

            public EFIngredientListRepository(ApplicationDbContext context)
            {
                _context = context;
            }
            
            public IEnumerable<IngredientList> GetRecipes()
            {
                return _context.IngredientLists.Include(x => x.Ingredients).ToList();
            }

            public IngredientList Get(Guid id)
            {
                return GetRecipes().FirstOrDefault(x => x.Id == id);
            }

            public void Save(IngredientList list)
            {
                _context.Entry(list).State = list.Id == default ? EntityState.Added : EntityState.Modified;
                _context.SaveChanges();
            }

            public void Delete(Guid id)
            {
                _context.IngredientLists.Remove(new IngredientList { Id = id });
                foreach (var ingredient in _context.Ingredients.Where(x => x.IngredientListId == id))
                {
                    _context.Ingredients.Remove(ingredient);
                }
                _context.SaveChanges();
            }
    }
}