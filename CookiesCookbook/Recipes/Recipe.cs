using System.Security.Cryptography.X509Certificates;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes;

public class Recipe
{
    public IEnumerable<Ingredient> Ingredients { get; }
    public string RecipeName { get; }

    public Recipe(string recipeName, IEnumerable<Ingredient> ingredients)
    {
        Ingredients = ingredients;
        RecipeName = recipeName;
    }

    public override string ToString()
    {
        var steps = new List<string>
    {
        $"Recipe: {RecipeName}", // Add the recipe name as the first line
        "Ingredients:"           // Add the "Ingredients" header
    };

        // Add each ingredient's details to the list
        steps.AddRange(Ingredients.Select(ingredient => $"- {ingredient.Name}: {ingredient.GetInstructions}"));

        // Join all the steps with line breaks
        return string.Join(Environment.NewLine, steps);
    }
}