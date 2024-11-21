public class SummarizedRecipe : IngredientDisplay
{
    public SummarizedRecipe(int ingredient) : base(ingredient)
    {
    }

    public void SummarizedRecipeMaker()
    {
        if (!menuIngredientId.Contains(0)/* || Exit*/)
        {
            Console.WriteLine("your recipe is complete");
        }

        string completeList = "";
        //takes the list of typed numbers and prints them with correlating description.
        // check if there are any items in menuIngredientRecorder
        if (!menuIngredientId.Any())
        {
            Console.WriteLine("sorry, your cookie book is empty");
        }
        else
        {
            // loop through each item and append it to completelist
            foreach (int menuIngredientRecord in menuIngredientId)
            {
                completeList += $"{menuIngredientRecord}, ";
            }

            // remove the trailing comma and space
            completeList = completeList.TrimEnd(',', ' ');

            // print the final list on a single line
            Console.WriteLine(completeList);
        }

        List<string> multiplecompletelist = new List<string>();

        multiplecompletelist.Add(completeList);

        Console.WriteLine(multiplecompletelist);

    }
}

