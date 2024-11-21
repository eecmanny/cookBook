public class Menu
{
    // Ingredient picked by user
    protected int Ingredient { get; private set; }

    // List of all ingredient names
    protected List<string> menuIngredientName { get; private set; }

    // List of selected ingredient IDs
    protected List<int> menuIngredientId { get; private set; }

    public Menu(int ingredient)
    {
        Ingredient = ingredient;
        InitializeIngredients();
        menuIngredientId = new List<int>(); // Initialize empty list for selected IDs
    }

    // Method to initialize ingredient names
    private void InitializeIngredients()
    {
        menuIngredientName = new List<string>
        {
            "Flour", "Eggs", "Baking soda", "Butter", "Salt",
            "Sugar", "Vanilla", "Chocolate", "Brown sugar"
        };
    }
}