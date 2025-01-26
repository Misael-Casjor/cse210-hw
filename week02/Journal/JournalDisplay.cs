using System.IO;
public class Loader
{
   public static string ReadFromFile()
     {
     Console.WriteLine("Readig file");
     string _filename = "Save.txt";
     string [] all = System.IO.File.ReadAllLines(_filename);
     return string.Join("\n", all);
     }
}