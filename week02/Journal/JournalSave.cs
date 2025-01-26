using System.IO;


public static class FilesSaver
{

    public static string DateSaved()
        {
        DateTime theCurrentTime = DateTime.Now;
        return theCurrentTime.ToShortDateString();
        } 
    public static void SaveToFile(string _answer)
        {
        string _filename = "Save.txt";
        string _dateText = DateSaved();

        using (StreamWriter outputFile = new StreamWriter(_filename, true))
            {
                outputFile.WriteLine($"Date: {_dateText} Entry:{_answer}");
            }
        }  
}