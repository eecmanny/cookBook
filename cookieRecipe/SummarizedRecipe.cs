//public class SummarizedRecipe : IngredientDisplay
//{
//    public SummarizedRecipe(int ingredient) : base(ingredient)
//    {
//    }

//    public void SummarizedRecipeMaker()
//    {
//        if (!menuIngredientId.Contains(0) || exit)
//        {
//            Console.WriteLine("Your Recipe is Complete");
//        }

//        string completeList = "";
//        //Takes the list of typed numbers and prints them with correlating description.
//        // Check if there are any items in menuIngredientRecorder
//        if (!menuIngredientId.Any())
//        {
//            Console.WriteLine("Sorry, Your Cookie Book is Empty");
//        }
//        else
//        {
//            // Loop through each item and append it to completeList
//            foreach (int menuIngredientRecord in menuIngredientId)
//            {
//                completeList += $"{menuIngredientRecord}, ";
//            }

//            // Remove the trailing comma and space
//            completeList = completeList.TrimEnd(',', ' ');

//            // Print the final list on a single line
//            Console.WriteLine(completeList);
//        }

//        List<string> multipleCompleteList = new List<string>();

//        multipleCompleteList.Add(completeList);

//        Console.WriteLine(multipleCompleteList);

//    }
//}
//}
