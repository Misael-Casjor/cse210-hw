using System.IO;


public static class FilesSaver
{

    public static string DateSaved()
        {
        DateTime theCurrentTime = DateTime.Now;
        return theCurrentTime.ToShortDateString();
        } 
    public static void SaveToFile(string answer)
        {
        string filename = "Save.txt";
        string dateText = DateSaved();

        using (StreamWriter outputFile = new StreamWriter(filename, true))
            {
                outputFile.WriteLine($"Date: {dateText} Entry:{answer}");
            }
        }  
}