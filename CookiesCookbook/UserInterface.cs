using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

public class UserInterface : IUserInterface
{
    private readonly IIngredientManager _ingredientManager;
    public UserInterface(IIngredientManager ingredientManager)
    {
        _ingredientManager = ingredientManager;
    }
    public string GetRecipeName()
    {
        PrintMessage("Enter the name of your recipe: ");
        return Console.ReadLine() ?? string.Empty;;
    }

    public void PrintExistingRecipes(IEnumerable<Recipe> existingRecipes)
    {
        if (existingRecipes.Count() > 0)
        {
            PrintMessage("Existing Recipes:" + Environment.NewLine);

            var counter = 1;
            foreach (var recipe in existingRecipes)
            {
                PrintMessage($"{counter}. {recipe}");
                PrintMessage("");
                counter++;
            }
        }
    }

    public void PrintAllIngredients()
    {
        var allIngredients = _ingredientManager.AllIngredients.OrderBy(ingredient => ingredient.Id);
        PrintMessage("Available Ingredients:");
        foreach (var ingredient in allIngredients)
        {
            PrintMessage($"{ingredient.Id}. {ingredient.Name}");
        }
    }

    public IEnumerable<Ingredient> SelectIngredients()
    {
        PrintAllIngredients();

        var selectedIngredients = new List<Ingredient>();

        while (true)
        {
            PrintMessage("Enter the ID of the ingredient to add (or -1 to finish): ");
            string input = Console.ReadLine() ?? string.Empty;

            if (input == "-1")
            {
                break; // Exit the loop if the user is done selecting ingredients
            }

            if (int.TryParse(input, out int ingredientId))
            {
                // Add the selected ingredient to the list
                var selectedIngredient = _ingredientManager.GetIngredientById(ingredientId);
                if (selectedIngredients is not null)
                {
                    selectedIngredients.Add(selectedIngredient);
                }

                PrintMessage($"{selectedIngredient.Name} added to the recipe.");
            }
            else
            {
                PrintMessage("Invalid input. Please try again.");
            }
        }

        return selectedIngredients ?? [];
    }

    public void ExitApplication()
    {
        PrintMessage("Press any key to exit.");
        Console.ReadKey();
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}