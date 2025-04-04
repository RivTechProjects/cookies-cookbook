namespace CookieCookbook.Recipes.Ingredients
{
    public abstract class Ingredient
    {
        // Base class for all ingredients
        public abstract int Id { get; }
        public abstract string Name { get; }
        public abstract string GetInstructions { get; }
        public override string ToString()
        {
            return $"{Id}. {Name}";
        }

    }

}