//public class summarizedrecipe : ingredientdisplay
//{
//    public summarizedrecipe(int ingredient) : base(ingredient)
//    {
//    }

//    public void summarizedrecipemaker()
//    {
//        if (!menuingredientid.contains(0) || exit)
//        {
//            console.writeline("your recipe is complete");
//        }

//        string completelist = "";
//        //takes the list of typed numbers and prints them with correlating description.
//        // check if there are any items in menuingredientrecorder
//        if (!menuingredientid.any())
//        {
//            console.writeline("sorry, your cookie book is empty");
//        }
//        else
//        {
//            // loop through each item and append it to completelist
//            foreach (int menuingredientrecord in menuingredientid)
//            {
//                completelist += $"{menuingredientrecord}, ";
//            }

//            // remove the trailing comma and space
//            completelist = completelist.trimend(',', ' ');

//            // print the final list on a single line
//            console.writeline(completelist);
//        }

//        list<string> multiplecompletelist = new list<string>();

//        multiplecompletelist.add(completelist);

//        console.writeline(multiplecompletelist);

//    }
//}
//}
