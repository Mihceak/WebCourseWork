using System;
using System.Collections.Generic;
using CourseWork.Domain.Entities;

namespace CourseWork.Domain.Repositories.Abstract
{
    public interface IIngredientRepository
    {
        IEnumerable<Ingredient> GetRecipes();
        Ingredient Get(Guid id);
        Ingredient Get(string name);
        void Save(Ingredient ingredient);
        void Delete(Guid id);
    }
}