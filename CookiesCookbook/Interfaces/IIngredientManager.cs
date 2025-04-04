using CookieCookbook.Recipes.Ingredients;
public interface IIngredientManager
{
    IEnumerable<Ingredient> AllIngredients { get; }
    Ingredient GetIngredientById(int id);
}