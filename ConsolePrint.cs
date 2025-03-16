// See https://aka.ms/new-console-template for more information


class ConsolePrint
{
    public static void print()
    {
        try
        {
            string filePath = FilePath.getFilePath();
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}
