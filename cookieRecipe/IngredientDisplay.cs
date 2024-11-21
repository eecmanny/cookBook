public class IngredientDisplay : Menu
{
    private List<List<int>> recipes = new List<List<int>>(); // List to store multiple recipes

    public IngredientDisplay(int ingredient) : base(ingredient) { }

    public void MenuDisplayButtons()
    {
        List<int> currentRecipe = new List<int>();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nSelect an ingredient by number, type 0 to complete the recipe (this will store your recipe and start a new one), or type \"exit\" to quit:");

            // Display options only if they haven't been selected in the current recipe
            if (!currentRecipe.Contains(1)) Console.WriteLine("1: Flour");
            if (!currentRecipe.Contains(2)) Console.WriteLine("2: Egg");
            if (!currentRecipe.Contains(3)) Console.WriteLine("3: Baking soda");
            if (!currentRecipe.Contains(4)) Console.WriteLine("4: Butter");
            if (!currentRecipe.Contains(5)) Console.WriteLine("5: Salt");
            if (!currentRecipe.Contains(6)) Console.WriteLine("6: Sugar");
            if (!currentRecipe.Contains(7)) Console.WriteLine("7: Vanilla");
            if (!currentRecipe.Contains(8)) Console.WriteLine("8: Chocolate");
            if (!currentRecipe.Contains(9)) Console.WriteLine("9: Brown sugar");

            string userInput = Console.ReadLine();

            // Handle "exit" command to end the program
            if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                exit = true;
                Console.WriteLine("Exiting the ingredient selection.");
                //SummarizedRecipe ingriedentSummary = new SummarizedRecipe(0);
                //ingriedentSummary.SummarizedRecipeMaker();
                continue;
            }

            // Handle "0" command to store the current recipe and start a new one
            if (userInput == "0")
            {
                if (currentRecipe.Count > 0)
                {
                    recipes.Add(new List<int>(currentRecipe)); // Add the current recipe to the recipes list
                    Console.WriteLine("Recipe completed and stored! Starting a new recipe.\n");
                    currentRecipe.Clear(); // Reset the current recipe
                }
                else
                {
                    Console.WriteLine("No ingredients selected to save.");
                }
                continue;
            }

            // Parse input as ingredient selection
            bool isValidInput = int.TryParse(userInput, out int userChoice);

            if (isValidInput && userChoice >= 1 && userChoice <= 9)
            {
                currentRecipe.Add(userChoice);
                Ingredient ingredient = new Ingredient(userChoice);
                ingredient.IngredientPicker();
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }

        // Display all saved recipes when exiting
        DisplaySavedRecipes();
    }

    private void DisplaySavedRecipes()
    {
        if (recipes.Count > 0)
        {
            Console.WriteLine("\nAll Saved Recipes:");
            int recipeNumber = 1;
            foreach (var recipe in recipes)
            {
                Console.WriteLine($"\nRecipe {recipeNumber}:");
                foreach (int ingredientId in recipe)
                {
                    string ingredientName = new Ingredient(ingredientId).GetIngredientName();
                    Console.WriteLine($"- {ingredientName}");
                }
                recipeNumber++;
            }
        }
        else
        {
            Console.WriteLine("No recipes were saved.");
        }
    }
}