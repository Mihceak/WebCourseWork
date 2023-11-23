using System;
using System.Collections.Generic;
using CourseWork.Domain.Entities;

namespace CourseWork.Domain.Repositories.Abstract
{
    public interface IIngredientListRepository
    {
        IEnumerable<IngredientList> GetRecipes();
        IngredientList Get(Guid id);
        void Save(IngredientList list);
        void Delete(Guid id);
    }
}