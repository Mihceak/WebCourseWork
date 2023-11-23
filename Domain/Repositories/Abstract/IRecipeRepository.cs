using System;
using System.Collections.Generic;
using CourseWork.Domain.Entities;

namespace CourseWork.Domain.Repositories.Abstract
{
    public interface IRecipeRepository
    {
        IEnumerable<Recipe> GetRecipes();
        Recipe Get(Guid id);
        Recipe Get(string title);
        void Save(Recipe recipe);
        void Delete(Guid id);
    }
}