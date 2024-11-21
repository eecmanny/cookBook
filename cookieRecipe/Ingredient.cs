public class Ingredient : Menu
{
    public Ingredient(int ingredient) : base(ingredient) { }

    public virtual void IngredientPicker()
    {
        string ingredientName = GetIngredientName();
        IngredientDescription ingredientDescription = new IngredientDescription(Ingredient);
        ingredientDescription.IngredientDescriptionAssigner(ingredientName);
    }

    //string ingredientName;
    //switch (ingredient)
    //switch expression below is used in the List above.
    public string GetIngredientName()
    {
        return Ingredient switch
        {
            1 => "Flour",
            2 => "Eggs",
            3 => "Baking soda",
            4 => "Butter",
            5 => "Salt",
            6 => "Sugar",
            7 => "Vanilla",
            8 => "Chocolate",
            9 => "Brown sugar",
            _ => "Unknown"
        };
    }
}
