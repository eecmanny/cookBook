public class Recipe : IngredientDisplay
{


    public Recipe(int ingredient) : base(ingredient)
    {
    }

    public void RecipeMaker()
    {
        Console.WriteLine("\nSelect an ingredient by number, type 0 to complete recipe and type \"exit\" to exit):");
        Console.WriteLine("");
        for (int i = 0; i < menuIngredientName.Count; i++)
        {
            if (!menuIngredientId.Contains(i + 1))
            {
                Console.WriteLine($"{i + 1}: {menuIngredientName[i]}");
            }
        }

        int userChoice;
        //The TryParse parse method checks to see if a int given and if so, by giving a bool value
        //and spits out the userChoice as a results if true per if statement
        bool isValidInput = int.TryParse(Console.ReadLine(), out userChoice);


        if (isValidInput && userChoice == 0)
        {
            //exit = true;
            Console.WriteLine("Exiting the ingredient selection.");

        }
        else if (isValidInput && userChoice >= 1 && userChoice <= 9)
        {
            Ingredient ingredient = new Ingredient(userChoice);
            ingredient.IngredientPicker();

            //This will add a number to the menuIngredientRecorder list if number is valid
            int userDeletedChoice = userChoice;
            menuIngredientId.Add(userDeletedChoice);

        }
        else
        {
            Console.WriteLine("Invalid choice, please try again.");
        }
    }
}
