using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

public interface IUserInterface
{
    string GetRecipeName();
    void PrintMessage(string message);
    void PrintExistingRecipes(IEnumerable<Recipe> existingRecipes);
    void PrintAllIngredients();
    IEnumerable<Ingredient> SelectIngredients();
    void ExitApplication();
}