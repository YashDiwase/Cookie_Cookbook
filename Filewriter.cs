// See https://aka.ms/new-console-template for more information


using System.Text;
using System.Text.Json;

public static class Filewriter
{
    public static void writeToFile(FileFormat type)
    {
        if(type == FileFormat.text)
        {
            string filePath = FilePath.getFilePath();

            string newContent = RecipeManager.getRecipe();

            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Use a StringBuilder to construct the modified content
            StringBuilder modifiedContent = new StringBuilder();
            bool inserted = false;

            foreach (string line in lines)
            {
                if (!inserted && string.IsNullOrWhiteSpace(line))
                {
                    // Insert new content at the first empty line
                    modifiedContent.AppendLine(newContent);
                    inserted = true;
                }
                else
                {
                    // Keep the existing content
                    modifiedContent.AppendLine(line);
                }
            }

            // Write the modified content back to the file
            File.WriteAllText(filePath, modifiedContent.ToString());
        }
        else
        {
            var listOfIngredients=RecipeManager._recipe;
            // Serialize the list to JSON
            string jsonString = JsonSerializer.Serialize(listOfIngredients);

            // Write the JSON string to a file
            File.WriteAllText("recipe.json", jsonString);
        }
        
    }

    public static FileFormat getFileTypeToWrite() {

        Console.WriteLine("which file type to write text[t] or json[j]");
        var fileType= Console.ReadLine();
       
        if (fileType == "j" || fileType == "J")
        {
            return FileFormat.json;
        }

        return FileFormat.text;
        
    
    }
}
