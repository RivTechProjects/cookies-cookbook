namespace CookieCookbook.App;
using CookieCookbook.Recipes;
public class CookiesCookBookApp
{
    private readonly IRecipeManager _recipeManager;    private readonly IUserInterface _userInterface;

    public CookiesCookBookApp(IRecipeManager recipeManager, IUserInterface userInterface)
    {
        _recipeManager = recipeManager;
        _userInterface = userInterface;
    }

    public void Run(string filePath)
    {
        // Step 1: Print existing recipes
        _recipeManager.PrintRecipesFromFile(filePath);

        // Step 2: Create a new recipe
        _userInterface.PrintMessage("Create a new recipe! Please select ingredients from the list.");
        var selectedIngredients = _userInterface.SelectIngredients();
        var allRecipes = new List<Recipe>();

        if (selectedIngredients.Count() > 0)
        {
            string recipeName = _userInterface.GetRecipeName();
            var recipe = new Recipe(recipeName, selectedIngredients);
            allRecipes.Add(recipe);
            _recipeManager.SaveRecipe(filePath, recipeName, allRecipes);
            _recipeManager.PrintRecipeDetails(recipeName, selectedIngredients);
        }
        else
        {
            _userInterface.PrintMessage("No ingredients have been selected. Recipe will not be saved.");
        }

        // Step 3: Exit the application
        _userInterface.ExitApplication();
    }
}