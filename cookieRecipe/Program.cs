using System.Security.Cryptography.X509Certificates;

CookBookIntro start = new CookBookIntro();
IngredientDisplay chefChoice = new IngredientDisplay(0);


start.IntroductionToChef();
chefChoice.MenuDisplayButtons();


Console.ReadKey();


class CookBookIntro
{
    public void IntroductionToChef()
    {
        Console.WriteLine("Hello Chef!!!");
        Console.WriteLine("Let's create a custom recipe");
        Console.WriteLine();
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
        //List needs to be declared outside of loop to store data in variable.
        List<int> menuIngredientRecorder = new List<int>();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nSelect an ingredient by number (or type 0 to exit):");
            //Variable will store the numbers entered by chef and the if statement will look throuh the list
            //and not display the counsole assoicated with the number



            if(!menuIngredientRecorder.Contains(1))
            {
                Console.WriteLine("1: Flour");
            }
            if (!menuIngredientRecorder.Contains(2))
            {
                Console.WriteLine("2: Egg");
            }
            if (!menuIngredientRecorder.Contains(3))
            {
                Console.WriteLine("3: Milk");
            }
            if (!menuIngredientRecorder.Contains(4))
            {
                Console.WriteLine("4: Oil");
            }
            if (!menuIngredientRecorder.Contains(5))
            {
                Console.WriteLine("5: Salt");
            }
            if (!menuIngredientRecorder.Contains(6))
            {
                Console.WriteLine("6: Sugar");
            }
            if (!menuIngredientRecorder.Contains(7))
            {
                Console.WriteLine("7: Vanilla");
            }
            if (!menuIngredientRecorder.Contains(8))
            {
                Console.WriteLine("8: Chocolate");
            }
            if (!menuIngredientRecorder.Contains(9))
            {
                Console.WriteLine("9: Cinnamon");
            }


            int userChoice;
            //The TryParse parse method checks to see if a int given and if so, by giving a bool value
            //and spits out the userChoice as a results if true per if statement
            bool isValidInput = int.TryParse(Console.ReadLine(), out userChoice);

            if (isValidInput && userChoice == 0)
            {
                exit = true;
                Console.WriteLine("Exiting the ingredient selection.");
            }
            else if (isValidInput && userChoice >= 1 && userChoice <= 9)
            {
                Ingredient ingredient = new Ingredient(userChoice);
                ingredient.IngredientPicker();

                //This will add a number to the menuIngredientRecorder list if number is valid
                int userDeletedChoice = userChoice;
                menuIngredientRecorder.Add(userDeletedChoice);

            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }

            
        }


        string completeList = "";
        //Takes the list of typed numbers and prints them with correlating description.
        //Console.WriteLine($"{menuIngredientRecorder.Count()}");
        foreach(int menuIngredientRecord in menuIngredientRecorder)
        {
            //Console.WriteLine($"{menuIngredientRecord}, ");
            completeList = menuIngredientRecord.ToString();
            if(completeList == "")
            {
                Console.WriteLine("Sorry Your Cookie Book is Empty");
            }
            completeList = $"{completeList}, {menuIngredientRecord}";
        }
    }
}

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
            2 => "Egg",
            3 => "Milk",
            4 => "Oil",
            5 => "Salt",
            6 => "Sugar",
            7 => "Vanilla",
            8 => "Chocolate",
            9 => "Cinnamon",
            //_ => "Print Recipe"
        };

        IngredientDescription ingridientDescription = new IngredientDescription(0);
        ingridientDescription.IngredientDescriptionAssigner(ingredientName);
    }
}

public class IngredientDescription : Ingredient
{
    public IngredientDescription(int ingredient) : base(ingredient) { }

    public void IngredientDescriptionAssigner(string ingredientName)
    {
        string ingredientDescription = ingredientName switch
        {
            "Flour" => "Flour is a powder made by grinding raw grains, roots, beans, nuts, or seeds.",
            "Egg" => "Eggs are a versatile ingredient that provide structure and richness.",
            "Milk" => "Milk is a nutrient-rich liquid food produced by mammals.",
            "Oil" => "Oil is a fat that is liquid at room temperature, often used for frying.",
            "Salt" => "Salt is a mineral composed primarily of sodium chloride, used to season food.",
            "Sugar" => "Sugar is a sweet-tasting, soluble carbohydrate, often used as a sweetener.",
            "Vanilla" => "Vanilla is a flavoring derived from orchids of the genus Vanilla.",
            "Chocolate" => "Chocolate is a preparation of roasted and ground cacao seeds, often sweetened.",
            "Cinnamon" => "Cinnamon is a spice obtained from the inner bark of several tree species.",
            _ => "Printing Recipe"
        };

        Console.WriteLine($"Description: {ingredientDescription}");
    }
}
