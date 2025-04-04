using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

public interface IRecipeManager
{
    void SaveRecipe(string filePath, string recipeName, List<Recipe> allRecipes);
    void PrintRecipeDetails(string recipeName, IEnumerable<Ingredient> ingredients);
    void PrintRecipesFromFile(string filePath);
}