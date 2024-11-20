using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        CookBookIntro start = new CookBookIntro();
        IngredientDisplay chefChoice = new IngredientDisplay(0);

        start.IntroductionToChef();
        chefChoice.MenuDisplayButtons();

        Console.ReadKey();
    }
}

class CookBookIntro
{
    public void IntroductionToChef()
    {
        Console.WriteLine("Hello Chef!!!");
        Console.WriteLine("Let's create multiple custom recipes");
        Console.WriteLine();
        Console.WriteLine("Here is a list of ingredients:");
    }
}

public class Menu
{
    protected int Ingredient { get; private set; }

    public Menu(int ingredient)
    {
        Ingredient = ingredient;
    }
}

class IngredientDisplay : Menu
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

public class Ingredient : Menu
{
    public Ingredient(int ingredient) : base(ingredient) { }

    public virtual void IngredientPicker()
    {
        string ingredientName = GetIngredientName();
        IngredientDescription ingredientDescription = new IngredientDescription(Ingredient);
        ingredientDescription.IngredientDescriptionAssigner(ingredientName);
    }

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
            _ => "No description available."
        };

        Console.WriteLine($"Description: {ingredientDescription}");
    }
}
