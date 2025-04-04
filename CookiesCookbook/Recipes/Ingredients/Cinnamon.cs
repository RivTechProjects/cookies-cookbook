namespace CookieCookbook.Recipes.Ingredients;
public class Cinnamon : Spice
{
    public override int Id => 6;
    public override string Name => "Cinnamon";
    public override string GetInstructions => $"Grind or measure powder and {base.GetInstructions} for a warm spice flavor.";
}