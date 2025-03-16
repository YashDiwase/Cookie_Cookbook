// See https://aka.ms/new-console-template for more information


public class RecipeManager
{
    public static List<Ingredient> _recipe=new List<Ingredient>();
    public void createRecipe()
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("Add an ingredient by its ID or type anything else if finished");
            var userInput = Console.ReadLine();
            Ingredient? ig =null;
            int result;
            bool isParsingSuccess = int.TryParse(userInput, out result);
            if (isParsingSuccess)

            {
                switch (result)
                {
                    case 1:
                        ig = new Wheat(1, "Wheat Flour");
                        _recipe.Add(ig);
                        break;
                    case 2:
                        ig = new Coconut_flour(2, "Coconut Flour");
                        _recipe.Add(ig);
                        break;
                    case 3:
                        ig = new Butter(3, "Butter");
                        _recipe.Add(ig);
                        break;
                    case 4:
                        ig = new Chocolate(4, "Chocolate");
                        _recipe.Add(ig);
                        break;
                    case 5:
                        ig = new Sugar(1, "Sugar");
                        _recipe.Add(ig);
                        break;
                    case 6:
                        ig = new Cardamom(1, "Cardamom");
                        _recipe.Add(ig);
                        break;
                    case 7:
                        ig = new Cinnamon(1, "Cinnamon");
                        _recipe.Add(ig);
                        break;
                    case 8:
                        ig = new Cocoa_powder(1, "Cocoa powder");
                        _recipe.Add(ig);
                        break;
                    default:
                        loop = false;
                        break;
                }
            }
            else
            {
                loop = false;
            }
        }
        printRecipe();
        var fileType = Filewriter.getFileTypeToWrite();
        Filewriter.writeToFile(fileType);

    }

    public static string getRecipe()
    {
        string str = "  *****   "+"\n";
        foreach (Ingredient i in _recipe)
        {
            str += i.Name + "." + i.preparation_instructions() + "\n";
        }
        str += "\n";
        return str;
    }

    public void printRecipe()
    {
        string str = "recipe added";
        str += "\n";
        str += getRecipe();
        str += "\n";
        Console.WriteLine(str);
    }
}
