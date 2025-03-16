// See https://aka.ms/new-console-template for more information





class FilePath
{
    public static string getFilePath()
    {

        DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
        string filePath = "";
        int levelsUp = 4; // Change this to the number of levels you want to go up
        for (int i = 0; i < levelsUp; i++)
        {
            if (directoryInfo.Parent != null)
            {
                directoryInfo = directoryInfo.Parent;
            }
            else
            {
                Console.WriteLine("Reached the root directory.");
                break;
            }
        }
        filePath=directoryInfo.FullName;
        filePath += "\\Resources\\display.txt";
        return filePath;
    }
}