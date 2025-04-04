namespace CookieCookbook.RecipeManager;
using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;
public class RecipeManager : IRecipeManager
{
    private readonly IFileHelper _fileHelper;

    public RecipeManager(IFileHelper fileHelper)
    {
        _fileHelper = fileHelper;
    }

    public void SaveRecipe(string filePath, string recipeName, List<Recipe> allRecipes)
    {
        var recipeLines = allRecipes.Select(recipe => recipe.ToString()).ToList();
        _fileHelper.Write(filePath, recipeLines);
        PrintRecipeDetails(recipeName, allRecipes.Last().Ingredients);
    }

    public void PrintRecipesFromFile(string filePath)
    {
        // Read the file contents using FileHelper
        var recipeLines = _fileHelper.Read(filePath);

        // Check if the file is empty
        if (recipeLines.Count == 0)
        {
            Console.WriteLine("No recipes found in the file.");
            return;
        }

        // Print the recipes
        Console.WriteLine("Existing Recipes:");
        foreach (var line in recipeLines)
        {
            Console.WriteLine(line);
        }
    }

    public void PrintRecipeDetails(string recipeName, IEnumerable<Ingredient> ingredients)
    {
        Console.WriteLine("Recipe added:");
        Console.WriteLine($"Recipe: {recipeName}");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine($"- {ingredient.Name}");
        }
    }
}