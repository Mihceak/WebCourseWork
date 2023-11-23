using CourseWork.Domain.Repositories.Abstract;

namespace CourseWork.Domain
{
    public class DataManager
    {
        public IIngredientRepository Ingredients { get; set; }
        public IIngredientListRepository IngredientLists { get; set; }
        public IRecipeRepository Recipes { get; set; }

        public DataManager(
            IIngredientRepository ingredients, 
            IIngredientListRepository ingredientLists, 
            IRecipeRepository recipes)
        {
            Ingredients = ingredients;
            IngredientLists = ingredientLists;
            Recipes = recipes;
        }
    }
}