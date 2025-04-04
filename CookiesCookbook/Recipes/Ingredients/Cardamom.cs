namespace CookieCookbook.Recipes.Ingredients;
public class Cardamom : Spice
{
    public override int Id => 4;
    public override string Name => "Cardamom"; // override the Name property to return "Cardamom"
    public override string GetInstructions => $"Crush pods {base.GetInstructions}."; // return instructions for using cardamom
}