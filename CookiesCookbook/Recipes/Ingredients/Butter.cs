namespace CookieCookbook.Recipes.Ingredients;
public class Butter : Ingredient
{
    public override int Id => 3;
    public override string Name => "Butter"; // override the Name property to return "Butter"
    public override string GetInstructions => "Soften butter to room temperature. Cream it with sugar until light and fluffy.";
    
}