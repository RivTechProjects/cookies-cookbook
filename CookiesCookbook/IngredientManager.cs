namespace CookieCookbook.IngredientManager;
using CookieCookbook.Recipes.Ingredients;
public class IngredientManager : IIngredientManager
{
    public IEnumerable<Ingredient> AllIngredients { get; } = new List<Ingredient>
    {
        new AllPurposeFlour(),
        new WheatFlour(),
        new AlmondFlour(),
        new CoconutFlour(),
        new Sugar(),
        new Butter(),
        new Cardamom(),
        new Cinnamon(),
        new ChocolateChips(),
        new CocoaPowder(),
        new Oatmeal()
    };

    public Ingredient GetIngredientById(int id)
    {
       foreach (var ingredient in AllIngredients)
        {
            if (ingredient.Id == id)
            {
                return ingredient;
            }
        }
        throw new KeyNotFoundException($"Ingredient with ID {id} was not found.");
    }
}