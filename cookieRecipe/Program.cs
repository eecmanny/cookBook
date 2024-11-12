

class CookBookIntro
{
    public void IntroductionToChef()
    {
        Console.WriteLine("Hello Chef!!!");
        Console.WriteLine("Let's create a custom recipe");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Here is a list of ingredients:");
    }
}

public class Menu
{
    // Ingredient picked by user
    protected int Ingredient { get; private set; }

    public Menu(int ingredient)
    {
        Ingredient = ingredient;
    }
}

class IngredientDisplay : Menu
{
    //when a class inherits from a base class with a constructor that takes parameters(like Menu here), the derived class must explicitly
    //call that base class constructor if it doesn’t have a parameterless constructor.This is where : base(ingredient) comes in.
    public IngredientDisplay(int ingredient) : base(ingredient) { }

    public void MenuDisplayButtons()
    {
        Console.WriteLine("Select an ingredient by number:");
        Console.WriteLine("1: Flour");
        Console.WriteLine("2: Egg");
        Console.WriteLine("3: Milk");
        Console.WriteLine("4: Oil");
        Console.WriteLine("5: Salt");
        Console.WriteLine("6: Sugar");
        Console.WriteLine("7: Vanilla");
        Console.WriteLine("8: Chocolate");
        Console.WriteLine("9: Cinnamon");
    }
}

public class Ingredient : Menu
{
    public Ingredient(int ingredient) : base(ingredient) { }

    public void IngredientPicker()
    {
        Console.WriteLine("MenuIngredientPicker method works");
        Console.WriteLine($"You selected ingredient number {Ingredient}");
    }
}
