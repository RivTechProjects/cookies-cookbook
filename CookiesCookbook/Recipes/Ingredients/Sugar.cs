namespace CookieCookbook.Recipes.Ingredients;
public class Sugar : Ingredient
{
    public override int Id => 10;
    public override string Name => "Sugar"; // override the Name property to return "Sugar"
    public override string GetInstructions => "Measure 1 cup and add to bowl.";
}