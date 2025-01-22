using System.IO;

public static class FilesSaver
{
    public static void SaveToFile(string answer)
        {
        string filename = "Save.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(answer);
            }
        }  
}