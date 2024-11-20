




public class Ingredient : Menu
{
    public Ingredient(int ingredient) : base(ingredient) { }

    public virtual void IngredientPicker()
    {

        //string ingredientName;
        //switch (ingredient)
        //switch expression below is the same as the switch statement above.
        string ingredientName = Ingredient switch
        {
         //This switch expression is the same a switsh statement. It simplier and precise if you only have one cases.
            1 => "Flour",
            2 => "Eggs",
            3 => "Baking soda",
            4 => "Butter",
            5 => "Salt",
            6 => "Sugar",
            7 => "Vanilla",
            8 => "Chocolate",
            9 => "Brown sugar",
        };

        IngredientDescription ingridientDescription = new IngredientDescription(0);
        ingridientDescription.IngredientDescriptionAssigner(ingredientName);
    }
}
