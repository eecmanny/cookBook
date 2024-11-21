public class IngredientDescription : Ingredient
{
    public IngredientDescription(int ingredient) : base(ingredient) { }

    public void IngredientDescriptionAssigner(string ingredientName)
    {
        string ingredientDescription = ingredientName switch
        {
            "Flour" => "2 1/4 cups - Provides structure for the dough, giving cookies their shape.",
            "Eggs" => "2 large - Bind ingredients together and add moisture for a chewy texture.",
            "Baking soda" => "1 teaspoon - Helps the cookies rise and become light and fluffy.",
            "Butter" => "1 cup (2 sticks), softened - Adds richness and moisture, creating a tender cookie.",
            "Salt" => "1/2 teaspoon - Enhances flavor and balances sweetness.",
            "Sugar" => "3/4 cup - Sweetens the cookies and contributes to a tender texture.",
            "Vanilla" => "1 teaspoon - Adds a warm, sweet flavor.",
            "Chocolate" => "2 cups - Provide chocolatey bursts throughout the cookies for texture and flavor.",
            "Brown sugar" => "3/4 cup, packed - Adds sweetness and a hint of caramel flavor, while also making cookies chewier.",
            _ => "Printing Recipe"
        };

        Console.WriteLine($"Description: {ingredientDescription}");
    }
}